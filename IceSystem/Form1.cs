using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProd_Click(object sender, EventArgs e)//庫存管理
        {
            Form prodF = new ProductForm();
            prodF.Show();
        }

        private void btnCus_Click(object sender, EventArgs e)//顧客管理
        {
            Form cusF = new CustomerForm();
            cusF.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)//應收管理
        {
            Form orderF = new OrderForm();
            orderF.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)//交易管理
        {
            Form posF = new POSForm();
            posF.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)//離開
        {
            Application.Exit();
        }
       
    }
}
