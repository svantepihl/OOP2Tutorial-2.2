namespace OOP2Tutorial_2_part2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.ProductList = new System.Windows.Forms.ListBox();
            this.ProductNameField = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceField = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(34, 26);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(185, 212);
            this.ProductList.TabIndex = 0;
            // 
            // ProductNameField
            // 
            this.ProductNameField.Location = new System.Drawing.Point(34, 273);
            this.ProductNameField.Name = "ProductNameField";
            this.ProductNameField.Size = new System.Drawing.Size(81, 20);
            this.ProductNameField.TabIndex = 1;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Location = new System.Drawing.Point(34, 259);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(100, 11);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Name:";
            // 
            // ProductPriceField
            // 
            this.ProductPriceField.Location = new System.Drawing.Point(138, 273);
            this.ProductPriceField.Name = "ProductPriceField";
            this.ProductPriceField.Size = new System.Drawing.Size(81, 20);
            this.ProductPriceField.TabIndex = 3;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.Location = new System.Drawing.Point(138, 258);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(100, 12);
            this.ProductPriceLabel.TabIndex = 4;
            this.ProductPriceLabel.Text = "Price:";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(34, 318);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(138, 318);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(81, 23);
            this.UpdateProduct.TabIndex = 6;
            this.UpdateProduct.Text = "Update";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(87, 347);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(75, 23);
            this.ProductDelete.TabIndex = 7;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 408);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductPriceField);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductNameField);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.Text = "Tutorial 2 part 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ProductDelete;

        private System.Windows.Forms.TextBox ProductPriceField;

        private System.Windows.Forms.TextBox ProductNameField;

        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.Button AddProduct;
        
        private System.Windows.Forms.Label ProductPriceLabel;

        private System.Windows.Forms.Label ProductNameLabel;

        private System.Windows.Forms.ListBox ProductList;

        #endregion
    }
}