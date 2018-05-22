namespace TestForm.UI
{
    partial class FmProduct
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
            this.lblAvailiblity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tbAvailiblity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.tbCategoryId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAvailiblity
            // 
            this.lblAvailiblity.AutoSize = true;
            this.lblAvailiblity.Location = new System.Drawing.Point(12, 189);
            this.lblAvailiblity.Name = "lblAvailiblity";
            this.lblAvailiblity.Size = new System.Drawing.Size(66, 17);
            this.lblAvailiblity.TabIndex = 39;
            this.lblAvailiblity.Text = "Наличие";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 17);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "Цена";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(12, 99);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(74, 17);
            this.lblAbout.TabIndex = 37;
            this.lblAbout.Text = "Описание";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(12, 54);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(122, 17);
            this.lblCategoryId.TabIndex = 36;
            this.lblCategoryId.Text = "Номер категории";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 9);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(48, 17);
            this.lblProduct.TabIndex = 35;
            this.lblProduct.Text = "Товар";
            // 
            // tbAvailiblity
            // 
            this.tbAvailiblity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAvailiblity.Location = new System.Drawing.Point(12, 209);
            this.tbAvailiblity.Name = "tbAvailiblity";
            this.tbAvailiblity.Size = new System.Drawing.Size(294, 22);
            this.tbAvailiblity.TabIndex = 34;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Location = new System.Drawing.Point(12, 164);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(294, 22);
            this.tbPrice.TabIndex = 33;
            // 
            // tbAbout
            // 
            this.tbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAbout.Location = new System.Drawing.Point(12, 119);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(294, 22);
            this.tbAbout.TabIndex = 32;
            // 
            // tbCategoryId
            // 
            this.tbCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategoryId.Location = new System.Drawing.Point(12, 74);
            this.tbCategoryId.Name = "tbCategoryId";
            this.tbCategoryId.Size = new System.Drawing.Size(294, 22);
            this.tbCategoryId.TabIndex = 31;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(12, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(294, 22);
            this.tbName.TabIndex = 30;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(12, 237);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(100, 23);
            this.btnProduct.TabIndex = 40;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // FmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 268);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblAvailiblity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.tbAvailiblity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.tbCategoryId);
            this.Controls.Add(this.tbName);
            this.Name = "FmProduct";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FmEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailiblity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbAvailiblity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.TextBox tbCategoryId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnProduct;
    }
}