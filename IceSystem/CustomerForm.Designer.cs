namespace IceSystem
{
    partial class CustomerForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.txtcID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(315, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 35);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(134, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 35);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "確認修改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(244, 303);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 35);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(134, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 35);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "下一筆";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrev.Location = new System.Drawing.Point(23, 244);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 35);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "上一筆";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(250, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "新增資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(152, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 25);
            this.txtPhone.TabIndex = 24;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(152, 107);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(121, 25);
            this.txtAddr.TabIndex = 23;
            // 
            // txtcName
            // 
            this.txtcName.Location = new System.Drawing.Point(152, 66);
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(121, 25);
            this.txtcName.TabIndex = 22;
            // 
            // txtcID
            // 
            this.txtcID.Location = new System.Drawing.Point(152, 30);
            this.txtcID.Name = "txtcID";
            this.txtcID.ReadOnly = true;
            this.txtcID.Size = new System.Drawing.Size(121, 25);
            this.txtcID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(86, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(74, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(88, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(109, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetail.Location = new System.Drawing.Point(23, 303);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 35);
            this.btnDetail.TabIndex = 32;
            this.btnDetail.Text = "客戶明細";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 369);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtcName);
            this.Controls.Add(this.txtcID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.TextBox txtcID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
    }
}