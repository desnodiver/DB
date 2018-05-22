namespace TestForm.UI
{
    partial class FmCategory
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
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.tbParentId = new System.Windows.Forms.TextBox();
            this.lbParentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCategory
            // 
            this.tbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategory.Location = new System.Drawing.Point(12, 29);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(316, 22);
            this.tbCategory.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(9, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(77, 17);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Категория";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(12, 102);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(100, 23);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // tbParentId
            // 
            this.tbParentId.Location = new System.Drawing.Point(12, 74);
            this.tbParentId.Name = "tbParentId";
            this.tbParentId.Size = new System.Drawing.Size(316, 22);
            this.tbParentId.TabIndex = 3;
            // 
            // lbParentId
            // 
            this.lbParentId.AutoSize = true;
            this.lbParentId.Location = new System.Drawing.Point(12, 54);
            this.lbParentId.Name = "lbParentId";
            this.lbParentId.Size = new System.Drawing.Size(146, 17);
            this.lbParentId.TabIndex = 4;
            this.lbParentId.Text = "Номер подкатегории";
            // 
            // FmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 137);
            this.Controls.Add(this.lbParentId);
            this.Controls.Add(this.tbParentId);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.tbCategory);
            this.Name = "FmCategory";
            this.Text = "Категории";
            this.Load += new System.EventHandler(this.FmEditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.TextBox tbParentId;
        private System.Windows.Forms.Label lbParentId;
    }
}