namespace FoodLoversTest
{
    partial class View
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
            this.gvViewData = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblViewText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // gvViewData
            // 
            this.gvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViewData.Location = new System.Drawing.Point(102, 48);
            this.gvViewData.Name = "gvViewData";
            this.gvViewData.Size = new System.Drawing.Size(367, 345);
            this.gvViewData.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblViewText
            // 
            this.lblViewText.AutoSize = true;
            this.lblViewText.Location = new System.Drawing.Point(74, 9);
            this.lblViewText.Name = "lblViewText";
            this.lblViewText.Size = new System.Drawing.Size(0, 13);
            this.lblViewText.TabIndex = 2;
            this.lblViewText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViewText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gvViewData);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvViewData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblViewText;
    }
}