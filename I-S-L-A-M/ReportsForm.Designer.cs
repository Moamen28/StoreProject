﻿
namespace I_S_L_A_M
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AllProducts = new I_S_L_A_M.GradientButton();
            this.SoldProducts = new I_S_L_A_M.GradientButton();
            this.ExpiredProducts = new I_S_L_A_M.GradientButton();
            this.CustomerBills = new I_S_L_A_M.GradientButton();
            this.SupplierBills = new I_S_L_A_M.GradientButton();
            this.VendorBills = new I_S_L_A_M.GradientButton();
            this.ExpireSoon = new I_S_L_A_M.GradientButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 402);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1437, 597);
            this.dataGridView1.TabIndex = 0;
            // 
            // AllProducts
            // 
            this.AllProducts.Angle = 63F;
            this.AllProducts.BorderRadius = 20;
            this.AllProducts.Color0 = System.Drawing.Color.Firebrick;
            this.AllProducts.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.AllProducts.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.AllProducts.ForeColor = System.Drawing.Color.White;
            this.AllProducts.Location = new System.Drawing.Point(183, 195);
            this.AllProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(300, 68);
            this.AllProducts.TabIndex = 45;
            this.AllProducts.Texty = "All Products";
            this.AllProducts.Click += new System.EventHandler(this.AllProds);
            // 
            // SoldProducts
            // 
            this.SoldProducts.Angle = 275F;
            this.SoldProducts.BorderRadius = 20;
            this.SoldProducts.Color0 = System.Drawing.Color.Gold;
            this.SoldProducts.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SoldProducts.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SoldProducts.ForeColor = System.Drawing.Color.White;
            this.SoldProducts.Location = new System.Drawing.Point(512, 195);
            this.SoldProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoldProducts.Name = "SoldProducts";
            this.SoldProducts.Size = new System.Drawing.Size(297, 68);
            this.SoldProducts.TabIndex = 46;
            this.SoldProducts.Texty = "Sold Products";
            this.SoldProducts.Click += new System.EventHandler(this.SoldProds);
            // 
            // ExpiredProducts
            // 
            this.ExpiredProducts.Angle = 268F;
            this.ExpiredProducts.BorderRadius = 20;
            this.ExpiredProducts.Color0 = System.Drawing.Color.Fuchsia;
            this.ExpiredProducts.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ExpiredProducts.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExpiredProducts.ForeColor = System.Drawing.Color.White;
            this.ExpiredProducts.Location = new System.Drawing.Point(840, 195);
            this.ExpiredProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpiredProducts.Name = "ExpiredProducts";
            this.ExpiredProducts.Size = new System.Drawing.Size(298, 68);
            this.ExpiredProducts.TabIndex = 47;
            this.ExpiredProducts.Texty = "Expired Products";
            this.ExpiredProducts.Click += new System.EventHandler(this.ExpiredProds);
            // 
            // CustomerBills
            // 
            this.CustomerBills.Angle = 250F;
            this.CustomerBills.BorderRadius = 20;
            this.CustomerBills.Color0 = System.Drawing.SystemColors.GradientActiveCaption;
            this.CustomerBills.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.CustomerBills.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.CustomerBills.ForeColor = System.Drawing.Color.White;
            this.CustomerBills.Location = new System.Drawing.Point(1170, 195);
            this.CustomerBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerBills.Name = "CustomerBills";
            this.CustomerBills.Size = new System.Drawing.Size(297, 68);
            this.CustomerBills.TabIndex = 48;
            this.CustomerBills.Texty = "Customers Bills";
            this.CustomerBills.Click += new System.EventHandler(this.CustBills2);
            // 
            // SupplierBills
            // 
            this.SupplierBills.Angle = 215F;
            this.SupplierBills.BorderRadius = 20;
            this.SupplierBills.Color0 = System.Drawing.SystemColors.Info;
            this.SupplierBills.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SupplierBills.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SupplierBills.ForeColor = System.Drawing.Color.White;
            this.SupplierBills.Location = new System.Drawing.Point(328, 288);
            this.SupplierBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplierBills.Name = "SupplierBills";
            this.SupplierBills.Size = new System.Drawing.Size(306, 68);
            this.SupplierBills.TabIndex = 49;
            this.SupplierBills.Texty = "Suplier Bills";
            this.SupplierBills.Click += new System.EventHandler(this.SuppBills2);
            // 
            // VendorBills
            // 
            this.VendorBills.Angle = 22F;
            this.VendorBills.BorderRadius = 20;
            this.VendorBills.Color0 = System.Drawing.SystemColors.Highlight;
            this.VendorBills.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.VendorBills.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.VendorBills.ForeColor = System.Drawing.Color.White;
            this.VendorBills.Location = new System.Drawing.Point(669, 288);
            this.VendorBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VendorBills.Name = "VendorBills";
            this.VendorBills.Size = new System.Drawing.Size(300, 68);
            this.VendorBills.TabIndex = 50;
            this.VendorBills.Texty = "Vendor Bills";
            this.VendorBills.Click += new System.EventHandler(this.VendorBills_Click);
            // 
            // ExpireSoon
            // 
            this.ExpireSoon.Angle = 211F;
            this.ExpireSoon.BorderRadius = 20;
            this.ExpireSoon.Color0 = System.Drawing.Color.LightCoral;
            this.ExpireSoon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ExpireSoon.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExpireSoon.ForeColor = System.Drawing.Color.White;
            this.ExpireSoon.Location = new System.Drawing.Point(1010, 288);
            this.ExpireSoon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpireSoon.Name = "ExpireSoon";
            this.ExpireSoon.Size = new System.Drawing.Size(300, 68);
            this.ExpireSoon.TabIndex = 51;
            this.ExpireSoon.Texty = "Expire Soon";
            this.ExpireSoon.Click += new System.EventHandler(this.ExpireSoon_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(651, 92);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F);
            this.label1.Location = new System.Drawing.Point(613, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Date FIlter";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1611, 1017);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ExpireSoon);
            this.Controls.Add(this.VendorBills);
            this.Controls.Add(this.SupplierBills);
            this.Controls.Add(this.CustomerBills);
            this.Controls.Add(this.ExpiredProducts);
            this.Controls.Add(this.SoldProducts);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradientButton AllProducts;
        private GradientButton SoldProducts;
        private GradientButton ExpiredProducts;
        private GradientButton CustomerBills;
        private GradientButton SupplierBills;
        private GradientButton VendorBills;
        private GradientButton ExpireSoon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}