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
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }
        double subPrice = 0.0;
        static string connStr = "server=localhost;port=3306;user=root;password=;database=IceSystem;Charset=utf8";
        // 實體化conn的MySqlConnection物件
        static MySqlConnection conn = new MySqlConnection(connStr);
        protected static DataSet ds = new DataSet(); // 宣告資料集
        MySqlDataAdapter adaCusPro = new MySqlDataAdapter("SELECT * FROM iceorder;", conn);
        MySqlDataAdapter adaPro = new MySqlDataAdapter("SELECT * FROM product;", conn);
        //BindingSource bs = new BindingSource(); // 宣告資料繫結器

        private void POSForm_Load(object sender, EventArgs e)
        {
            // 預先在數量下拉式選單中填入1~5
            for (int i = 0; i < 5; i++)
                cboQuo.Items.Add(i + 1);
            try
            {
                ds.Clear(); 
                adaPro.Fill(ds, "product"); // 將dataAdapter中的資料來源填入dataset中
                cboProduct.DisplayMember = "pname";
                cboProduct.ValueMember = "price";
                cboProduct.DataSource = ds.Tables["product"];

                using (MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM customer;", conn))
                {
                    myAdapter.Fill(ds, "customer"); // 將dataAdapter中的資料來源填入dataset中
                    cboCustomer.DisplayMember = "cname";//combobox顯示的值
                    cboCustomer.ValueMember = "cid";
                    cboCustomer.DataSource = ds.Tables["customer"];
                    cboCustomer.SelectedValue = 1000;
                }

                using (MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM customer;", conn))
                {
                    myAdapter.Fill(ds, "cuspro"); // 將dataAdapter中的資料來源填入dataset中
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // 在VS"輸出"偵錯區段印出錯誤訊息
            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)//選擇飲品
        {            
            try
            {
                lblProPrice.Text = cboProduct.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }       
        
        private void cboQuo_SelectedIndexChanged(object sender, EventArgs e)//選擇數量
        {
            // 如果尚未選擇品項，則不新增品項至待購清單
            if (cboProduct.Text == "")
                MessageBox.Show("請選擇品項!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!System.Text.RegularExpressions.Regex.IsMatch(cboQuo.Text, "\\d+"))
                MessageBox.Show("數量欄位請輸入正確！", "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataRow[] dr = ds.Tables["product"].Select("pname = '" + cboProduct.Text + "'");
                // 新增品項至待購清單(品名及數量)
                lsbProduct.Items.Add(dr[0].ItemArray[0] + "_" + cboProduct.Text + "_" + cboProduct.SelectedValue);
                lsbQuo.Items.Add(cboQuo.Text);
                updateSubPri();
            }
        }

        private void cboQuo_KeyDown(object sender, KeyEventArgs e)
        {
            // 若在數量文字方塊中按下Enter鍵，則新增品項至待購清單
            if (e.KeyCode == Keys.Enter) cboQuo_SelectedIndexChanged(this, new EventArgs());
        }

        private void lsbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 同步由雙listbox清單所選取的index，避免清單選取不同步的現象
            lsbQuo.SelectedIndex = lsbProduct.SelectedIndex;
        }

        private void lsbQuo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 同步由雙listbox清單所選取的index，避免清單選取不同步的現象
            lsbProduct.SelectedIndex = lsbQuo.SelectedIndex;
        }

        private void btnDel_Click(object sender, EventArgs e)//刪除
        {
            int chosenIdx;
            // 若有選擇清單中的項目，則刪除該項目
            if (lsbProduct.SelectedIndex != -1)
            {
                chosenIdx = lsbProduct.SelectedIndex;
                lsbProduct.Items.RemoveAt(chosenIdx);
                lsbQuo.Items.RemoveAt(chosenIdx);
            }
            else if (lsbQuo.SelectedIndex != -1)
            {
                chosenIdx = lsbQuo.SelectedIndex;
                lsbQuo.Items.RemoveAt(chosenIdx);
                lsbProduct.Items.RemoveAt(chosenIdx);
            }
            // 自動更新小計價格，及恢復總價欄位
            updateSubPri();
            lblTotalPri.Text = "總價 $-----";
        }

        private void chkingpb_CheckedChanged(object sender, EventArgs e)//計算折扣的選取狀態
        {
            // 在Groupbox中如果按下某一checkbox後，該checkbox為已勾選的狀態
            if ((sender as CheckBox).Checked == true)
            {
                // 僅能勾選一個checkbox
                foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                    if (chk != sender) chk.Checked = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)//確認結帳
        {
            double totalPrice = 0.0;
            double discount = 0.0;
            if (subPrice != 0.0)
            {
                // 走訪Groupbox中的控制項
                foreach (var c in gpbOff.Controls)
                {
                    var chk = (CheckBox)c;
                    // 將勾選的checkbox中的name屬性做文字篩選後直接乘上小計，俾以算出總金額
                    if (chk.Checked == true)
                    {
                        if (chk.Text.ToString() != "不折扣")
                        {
                            discount = double.Parse(chk.Text.ToString().Substring(0, 1)) / 10;
                        }
                        else discount = 1;
                        totalPrice = subPrice * discount;
                    }
                }
                updateData(discount);

                // 處理 label 文字並彈出文字方塊
                lblTotalPri.Text = "總價 $" + totalPrice;
                MessageBox.Show("結帳作業完成!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請選擇品項!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void updateSubPri()
        {
            // 將小計價格歸0
            subPrice = 0;
            // 走訪清單項目
            for (int i = 0, length = lsbProduct.Items.Count; i < length; i++)
            {
                // 運用下底線('_')字元把每一項分成兩半
                var splitArr = lsbProduct.Items[i].ToString().Split('_');
                try
                {
                    subPrice += double.Parse(splitArr[2]) * double.Parse(lsbQuo.Items[i].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
                // 將每一項的單價及數量相乘並累加至 subPrice 中
            }
            // 更新小計價格
            lblSubPri.Text = "小計 $" + subPrice;
        }

        private void updateData(double discount)
        {
            adaCusPro.Fill(ds, "cuspro");
            // 走訪清單項目
            for (int i = 0, length = lsbProduct.Items.Count; i < length; i++)
            {
                // 運用下底線('_')字元把每一項分成兩半
                var splitArr = lsbProduct.Items[i].ToString().Split('_');
                try
                {
                    // 運用datarow找出相關產品的原始庫存
                    DataRow[] productRow =
                    ds.Tables["product"].Select("pid = '" + int.Parse(splitArr[0]) + "'");
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;

                    command.CommandText = "UPDATE `product` SET `inventory` = @inventory WHERE `product`.`pid` = @pid;";
                    var aaa = int.Parse(productRow[0]["inventory"].ToString()) - int.Parse(lsbQuo.Items[i].ToString());
                    command.Parameters.AddWithValue("@inventory", int.Parse(productRow[0]["inventory"].ToString()) - int.Parse(lsbQuo.Items[i].ToString()));
                    command.Parameters.AddWithValue("@pid", int.Parse(splitArr[0]));
                    int status = command.ExecuteNonQuery();

                    DateTime dt = DateTime.Now; // 取得現在時間
                    String datetime = dt.ToString(); // 轉成字串

                    conn.Close();
                    // 新增訂單資料
                    DataRow cusproRow = ds.Tables["cuspro"].NewRow();
                    cusproRow["cid"] = int.Parse(cboCustomer.SelectedValue.ToString());
                    cusproRow["pid"] = splitArr[0];
                    cusproRow["date"] = datetime;
                    cusproRow["quty"] = lsbQuo.Items[i];
                    cusproRow["subPri"] = int.Parse(lsbQuo.Items[i].ToString()) * int.Parse(splitArr[2]);
                    cusproRow["discount"] = discount;
                    cusproRow["totalPrice"] = double.Parse(cusproRow["subPri"].ToString()) * discount;
                    ds.Tables["cuspro"].Rows.Add(cusproRow);
                    new MySqlCommandBuilder(adaCusPro);
                    adaCusPro.Update(ds.Tables["cuspro"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }
        
    }
}

