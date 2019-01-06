namespace IceSystem
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpID = new System.Windows.Forms.TextBox();
            this.txtpName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtSafeInventory = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(112, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(91, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(97, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(68, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Safe inventory:";
            // 
            // txtpID
            // 
            this.txtpID.Location = new System.Drawing.Point(155, 41);
            this.txtpID.Name = "txtpID";
            this.txtpID.ReadOnly = true;
            this.txtpID.Size = new System.Drawing.Size(121, 25);
            this.txtpID.TabIndex = 5;
            // 
            // txtpName
            // 
            this.txtpName.Location = new System.Drawing.Point(155, 77);
            this.txtpName.Name = "txtpName";
            this.txtpName.Size = new System.Drawing.Size(121, 25);
            this.txtpName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 118);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(155, 154);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(121, 25);
            this.txtInventory.TabIndex = 8;
            // 
            // txtSafeInventory
            // 
            this.txtSafeInventory.Location = new System.Drawing.Point(155, 193);
            this.txtSafeInventory.Name = "txtSafeInventory";
            this.txtSafeInventory.Size = new System.Drawing.Size(121, 25);
            this.txtSafeInventory.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(243, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrev.Location = new System.Drawing.Point(25, 250);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 35);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "上一筆";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(136, 250);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "下一筆";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(242, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 35);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(135, 308);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 35);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "確認修改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(316, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetail.Location = new System.Drawing.Point(24, 308);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 35);
            this.btnDetail.TabIndex = 16;
            this.btnDetail.Text = "商品明細";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 380);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSafeInventory);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtpName);
            this.Controls.Add(this.txtpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpID;
        private System.Windows.Forms.TextBox txtpName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtSafeInventory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetail;
    }
}