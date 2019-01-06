using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace IceSystem
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        //連線資訊
        static string connStr = "server=localhost;port=3306;user=root;password=;database=IceSystem;Charset=utf8";
        //實體化conn的MySqlConnection物件
        static MySqlConnection conn = new MySqlConnection(connStr);
        MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM product;", conn);
        DataSet ds = new DataSet(); // 宣告資料集
        BindingSource bs = new BindingSource(); // 宣告資料繫結器

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear(); 
                myAdapter.Fill(ds); 
                bs.DataSource = ds.Tables[0]; // 將dataset binding至bs.DataSource中
                if (txtpID.DataBindings.Count == 0)
                {   
                    txtpID.DataBindings.Add("Text", bs, "pid"); //到textBox的指定屬性，資料來源資料表，資料來源的欄位
                    txtpName.DataBindings.Add("Text", bs, "pname");
                    txtPrice.DataBindings.Add("Text", bs, "price");
                    txtInventory.DataBindings.Add("Text", bs, "Inventory");
                    txtSafeInventory.DataBindings.Add("Text", bs, "SafeInventory");
                }
                chkButton();//上/下一筆按鈕狀態
                chkInventory();//庫存量確認
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                //throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//新增商品資料
        {
            addMode(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)// 讀取上一ID的資料
        {
            bs.MovePrevious(); 
            chkButton();
            chkInventory();
        }

        private void btnNext_Click(object sender, EventArgs e)// 讀取下一ID的資料
        {
            bs.MoveNext(); 
            chkButton();
            chkInventory();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // 確認刪除對話方塊
            var msgResult = MessageBox.Show("您確定要刪除嗎?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                try
                {
                    bs.RemoveCurrent(); // 將目前檢視的資料移除，並先回寫到dataset中
                    new MySqlCommandBuilder(myAdapter); 
                    var status = myAdapter.Update(ds.Tables[0]); 
                    // 如果Update返回的狀態碼為1，則表示刪除成功；顯示一個MessageBox
                    if (status == 1) MessageBox.Show("資料刪除成功!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message); // 在VS"輸出"偵錯區段印出錯誤訊息
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOK.Text == "確認新增")// 新增資料
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandText = "INSERT into product(pid, pname, price, inventory, safeinventory) values(@pid, @pname, @price, @inventory, @safeinventory);";
                    command.Parameters.AddWithValue("@pid", txtpID.Text); 
                    command.Parameters.AddWithValue("@pname", txtpName.Text); 
                    command.Parameters.AddWithValue("@price", txtPrice.Text);
                    command.Parameters.AddWithValue("@inventory", txtInventory.Text);
                    command.Parameters.AddWithValue("@safeinventory", txtSafeInventory.Text);
                    int status = command.ExecuteNonQuery();
                    if (status == 1)
                    {
                        MessageBox.Show("資料加入成功!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addMode(0);
                    }
                }
                else // 修改資料
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandText = "UPDATE product SET pname = @pname, price = @price, inventory = @inventory, safeinventory = @safeinventory WHERE pid = @pid;";
                    command.Parameters.AddWithValue("@pid", txtpID.Text); 
                    command.Parameters.AddWithValue("@pname", txtpName.Text);
                    command.Parameters.AddWithValue("@price", txtPrice.Text);
                    command.Parameters.AddWithValue("@inventory", txtInventory.Text);
                    command.Parameters.AddWithValue("@safeinventory", txtSafeInventory.Text);
                    int status = command.ExecuteNonQuery();
                    // 如果Update返回的狀態碼為1，則表示刪除成功；顯示一個MessageBox
                    if (status == 1) MessageBox.Show("資料更新成功!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // 在VS"輸出"偵錯區段印出錯誤訊息
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                chkInventory();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)// 取消按鈕
        {
            if (btnOK.Text == "確認新增")
                addMode(0);
            else Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)// 商品明細資料
        {
            try
            {
                conn.Open();
                // 檢視資料
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM product;";
                MySqlDataReader reader = command.ExecuteReader();
                string str = "ID\tName\tPrice\tInventory\tSafe Inventory\r\n";
                while (reader.Read())
                    str += reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4] + "\r\n";
                MessageBox.Show(str);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        
        private void chkButton()//上/下一筆按鈕狀態
        {
            if (bs.Position == 0) btnPrev.Enabled = false;
            else btnPrev.Enabled = true;
            if (bs.Position == bs.Count - 1) btnNext.Enabled = false;
            else btnNext.Enabled = true;
        }

        private void chkInventory()// 庫存量確認
        {
            if (int.Parse(txtInventory.Text) <= int.Parse(txtSafeInventory.Text))
            {
                errorProvider1.SetError(txtInventory, "警告! 庫存量不足!!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void addMode(int mode)
        {
            if (mode == 1)
            {
                txtpID.ReadOnly = false;
                txtpID.DataBindings.Clear();
                txtpName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtInventory.DataBindings.Clear();
                txtSafeInventory.DataBindings.Clear();
                txtpID.Text = txtpName.Text = txtPrice.Text = txtInventory.Text = txtSafeInventory.Text = "";
                btnPrev.Visible = btnNext.Visible = btnDel.Visible = btnAdd.Visible = false;
                btnOK.Text = "確認新增";
            }
            else if (mode == 0)
            {
                txtpID.ReadOnly = true;
                btnOK.Text = "確認修改";
                btnPrev.Visible = btnNext.Visible = btnDel.Visible = btnAdd.Visible = true;
                ProductForm_Load(this, new EventArgs());
            }
        }
    }
}
