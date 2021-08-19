namespace FoodLoversTest
{
    partial class ProductPage
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
            this.pnlBranch = new System.Windows.Forms.Panel();
            this.btnExportProductToXml = new System.Windows.Forms.Button();
            this.btnExporProductToCSV = new System.Windows.Forms.Button();
            this.btnExportProductToJson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlViewData = new System.Windows.Forms.Panel();
            this.btnViewBranches = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBranchProducts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportBranchProducts = new System.Windows.Forms.Button();
            this.cbWeightedItem = new System.Windows.Forms.CheckBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnClearBranch = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblWeightedItem = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.pnlFileUpload = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnImportProduct = new System.Windows.Forms.Button();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBranchesList = new System.Windows.Forms.Button();
            this.pnlBranch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlViewData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFileUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBranch
            // 
            this.pnlBranch.BackColor = System.Drawing.Color.Cyan;
            this.pnlBranch.Controls.Add(this.btnExportProductToXml);
            this.pnlBranch.Controls.Add(this.btnExporProductToCSV);
            this.pnlBranch.Controls.Add(this.btnExportProductToJson);
            this.pnlBranch.Controls.Add(this.panel1);
            this.pnlBranch.Controls.Add(this.pnlFileUpload);
            this.pnlBranch.Controls.Add(this.gvProduct);
            this.pnlBranch.Location = new System.Drawing.Point(24, 35);
            this.pnlBranch.Name = "pnlBranch";
            this.pnlBranch.Size = new System.Drawing.Size(811, 428);
            this.pnlBranch.TabIndex = 5;
            // 
            // btnExportProductToXml
            // 
            this.btnExportProductToXml.Location = new System.Drawing.Point(707, 13);
            this.btnExportProductToXml.Name = "btnExportProductToXml";
            this.btnExportProductToXml.Size = new System.Drawing.Size(83, 23);
            this.btnExportProductToXml.TabIndex = 19;
            this.btnExportProductToXml.Text = "Export to XML";
            this.btnExportProductToXml.UseVisualStyleBackColor = true;
            this.btnExportProductToXml.Click += new System.EventHandler(this.btnExportProductToXml_Click);
            // 
            // btnExporProductToCSV
            // 
            this.btnExporProductToCSV.Location = new System.Drawing.Point(538, 13);
            this.btnExporProductToCSV.Name = "btnExporProductToCSV";
            this.btnExporProductToCSV.Size = new System.Drawing.Size(81, 23);
            this.btnExporProductToCSV.TabIndex = 18;
            this.btnExporProductToCSV.Text = "Export to CSV";
            this.btnExporProductToCSV.UseVisualStyleBackColor = true;
            this.btnExporProductToCSV.Click += new System.EventHandler(this.btnExporProductToCSV_Click);
            // 
            // btnExportProductToJson
            // 
            this.btnExportProductToJson.Location = new System.Drawing.Point(361, 13);
            this.btnExportProductToJson.Name = "btnExportProductToJson";
            this.btnExportProductToJson.Size = new System.Drawing.Size(93, 23);
            this.btnExportProductToJson.TabIndex = 17;
            this.btnExportProductToJson.Text = "Export to JSON";
            this.btnExportProductToJson.UseVisualStyleBackColor = true;
            this.btnExportProductToJson.Click += new System.EventHandler(this.btnExportProductToJson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.pnlViewData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbWeightedItem);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.btnClearBranch);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblBranchName);
            this.panel1.Controls.Add(this.lblWeightedItem);
            this.panel1.Controls.Add(this.lblSellingPrice);
            this.panel1.Controls.Add(this.txtSellingPrice);
            this.panel1.Location = new System.Drawing.Point(22, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 325);
            this.panel1.TabIndex = 13;
            // 
            // pnlViewData
            // 
            this.pnlViewData.BackColor = System.Drawing.Color.Crimson;
            this.pnlViewData.Controls.Add(this.btnViewBranches);
            this.pnlViewData.Controls.Add(this.label4);
            this.pnlViewData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlViewData.Location = new System.Drawing.Point(12, 226);
            this.pnlViewData.Name = "pnlViewData";
            this.pnlViewData.Size = new System.Drawing.Size(281, 44);
            this.pnlViewData.TabIndex = 17;
            this.pnlViewData.Visible = false;
            // 
            // btnViewBranches
            // 
            this.btnViewBranches.Location = new System.Drawing.Point(220, 13);
            this.btnViewBranches.Name = "btnViewBranches";
            this.btnViewBranches.Size = new System.Drawing.Size(53, 23);
            this.btnViewBranches.TabIndex = 1;
            this.btnViewBranches.Text = "View";
            this.btnViewBranches.UseVisualStyleBackColor = true;
            this.btnViewBranches.Click += new System.EventHandler(this.btnViewBranches_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select to view branches selling product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.lblBranchProducts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnImportBranchProducts);
            this.panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 70);
            this.panel2.TabIndex = 16;
            // 
            // lblBranchProducts
            // 
            this.lblBranchProducts.AutoSize = true;
            this.lblBranchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchProducts.ForeColor = System.Drawing.Color.Coral;
            this.lblBranchProducts.Location = new System.Drawing.Point(21, 12);
            this.lblBranchProducts.Name = "lblBranchProducts";
            this.lblBranchProducts.Size = new System.Drawing.Size(272, 13);
            this.lblBranchProducts.TabIndex = 2;
            this.lblBranchProducts.Text = "Browse to the BRANCH PRODUCTS file to import to DB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "File : ";
            // 
            // btnImportBranchProducts
            // 
            this.btnImportBranchProducts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnImportBranchProducts.Location = new System.Drawing.Point(22, 28);
            this.btnImportBranchProducts.Name = "btnImportBranchProducts";
            this.btnImportBranchProducts.Size = new System.Drawing.Size(138, 23);
            this.btnImportBranchProducts.TabIndex = 0;
            this.btnImportBranchProducts.Text = "Import Branch Products";
            this.btnImportBranchProducts.UseVisualStyleBackColor = true;
            this.btnImportBranchProducts.Click += new System.EventHandler(this.btnImportBranchProducts_Click);
            // 
            // cbWeightedItem
            // 
            this.cbWeightedItem.AutoSize = true;
            this.cbWeightedItem.Location = new System.Drawing.Point(105, 206);
            this.cbWeightedItem.Name = "cbWeightedItem";
            this.cbWeightedItem.Size = new System.Drawing.Size(15, 14);
            this.cbWeightedItem.TabIndex = 15;
            this.cbWeightedItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Location = new System.Drawing.Point(105, 285);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteProduct.TabIndex = 14;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(22, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(105, 96);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(151, 20);
            this.txtProductID.TabIndex = 11;
            // 
            // btnClearBranch
            // 
            this.btnClearBranch.Location = new System.Drawing.Point(195, 285);
            this.btnClearBranch.Name = "btnClearBranch";
            this.btnClearBranch.Size = new System.Drawing.Size(61, 23);
            this.btnClearBranch.TabIndex = 3;
            this.btnClearBranch.Text = "Clear";
            this.btnClearBranch.UseVisualStyleBackColor = true;
            this.btnClearBranch.Click += new System.EventHandler(this.btnClearBranch_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(21, 96);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 10;
            this.lblProductID.Text = "ID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(105, 131);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(151, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(21, 131);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(35, 13);
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "Name";
            // 
            // lblWeightedItem
            // 
            this.lblWeightedItem.AutoSize = true;
            this.lblWeightedItem.Location = new System.Drawing.Point(21, 207);
            this.lblWeightedItem.Name = "lblWeightedItem";
            this.lblWeightedItem.Size = new System.Drawing.Size(76, 13);
            this.lblWeightedItem.TabIndex = 8;
            this.lblWeightedItem.Text = "Weighted Item";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(21, 166);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(65, 13);
            this.lblSellingPrice.TabIndex = 6;
            this.lblSellingPrice.Text = "Selling Price";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(105, 166);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(151, 20);
            this.txtSellingPrice.TabIndex = 7;
            // 
            // pnlFileUpload
            // 
            this.pnlFileUpload.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFileUpload.Controls.Add(this.label2);
            this.pnlFileUpload.Controls.Add(this.lblFileName);
            this.pnlFileUpload.Controls.Add(this.btnImportProduct);
            this.pnlFileUpload.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFileUpload.Location = new System.Drawing.Point(22, 25);
            this.pnlFileUpload.Name = "pnlFileUpload";
            this.pnlFileUpload.Size = new System.Drawing.Size(306, 66);
            this.pnlFileUpload.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse to the PRODUCT file you wish to import to DB";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(141, 33);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(32, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File : ";
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnImportProduct.Location = new System.Drawing.Point(22, 28);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(97, 23);
            this.btnImportProduct.TabIndex = 0;
            this.btnImportProduct.Text = "Import Products";
            this.btnImportProduct.UseVisualStyleBackColor = true;
            this.btnImportProduct.Click += new System.EventHandler(this.btnImportProduct_Click);
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(361, 42);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProduct.Size = new System.Drawing.Size(429, 380);
            this.gvProduct.TabIndex = 0;
            this.gvProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProduct_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please select to view";
            // 
            // btnBranchesList
            // 
            this.btnBranchesList.Location = new System.Drawing.Point(181, 6);
            this.btnBranchesList.Name = "btnBranchesList";
            this.btnBranchesList.Size = new System.Drawing.Size(95, 23);
            this.btnBranchesList.TabIndex = 6;
            this.btnBranchesList.Text = "Branches";
            this.btnBranchesList.UseVisualStyleBackColor = true;
            this.btnBranchesList.Click += new System.EventHandler(this.btnBranchesList_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBranchesList);
            this.Controls.Add(this.pnlBranch);
            this.Name = "ProductPage";
            this.Text = "ProductPage";
            this.Load += new System.EventHandler(this.Product_Load);
            this.pnlBranch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlViewData.ResumeLayout(false);
            this.pnlViewData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFileUpload.ResumeLayout(false);
            this.pnlFileUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBranch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBranchProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImportBranchProducts;
        private System.Windows.Forms.CheckBox cbWeightedItem;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnClearBranch;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblWeightedItem;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Panel pnlFileUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnImportProduct;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBranchesList;
        private System.Windows.Forms.Button btnExportProductToXml;
        private System.Windows.Forms.Button btnExporProductToCSV;
        private System.Windows.Forms.Button btnExportProductToJson;
        private System.Windows.Forms.Panel pnlViewData;
        private System.Windows.Forms.Button btnViewBranches;
        private System.Windows.Forms.Label label4;
    }
}