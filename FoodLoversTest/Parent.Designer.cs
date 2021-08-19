namespace FoodLoversTest
{
    partial class Parent
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
            this.btnProductsList = new System.Windows.Forms.Button();
            this.gvBranch = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearBranch = new System.Windows.Forms.Button();
            this.pnlBranch = new System.Windows.Forms.Panel();
            this.btnExportBranchToXml = new System.Windows.Forms.Button();
            this.btnExportBranchToCSV = new System.Windows.Forms.Button();
            this.btnExportBranchToJson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlViewData = new System.Windows.Forms.Panel();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtBranchDate = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblBranchDate = new System.Windows.Forms.Label();
            this.lblBranchTelNumber = new System.Windows.Forms.Label();
            this.txtBranchPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlFileUpload = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBranch)).BeginInit();
            this.pnlBranch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlViewData.SuspendLayout();
            this.pnlFileUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductsList
            // 
            this.btnProductsList.Location = new System.Drawing.Point(210, 28);
            this.btnProductsList.Name = "btnProductsList";
            this.btnProductsList.Size = new System.Drawing.Size(95, 23);
            this.btnProductsList.TabIndex = 3;
            this.btnProductsList.Text = "Products";
            this.btnProductsList.UseVisualStyleBackColor = true;
            this.btnProductsList.Click += new System.EventHandler(this.btnProductsList_Click);
            // 
            // gvBranch
            // 
            this.gvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBranch.Location = new System.Drawing.Point(379, 42);
            this.gvBranch.Name = "gvBranch";
            this.gvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBranch.Size = new System.Drawing.Size(429, 380);
            this.gvBranch.TabIndex = 0;
            this.gvBranch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvBranch_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(22, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearBranch
            // 
            this.btnClearBranch.Location = new System.Drawing.Point(195, 299);
            this.btnClearBranch.Name = "btnClearBranch";
            this.btnClearBranch.Size = new System.Drawing.Size(61, 23);
            this.btnClearBranch.TabIndex = 3;
            this.btnClearBranch.Text = "Clear";
            this.btnClearBranch.UseVisualStyleBackColor = true;
            this.btnClearBranch.Click += new System.EventHandler(this.btnClearBranch_Click);
            // 
            // pnlBranch
            // 
            this.pnlBranch.BackColor = System.Drawing.Color.Cyan;
            this.pnlBranch.Controls.Add(this.btnExportBranchToXml);
            this.pnlBranch.Controls.Add(this.btnExportBranchToCSV);
            this.pnlBranch.Controls.Add(this.btnExportBranchToJson);
            this.pnlBranch.Controls.Add(this.panel1);
            this.pnlBranch.Controls.Add(this.pnlFileUpload);
            this.pnlBranch.Controls.Add(this.gvBranch);
            this.pnlBranch.Location = new System.Drawing.Point(41, 57);
            this.pnlBranch.Name = "pnlBranch";
            this.pnlBranch.Size = new System.Drawing.Size(811, 428);
            this.pnlBranch.TabIndex = 4;
            // 
            // btnExportBranchToXml
            // 
            this.btnExportBranchToXml.Location = new System.Drawing.Point(725, 13);
            this.btnExportBranchToXml.Name = "btnExportBranchToXml";
            this.btnExportBranchToXml.Size = new System.Drawing.Size(83, 23);
            this.btnExportBranchToXml.TabIndex = 16;
            this.btnExportBranchToXml.Text = "Export to XML";
            this.btnExportBranchToXml.UseVisualStyleBackColor = true;
            this.btnExportBranchToXml.Click += new System.EventHandler(this.btnExportBranchToXml_Click);
            // 
            // btnExportBranchToCSV
            // 
            this.btnExportBranchToCSV.Location = new System.Drawing.Point(559, 13);
            this.btnExportBranchToCSV.Name = "btnExportBranchToCSV";
            this.btnExportBranchToCSV.Size = new System.Drawing.Size(81, 23);
            this.btnExportBranchToCSV.TabIndex = 15;
            this.btnExportBranchToCSV.Text = "Export to CSV";
            this.btnExportBranchToCSV.UseVisualStyleBackColor = true;
            this.btnExportBranchToCSV.Click += new System.EventHandler(this.btnExportBranchToCSV_Click);
            // 
            // btnExportBranchToJson
            // 
            this.btnExportBranchToJson.Location = new System.Drawing.Point(379, 13);
            this.btnExportBranchToJson.Name = "btnExportBranchToJson";
            this.btnExportBranchToJson.Size = new System.Drawing.Size(93, 23);
            this.btnExportBranchToJson.TabIndex = 14;
            this.btnExportBranchToJson.Text = "Export to JSON";
            this.btnExportBranchToJson.UseVisualStyleBackColor = true;
            this.btnExportBranchToJson.Click += new System.EventHandler(this.btnExportBranchToJson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.pnlViewData);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lstProducts);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBranchID);
            this.panel1.Controls.Add(this.btnClearBranch);
            this.panel1.Controls.Add(this.lblBranchID);
            this.panel1.Controls.Add(this.txtBranchName);
            this.panel1.Controls.Add(this.txtBranchDate);
            this.panel1.Controls.Add(this.lblBranchName);
            this.panel1.Controls.Add(this.lblBranchDate);
            this.panel1.Controls.Add(this.lblBranchTelNumber);
            this.panel1.Controls.Add(this.txtBranchPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(22, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 325);
            this.panel1.TabIndex = 13;
            // 
            // pnlViewData
            // 
            this.pnlViewData.BackColor = System.Drawing.Color.Crimson;
            this.pnlViewData.Controls.Add(this.btnViewProduct);
            this.pnlViewData.Controls.Add(this.label3);
            this.pnlViewData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlViewData.Location = new System.Drawing.Point(22, 249);
            this.pnlViewData.Name = "pnlViewData";
            this.pnlViewData.Size = new System.Drawing.Size(281, 44);
            this.pnlViewData.TabIndex = 15;
            this.pnlViewData.Visible = false;
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(220, 13);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(53, 23);
            this.btnViewProduct.TabIndex = 1;
            this.btnViewProduct.Text = "View";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "View available products for this branch";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(105, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(105, 161);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstProducts.Size = new System.Drawing.Size(151, 82);
            this.lstProducts.TabIndex = 13;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(21, 161);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 12;
            this.lblProduct.Text = "Product";
            // 
            // txtBranchID
            // 
            this.txtBranchID.Enabled = false;
            this.txtBranchID.Location = new System.Drawing.Point(105, 19);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(151, 20);
            this.txtBranchID.TabIndex = 11;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(21, 19);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(18, 13);
            this.lblBranchID.TabIndex = 10;
            this.lblBranchID.Text = "ID";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(105, 54);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(151, 20);
            this.txtBranchName.TabIndex = 5;
            // 
            // txtBranchDate
            // 
            this.txtBranchDate.Location = new System.Drawing.Point(105, 127);
            this.txtBranchDate.Name = "txtBranchDate";
            this.txtBranchDate.Size = new System.Drawing.Size(151, 20);
            this.txtBranchDate.TabIndex = 9;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(21, 54);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(35, 13);
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "Name";
            // 
            // lblBranchDate
            // 
            this.lblBranchDate.AutoSize = true;
            this.lblBranchDate.Location = new System.Drawing.Point(21, 130);
            this.lblBranchDate.Name = "lblBranchDate";
            this.lblBranchDate.Size = new System.Drawing.Size(59, 13);
            this.lblBranchDate.TabIndex = 8;
            this.lblBranchDate.Text = "Open Date";
            // 
            // lblBranchTelNumber
            // 
            this.lblBranchTelNumber.AutoSize = true;
            this.lblBranchTelNumber.Location = new System.Drawing.Point(21, 89);
            this.lblBranchTelNumber.Name = "lblBranchTelNumber";
            this.lblBranchTelNumber.Size = new System.Drawing.Size(78, 13);
            this.lblBranchTelNumber.TabIndex = 6;
            this.lblBranchTelNumber.Text = "Phone Number";
            // 
            // txtBranchPhoneNumber
            // 
            this.txtBranchPhoneNumber.Location = new System.Drawing.Point(105, 89);
            this.txtBranchPhoneNumber.Name = "txtBranchPhoneNumber";
            this.txtBranchPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.txtBranchPhoneNumber.TabIndex = 7;
            // 
            // pnlFileUpload
            // 
            this.pnlFileUpload.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFileUpload.Controls.Add(this.label2);
            this.pnlFileUpload.Controls.Add(this.lblFileName);
            this.pnlFileUpload.Controls.Add(this.btnBrowse);
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
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse to the BRANCH file you wish to import to DB";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(125, 33);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(32, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File : ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBrowse.Location = new System.Drawing.Point(22, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Import File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please select to view";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBranch);
            this.Controls.Add(this.btnProductsList);
            this.Name = "Parent";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBranch)).EndInit();
            this.pnlBranch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlViewData.ResumeLayout(false);
            this.pnlViewData.PerformLayout();
            this.pnlFileUpload.ResumeLayout(false);
            this.pnlFileUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductsList;
        private System.Windows.Forms.DataGridView gvBranch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearBranch;
        private System.Windows.Forms.Panel pnlBranch;
        private System.Windows.Forms.TextBox txtBranchDate;
        private System.Windows.Forms.Label lblBranchDate;
        private System.Windows.Forms.TextBox txtBranchPhoneNumber;
        private System.Windows.Forms.Label lblBranchTelNumber;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Panel pnlFileUpload;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportBranchToXml;
        private System.Windows.Forms.Button btnExportBranchToCSV;
        private System.Windows.Forms.Button btnExportBranchToJson;
        private System.Windows.Forms.Panel pnlViewData;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Label label3;
    }
}

