namespace IceSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "★ 冰　品　系　統 ★";
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProd.ForeColor = System.Drawing.Color.Blue;
            this.btnProd.Location = new System.Drawing.Point(82, 87);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(205, 36);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "冰品庫存管理系統";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCus.ForeColor = System.Drawing.Color.Blue;
            this.btnCus.Location = new System.Drawing.Point(82, 142);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(205, 36);
            this.btnCus.TabIndex = 2;
            this.btnCus.Text = "客戶管理系統";
            this.btnCus.UseVisualStyleBackColor = false;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.Color.Blue;
            this.btnOrder.Location = new System.Drawing.Point(82, 198);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(205, 36);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "應收帳款管理系統";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPOS.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPOS.ForeColor = System.Drawing.Color.Blue;
            this.btnPOS.Location = new System.Drawing.Point(82, 254);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(205, 36);
            this.btnPOS.TabIndex = 4;
            this.btnPOS.Text = "冰品交易管理系統";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(82, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "冰品系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnExit;
    }
}

