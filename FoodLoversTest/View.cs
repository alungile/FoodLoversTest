using FoodLoversTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodLoversTest
{
    public partial class View : Form
    {
        private DatabaseService DBService = new DatabaseService();
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            if (GlobalFiels.SelectedID > 0 && !string.IsNullOrEmpty(GlobalFiels.SelectedView))
            {
                 gvViewData.DataSource = null;

                if (GlobalFiels.SelectedView.ToLower().Equals("branch"))
                {
                    lblViewText.Text = "Showing branches that sells " + GlobalFiels.SelectedItemName;
                    gvViewData.DataSource = DBService.GetBranchesByProductID(GlobalFiels.SelectedID);
                }
                else
                {
                    lblViewText.Text = "These products are sold at " + GlobalFiels.SelectedItemName + " branch.";
                    gvViewData.DataSource = DBService.GetProductsByBranchID(GlobalFiels.SelectedID);
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
