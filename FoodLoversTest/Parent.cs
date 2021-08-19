using FoodLoversTest.DateFiles;
using FoodLoversTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FoodLoversTest
{
    public partial class Parent : Form
    {
        private DatabaseService DBService = new DatabaseService();       
        private CommonClasses comm = new CommonClasses();

        public Parent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var branch = new BranchModel();
            int branchID = 0;
           
            DateTime date;
            if (!string.IsNullOrEmpty(txtBranchDate.Text.Trim()))
            {
                try
                {
                    date = Convert.ToDateTime(txtBranchDate.Text.Trim());
                }
                catch (Exception)
                {
                    date = DateTime.Now;
                }
                
            }
            else
            {
                date = DateTime.Now;
            }
            branch.OpenDate = date;

            string returnMsg = String.Empty;
            try { branchID = Convert.ToInt32(txtBranchID.Text.Trim()); } catch { }
            // Update existing branch
            if (branchID > 0)
            {
                returnMsg = DBService.UpdateBranch(branchID, txtBranchName.Text.Trim(), txtBranchPhoneNumber.Text.Trim(), date);
            }
            else
            {
                // Save New branch
                branch.Name = txtBranchName.Text.Trim();
                branch.TelephoneNumber = txtBranchPhoneNumber.Text.Trim();
                // NOTE : cannot make the ID field Identity as file imports comes with IDs
                branch.ID = DBService.GetBranchMaxID() + 1; // Get the last record's ID
                returnMsg = DBService.SaveBranch(branch);
            }

            // Assign a product to this branch
            if (returnMsg.Contains("Error"))
            {
                MessageBox.Show(returnMsg.ToString());
            }
            else
            {
                branchID = Convert.ToInt32(returnMsg);
                AssignProducts(branchID);
                MessageBox.Show("Records saved successfully!!!!");
            }
            gvBranch.DataSource = DBService.GetBranches(0);
        }

        private void LoadBranches()
        {
            gvBranch.DataSource = DBService.GetBranches(0);
        }

        private void gvBranch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (gvBranch.CurrentRow.Index != -1)
                {
                    var rowID = Convert.ToInt32(gvBranch.CurrentRow.Cells[0].Value.ToString());
                    var branch = DBService.GetBranchByID(rowID);
                    txtBranchID.Text = branch.ID.ToString();
                    txtBranchName.Text = branch.Name.ToString();
                    txtBranchPhoneNumber.Text = !string.IsNullOrEmpty(branch.TelephoneNumber) ? branch.TelephoneNumber.ToString() : string.Empty;
                    txtBranchDate.Text = !string.IsNullOrEmpty(branch.OpenDate.ToString()) ? branch.OpenDate.ToString() : string.Empty;
                }

                var listProducts = DBService.GetAllProduct();
                if (listProducts != null)
                {
                    foreach (var item in listProducts)
                    {
                        lstProducts.Items.Add(new ListItem(item.Name, item.ID.ToString()));
                    }
                }
                pnlViewData.Visible = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFileName(dialog.FileName); 
                lblFileName.Text += path;
                var importedbranchFile = new List<BranchModel>();
                // Get extension of the fileName
                string extension = Path.GetExtension(dialog.FileName);

                if (extension != null)
                {
                    switch (extension.ToLower())
                    {
                        case ".json":
                            JsonFiles importJson = new JsonFiles();
                            importedbranchFile = importJson.ImportBranchJson(dialog.FileName);
                            break;

                        case ".csv":
                              CSVFiles importSCV = new CSVFiles();
                              importedbranchFile = importSCV.ImportBranchCSV(dialog.FileName);
                            break;

                        case ".xml":
                            XmlFiles importXml = new XmlFiles();
                            importedbranchFile = importXml.ImportBranchXml(dialog.FileName);
                            break;
                    }
                }

                foreach (var item in importedbranchFile)
                {
                    DBService.SaveBranch(item);
                }
            }
            gvBranch.DataSource = DBService.GetBranches(0);
            MessageBox.Show("Branches imported saved successfully!!!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there is a selected branch to delete
                if (!string.IsNullOrEmpty(txtBranchID.Text.Trim()))
                {
                    // Show the warning to the user
                    if (DialogResult.OK == MessageBox.Show("Are you sure you want to delete this branch", "Warning !!!", MessageBoxButtons.OKCancel))
                    {
                        int branchID = Convert.ToInt32(txtBranchID.Text.Trim());
                        DBService.DeleteBranchProductByBranchID(branchID);  // First Delete all the links to this branch
                        DBService.DeleteBranch(branchID);       // Then Delete the branch
                        LoadBranches();
                        ClearBranchFileds();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the branch you wish to delete");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while deleting your selected branch");
            }
        }

        private void AssignProducts(int branchID)
        {
            // Check if there are any selected products
            if (lstProducts.SelectedItems != null)
            {
                // First Delete all the products linked to this branch
                DBService.DeleteBranchProductByBranchID(branchID);
                // Re-Assign selected products to this branch
                foreach (ListItem item in lstProducts.SelectedItems)
                {
                    int proID = Convert.ToInt32(item.Value);

                    DBService.SaveBranchProduct(branchID, proID);
                }
            }
        }

        private void btnClearBranch_Click(object sender, EventArgs e)
        {
            ClearBranchFileds();
        }

        private void ClearBranchFileds()
        {
            txtBranchID.Text = "";
            txtBranchName.Text = "";
            txtBranchPhoneNumber.Text = "";
            txtBranchDate.Text = "";
            lstProducts.Items.Clear();
            pnlViewData.Visible = false;
        }
       
        // This displays the Products panel
        protected void btnProductsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductPage productPage = new ProductPage();
            productPage.ShowDialog();
        }

        private void btnExportBranchToJson_Click(object sender, EventArgs e)
        {
            var jsonFiles = new JsonFiles();
            var table = DBService.GetBranches(0);
            var returnResult = jsonFiles.ExportToJson(table, "Branch");

            MessageBox.Show(returnResult);
        }

        private void btnExportBranchToCSV_Click(object sender, EventArgs e)
        {
            var csvFiles = new CSVFiles();
            var table = DBService.GetBranches(0);
            var returnResult = csvFiles.ExportToCSV(table, "Branch");

            MessageBox.Show(returnResult);
        }

        private void btnExportBranchToXml_Click(object sender, EventArgs e)
        {
            var xmlFiles = new XmlFiles();
            var table = DBService.GetBranches(0);
            var returnResult = xmlFiles.ExportToXml(table, "Branch");

            MessageBox.Show(returnResult);
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBranchID.Text.Trim()))
                {
                    GlobalFiels.SelectedID = Convert.ToInt32(txtBranchID.Text.Trim());
                    GlobalFiels.SelectedView = "Product";
                    GlobalFiels.SelectedItemName = txtBranchName.Text.Trim();
                    // Open another dialog with the data
                    View viewData = new View();
                    viewData.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select the branch.");
                }
            }
            catch
            {
                MessageBox.Show("Please select the branch.");
            }
        }
    }
}
