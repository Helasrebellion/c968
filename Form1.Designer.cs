namespace C968
{
    partial class Form1
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
            this.header = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.searchPartsBox = new System.Windows.Forms.TextBox();
            this.productsSearchBox = new System.Windows.Forms.TextBox();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.listViewParts = new System.Windows.Forms.ListView();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.deletePartsBtn = new System.Windows.Forms.Button();
            this.modifyPartsBtn = new System.Windows.Forms.Button();
            this.addPartsBtn = new System.Windows.Forms.Button();
            this.addProductsBtn = new System.Windows.Forms.Button();
            this.modifyProductsBtn = new System.Windows.Forms.Button();
            this.deleteProductsBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 38);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(498, 39);
            this.header.TabIndex = 0;
            this.header.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(14, 131);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(99, 39);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(768, 131);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(155, 39);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Products";
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click);
            // 
            // searchPartsBox
            // 
            this.searchPartsBox.Location = new System.Drawing.Point(503, 141);
            this.searchPartsBox.MaximumSize = new System.Drawing.Size(200, 4);
            this.searchPartsBox.Name = "searchPartsBox";
            this.searchPartsBox.Size = new System.Drawing.Size(200, 29);
            this.searchPartsBox.TabIndex = 4;
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Location = new System.Drawing.Point(1229, 140);
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(230, 29);
            this.productsSearchBox.TabIndex = 5;
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.Location = new System.Drawing.Point(368, 139);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(89, 44);
            this.searchPartsBtn.TabIndex = 6;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = true;
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.Location = new System.Drawing.Point(1124, 137);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(89, 46);
            this.searchProductsBtn.TabIndex = 7;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = true;
            // 
            // listViewParts
            // 
            this.listViewParts.BackColor = System.Drawing.SystemColors.GrayText;
            this.listViewParts.HideSelection = false;
            this.listViewParts.Location = new System.Drawing.Point(21, 189);
            this.listViewParts.Name = "listViewParts";
            this.listViewParts.Size = new System.Drawing.Size(682, 243);
            this.listViewParts.TabIndex = 8;
            this.listViewParts.UseCompatibleStateImageBehavior = false;
            this.listViewParts.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.SystemColors.GrayText;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(775, 189);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(682, 243);
            this.listViewProducts.TabIndex = 9;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // deletePartsBtn
            // 
            this.deletePartsBtn.Location = new System.Drawing.Point(614, 451);
            this.deletePartsBtn.Name = "deletePartsBtn";
            this.deletePartsBtn.Size = new System.Drawing.Size(89, 46);
            this.deletePartsBtn.TabIndex = 10;
            this.deletePartsBtn.Text = "Delete";
            this.deletePartsBtn.UseVisualStyleBackColor = true;
            // 
            // modifyPartsBtn
            // 
            this.modifyPartsBtn.Location = new System.Drawing.Point(484, 451);
            this.modifyPartsBtn.Name = "modifyPartsBtn";
            this.modifyPartsBtn.Size = new System.Drawing.Size(89, 46);
            this.modifyPartsBtn.TabIndex = 11;
            this.modifyPartsBtn.Text = "Modify";
            this.modifyPartsBtn.UseVisualStyleBackColor = true;
            // 
            // addPartsBtn
            // 
            this.addPartsBtn.Location = new System.Drawing.Point(368, 451);
            this.addPartsBtn.Name = "addPartsBtn";
            this.addPartsBtn.Size = new System.Drawing.Size(89, 46);
            this.addPartsBtn.TabIndex = 12;
            this.addPartsBtn.Text = "Add";
            this.addPartsBtn.UseVisualStyleBackColor = true;
            // 
            // addProductsBtn
            // 
            this.addProductsBtn.Location = new System.Drawing.Point(1124, 451);
            this.addProductsBtn.Name = "addProductsBtn";
            this.addProductsBtn.Size = new System.Drawing.Size(89, 46);
            this.addProductsBtn.TabIndex = 15;
            this.addProductsBtn.Text = "Add";
            this.addProductsBtn.UseVisualStyleBackColor = true;
            // 
            // modifyProductsBtn
            // 
            this.modifyProductsBtn.Location = new System.Drawing.Point(1240, 451);
            this.modifyProductsBtn.Name = "modifyProductsBtn";
            this.modifyProductsBtn.Size = new System.Drawing.Size(89, 46);
            this.modifyProductsBtn.TabIndex = 14;
            this.modifyProductsBtn.Text = "Modify";
            this.modifyProductsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteProductsBtn
            // 
            this.deleteProductsBtn.Location = new System.Drawing.Point(1370, 451);
            this.deleteProductsBtn.Name = "deleteProductsBtn";
            this.deleteProductsBtn.Size = new System.Drawing.Size(89, 46);
            this.deleteProductsBtn.TabIndex = 13;
            this.deleteProductsBtn.Text = "Delete";
            this.deleteProductsBtn.UseVisualStyleBackColor = true;
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.Location = new System.Drawing.Point(1370, 544);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(89, 42);
            this.exitAppBtn.TabIndex = 16;
            this.exitAppBtn.Text = "Exit";
            this.exitAppBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1479, 598);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.addProductsBtn);
            this.Controls.Add(this.modifyProductsBtn);
            this.Controls.Add(this.deleteProductsBtn);
            this.Controls.Add(this.addPartsBtn);
            this.Controls.Add(this.modifyPartsBtn);
            this.Controls.Add(this.deletePartsBtn);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.listViewParts);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.productsSearchBox);
            this.Controls.Add(this.searchPartsBox);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.TextBox searchPartsBox;
        private System.Windows.Forms.TextBox productsSearchBox;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.Button searchProductsBtn;
        private System.Windows.Forms.ListView listViewParts;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button deletePartsBtn;
        private System.Windows.Forms.Button modifyPartsBtn;
        private System.Windows.Forms.Button addPartsBtn;
        private System.Windows.Forms.Button addProductsBtn;
        private System.Windows.Forms.Button modifyProductsBtn;
        private System.Windows.Forms.Button deleteProductsBtn;
        private System.Windows.Forms.Button exitAppBtn;
    }
}

