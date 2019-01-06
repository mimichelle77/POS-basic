namespace IceSystem
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboEnableDate = new System.Windows.Forms.CheckBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "搜尋:";
            // 
            // cboEnableDate
            // 
            this.cboEnableDate.AutoSize = true;
            this.cboEnableDate.Location = new System.Drawing.Point(339, 21);
            this.cboEnableDate.Name = "cboEnableDate";
            this.cboEnableDate.Size = new System.Drawing.Size(18, 17);
            this.cboEnableDate.TabIndex = 4;
            this.cboEnableDate.UseVisualStyleBackColor = true;
            this.cboEnableDate.CheckedChanged += new System.EventHandler(this.cboEnableDate_CheckedChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(358, 18);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(153, 25);
            this.dtPicker.TabIndex = 5;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(492, 260);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCustomer.Location = new System.Drawing.Point(198, 16);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(129, 28);
            this.txtCustomer.TabIndex = 7;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 332);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.cboEnableDate);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboEnableDate;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}