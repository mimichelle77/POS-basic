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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        //連線資訊
        static string connStr = "server=localhost;port=3306;user=root;password=;database=IceSystem;Charset=utf8";
        //實體化conn的MySqlConnection物件
        static MySqlConnection conn = new MySqlConnection(connStr);
        MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM customer;", conn);
        DataSet ds = new DataSet(); //宣告資料集
        BindingSource bs = new BindingSource(); // 宣告資料繫結器

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear(); 
                myAdapter.FillSchema(ds, SchemaType.Mapped);
                myAdapter.Fill(ds); 
                bs.DataSource = ds.Tables[0]; // 將dataset binding至bs.DataSource中
                if (txtcID.DataBindings.Count == 0)
                {
                    txtcID.DataBindings.Add("Text", bs, "cid");
                    txtcName.DataBindings.Add("Text", bs, "cname");
                    txtAddr.DataBindings.Add("Text", bs, "address");
                    txtPhone.DataBindings.Add("Text", bs, "phone");
                }
                chkButton(); //上/下一筆按鈕狀態
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                //throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)// 新增客戶資料
        {
            addMode(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)// 讀取上一ID的資料
        {
            bs.MovePrevious(); 
            chkButton();
        }

        private void btnNext_Click(object sender, EventArgs e)// 讀取下一ID的資料
        {
            bs.MoveNext(); 
            chkButton();
        }

        private void btnDel_Click(object sender, EventArgs e)// 刪除客戶資料
        {
            // 確認刪除的對話方塊
            var msgResult = MessageBox.Show("您確定要刪除嗎?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (msgResult == DialogResult.Yes)
            {
                try
                {
                    bs.RemoveCurrent(); // 將目前檢視的資料移除，並先回寫到dataset中
                    new MySqlCommandBuilder(myAdapter); 
                    var status = myAdapter.Update(ds.Tables[0]); 
                    // 如果Update返回的狀態碼為1，表示刪除成功
                    if (status == 1) MessageBox.Show("資料刪除成功!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);// 在VS"輸出"偵錯區段印出錯誤訊息
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
                    command.CommandText = "INSERT into customer(cid, cname, address, phone) values(@cid, @cname, @address, @phone);";
                    command.Parameters.AddWithValue("@cid", txtcID.Text);
                    command.Parameters.AddWithValue("@cname", txtcName.Text);
                    command.Parameters.AddWithValue("@address", txtAddr.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
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
                    command.CommandText = "UPDATE customer SET cname = @cname, address = @address, phone = @phone WHERE cid = @cid;";
                    command.Parameters.AddWithValue("@cid", txtcID.Text);
                    command.Parameters.AddWithValue("@cname", txtcName.Text);
                    command.Parameters.AddWithValue("@address", txtAddr.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    int status = command.ExecuteNonQuery();
                    // 如果Update返回的狀態碼為1，則表示更新成功；顯示一個MessageBox
                    if (status == 1) MessageBox.Show("資料更新成功!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); 
                MessageBox.Show(ex.ToString(), "Error!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)// 客戶明細資料
        {
            try
            {
                conn.Open();
                // 檢視資料
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM customer;";
                MySqlDataReader reader = command.ExecuteReader();
                string str = "ID\tName\tAddress".PadRight(20) + "\tPhone\r\n";
                while (reader.Read())//逐行讀取
                    str += reader[0] + "\t" + reader[1] + "\t" + reader[2].ToString().PadRight(20) + "\t" + reader[3] + "\r\n";
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

        private void btnCancel_Click(object sender, EventArgs e)// 取消按鈕
        {
            if (btnOK.Text == "確認新增")
                addMode(0);
            else Close();
        }

        private void chkButton()//上/下一筆按鈕狀態
        {
            if (bs.Position == 0) btnPrev.Enabled = false;
            else btnPrev.Enabled = true;
            if (bs.Position == bs.Count - 1) btnNext.Enabled = false;
            else btnNext.Enabled = true;
        }

        private void addMode(int mode)
        {
            if (mode == 1)
            {
                txtcID.ReadOnly = false;
                txtcID.DataBindings.Clear();
                txtcName.DataBindings.Clear();
                txtAddr.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtcID.Text = txtcName.Text = txtAddr.Text = txtPhone.Text = "";
                btnPrev.Visible = btnNext.Visible = btnDel.Visible = btnAdd.Visible = false;
                btnOK.Text = "確認新增";
            }
            else if (mode == 0)
            {
                txtcID.ReadOnly = true;
                btnOK.Text = "確認修改";
                btnPrev.Visible = btnNext.Visible = btnDel.Visible = btnAdd.Visible = true;
                CustomerForm_Load(this, new EventArgs());
            }
        }
    }
}
