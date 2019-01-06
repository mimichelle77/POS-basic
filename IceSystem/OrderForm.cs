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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        // 連線資訊
        static string connStr = "server=localhost;port=3306;user=root;password=;database=IceSystem;Charset=utf8";
        DataSet ds = new DataSet(); // 宣告資料集
        MySqlDataAdapter myAdapter; // 宣告資料適配器

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.ConnectionString = connStr; // 配置連接（configured）
                                                     // 實體化一個MySqlDataAdapter
                using (myAdapter = new MySqlDataAdapter("SELECT * FROM orderview;", conn))
                    {
                        ds.Clear(); 
                        myAdapter.Fill(ds); // 將dataAdapter中的資料來源填入dataset中
                        dataGridView1.DataSource = ds.Tables[0]; // 將dataset中的第一張資料表填入dataGridView
                    }
                }
                dtPicker.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // 在VS"輸出"偵錯區段印出錯誤訊息
            }
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)//選擇日期
        {
            // 設定 dtp 日期格式
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "yyyy-MM-dd";
            refreshDataGV();
        }

        private void cboEnableDate_CheckedChanged(object sender, EventArgs e)//日期勾選
        {
            refreshDataGV();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)//搜尋文字改變
        {
            refreshDataGV();
        }

        private void refreshDataGV()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string commStr = "";
                if (cboEnableDate.Checked)
                    commStr = "SELECT * FROM `orderview` WHERE `date` LIKE '" + dtPicker.Text + "%' AND `cname` LIKE '" + txtCustomer.Text + "%';";
                else commStr = "SELECT * FROM `orderview` WHERE `cname` LIKE '" + txtCustomer.Text + "%';";
                using (myAdapter = new MySqlDataAdapter(commStr, conn))
                {
                    ds.Clear(); 
                    myAdapter.Fill(ds); // 將dataAdapter中的資料來源填入dataset中
                    dataGridView1.DataSource = ds.Tables[0]; // 將dataset中的第一張資料表填入dataGridView
                }
            }
        }
    }
}
