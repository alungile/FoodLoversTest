using FoodLoversTest.DateFiles;
using FoodLoversTest.Helpers;
using FoodLoversTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodLoversTest
{
    public partial class ProductPage : Form
    {
        private DatabaseService DBService = new DatabaseService();
        private CommonClasses comm = new CommonClasses();

        public ProductPage()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFileName(dialog.FileName);
                lblFileName.Text += path;
                var importedProductFile = new List<ProductModel>();
                // Get extension of the fileName
                string extension = Path.GetExtension(dialog.FileName);

                if (extension != null)
                {
                    switch (extension.ToLower())
                    {
                        case ".json":
                            JsonFiles importJson = new JsonFiles();
                            importedProductFile = importJson.ImportProductJson(dialog.FileName);
                            break;

                        case ".csv":
                            CSVFiles importSCV = new CSVFiles();
                            importedProductFile = importSCV.ImportProductCSV(dialog.FileName);
                            break;

                        case ".xml":
                            XmlFiles importXml = new XmlFiles();
                            importedProductFile = importXml.ImportProductXml(dialog.FileName);
                            break;
                    }
                }

                foreach (var item in importedProductFile)
                {
                    DBService.SaveProduct(item);
                }
                ClearProductFileds();
            }
            gvProduct.DataSource = DBService.GetProducts(0);
            MessageBox.Show("Products imported saved successfully!!!!");
        }

        private void gvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearProductFileds();
            try
            {
                if (gvProduct.CurrentRow.Index != -1)
                {
                    var rowID = Convert.ToInt32(gvProduct.CurrentRow.Cells[0].Value.ToString());
                    var product = DBService.GetProductByID(rowID);
                    txtProductID.Text = product.ID.ToString();
                    txtProductName.Text = product.Name.ToString();
                    cbWeightedItem.Checked = product.WeightedItem;
                    txtSellingPrice.Text = !string.IsNullOrEmpty(product.SuggestedSellingPrice.ToString()) ? product.SuggestedSellingPrice.ToString() : string.Empty;

                    pnlViewData.Visible = true;
                }
            }
            catch (Exception)
            {}
        }

        private void LoadProduct()
        {
            gvProduct.DataSource = DBService.GetProducts(0);
        }

        private void ClearProductFileds()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            cbWeightedItem.Checked = false;
            txtSellingPrice.Text = "";
            pnlViewData.Visible = false;
        }

        private void btnBranchesList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent branches = new Parent();
            branches.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string returnMsg = String.Empty;
            var product = new ProductModel();
            int productID = 0;
            decimal? price = null;
            if (!string.IsNullOrEmpty(txtSellingPrice.Text.Trim()))
            {
                try
                {
                    price = Math.Round(Convert.ToDecimal(txtSellingPrice.Text.Trim()), 2);
                }
                catch { }
            }

            try { productID = Convert.ToInt32(txtProductID.Text.Trim()); } catch { }

            // Update existing product
            if (productID > 0)
            {
                returnMsg = DBService.UpdateProduct(productID, txtProductName.Text.Trim(), price, cbWeightedItem.Checked);
            }
            else
            {
                // Save New product
                product.Name = txtProductName.Text.Trim();
                product.SuggestedSellingPrice = price;
                product.WeightedItem = cbWeightedItem.Checked;
                // NOTE : cannot make the ID field Identity as file imports comes with IDs
                product.ID = DBService.GetProductMaxID() + 1; // Get the last record's ID
                returnMsg = DBService.SaveProduct(product);
            }

            // Assign a product to this product
            if (returnMsg.Contains("Error"))
            {
                MessageBox.Show(returnMsg.ToString());
            }
            else
            {
                MessageBox.Show("Records saved successfully!!!!");
            }
            gvProduct.DataSource = DBService.GetProducts(0);
            ClearProductFileds();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there is a selected product to delete
                if (!string.IsNullOrEmpty(txtProductID.Text.Trim()))
                {
                    // Show the warning to the user
                    if (DialogResult.OK == MessageBox.Show("Are you sure you want to delete this product", "Warning !!!", MessageBoxButtons.OKCancel))
                    {
                        int prodID = Convert.ToInt32(txtProductID.Text.Trim());
                        DBService.DeleteBranchProductByProductID(prodID);  // First Delete all the links to this product
                        DBService.DeleteProduct(prodID);       // Then Delete the product
                        LoadProduct();  // Update Griedview
                        ClearProductFileds();   // Clear input fields
                    }
                }
                else
                {
                    MessageBox.Show("Please select the product you wish to delete");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while deleting your selected product");
            }
        }

        private void btnExportProductToJson_Click(object sender, EventArgs e)
        {
            var jsonFiles = new JsonFiles();
            var table = DBService.GetProducts(0);
            var returnResult = jsonFiles.ExportToJson(table, "Product");

            MessageBox.Show(returnResult);
        }

        private void btnExporProductToCSV_Click(object sender, EventArgs e)
        {
            var csvFiles = new CSVFiles();
            var table = DBService.GetProducts(0);
            var returnResult = csvFiles.ExportToCSV(table, "Product");

            MessageBox.Show(returnResult);
        }

        private void btnExportProductToXml_Click(object sender, EventArgs e)
        {
            var xmlFiles = new XmlFiles();
            var table = DBService.GetProducts(0);
            var returnResult = xmlFiles.ExportToXml(table, "Product");

            MessageBox.Show(returnResult);
        }

        #region Branch Products
        private void btnImportBranchProducts_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFileName(dialog.FileName);
                lblBranchProducts.Text += path;
                var importedFile = new List<BranchProductModel>();
                // Get extension of the fileName
                string extension = Path.GetExtension(dialog.FileName);

                if (extension != null)
                {
                    switch (extension.ToLower())
                    {
                        case ".json":
                            JsonFiles importJson = new JsonFiles();
                            importedFile = importJson.ImportBranchProductJson(dialog.FileName);
                            break;

                        case ".csv":
                            CSVFiles importSCV = new CSVFiles();
                            importedFile = importSCV.ImportBranchProductCSV(dialog.FileName);
                            break;

                        case ".xml":
                            XmlFiles importXml = new XmlFiles();
                            importedFile = importXml.ImportBranchProductXml(dialog.FileName);
                            break;
                    }
                }

                foreach (var item in importedFile)
                {
                    DBService.SaveBranchProduct(item.BranchID, item.ProductID);
                }
            }
            MessageBox.Show("Branche's Products imported saved successfully!!!!");
        }
        #endregion

        private void btnViewBranches_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtProductID.Text.Trim()))
                {
                    GlobalFiels.SelectedID = Convert.ToInt32(txtProductID.Text.Trim());
                    GlobalFiels.SelectedView = "Branch";
                    GlobalFiels.SelectedItemName = txtProductName.Text.Trim();
                    // Open another dialog with the data
                    View viewData = new View();
                    viewData.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select the product.");
                }
            }
            catch
            {
                MessageBox.Show("Please select the product.");
            }
        }

        private void btnClearBranch_Click(object sender, EventArgs e)
        {
            ClearProductFileds();
        }
    }
}
