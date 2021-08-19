using FoodLoversTest.Helpers;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLoversTest
{
    public class DatabaseService
    {
        protected FoodLoversEntities DB = new FoodLoversEntities();
        protected CommonClasses comm = new CommonClasses();

        #region Branches

        #region Entity Framework

        // Retrieve Branche's details using ID 
        public Branch GetBranchByID(int braID)
        {
            return DB.Branches
                     .Where(x => x.ID == braID).FirstOrDefault();
        }

        // Adds the new Branche
        public string SaveBranch(BranchModel bra)
        {
            try
            {
                var branch = new Branch();
                branch.ID = bra.ID;
                branch.Name = bra.Name;
                branch.TelephoneNumber = bra.TelephoneNumber;
                branch.OpenDate = (DateTime)bra.OpenDate;
                //branch.OpenDate = (DateTime)comm.FromStringToDateTime(bra.OpenDate);
                DB.Branches.Add(branch);

                DB.SaveChanges();
                return bra.ID.ToString();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return "Error saving - " + ex.Message;
            }
        }

        public int GetBranchMaxID()
        {
            try
            {
                return DB.Branches.Select(x => x.ID).Max();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return 0;
            }
        }

        // Update the Branche
        public string UpdateBranch(int braID, string name, string phoneNumber, DateTime date)
        {
            try
            {
                var result = DB.Branches
                            .Where(x => x.ID == braID)
                            .FirstOrDefault();
                if (result != null)
                {
                    result.Name = name;
                    result.TelephoneNumber = phoneNumber;
                    result.OpenDate = date;
                }
                DB.SaveChanges();
                return braID.ToString();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return "Error saving the branch - " + ex.Message;
            }            
        }

        public void DeleteBranch(int branchID)
        {
            try
            {
                var result = DB.Branches
                             .Where(x => x.ID == branchID)
                             .FirstOrDefault();
                if (result != null)
                {
                    DB.Branches.Remove(result);
                }
                DB.SaveChanges();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        #endregion

        #region SQL
        // Retrieve Branche's details using ID
        public DataTable GetBranches(int braID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlConnectionManager.GetConnectionString().ConnectionString))
                {

                    string sqlCmd = "SELECT * FROM Branch";
                    if (braID > 0)
                    {
                        sqlCmd += "WHERE pro.ID = " + braID;
                    }
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd, conn);
                    sqlDA.Fill(dt);
                    int rowCount = dt.Rows.Count;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }

            return dt;
        }

        public void SaveBranchProduct(int branchID, int productID)
        {
            var connString = SqlConnectionManager.GetConnectionString().ConnectionString;
            var sqlCon = new SqlConnection(connString);
            try
            {
                
                sqlCon.Open();
                DataTable dtData = new DataTable();
                var sqlCmd = new SqlCommand("spInsertBranchProduct", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                sqlCmd.Parameters.AddWithValue("@BranchID", branchID);
                sqlCmd.Parameters.AddWithValue("@ProductID", productID);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }

        public void DeleteBranchProductByBranchID(int branchID)
        {
            var connString = SqlConnectionManager.GetConnectionString().ConnectionString;
            var sqlCon = new SqlConnection(connString);
            try
            {
                sqlCon.Open();
                DataTable dtData = new DataTable();
                var sqlCmd = new SqlCommand("spInsertBranchProduct", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "Delete");
                sqlCmd.Parameters.AddWithValue("@BranchID", branchID);
                sqlCmd.Parameters.AddWithValue("@ProductID", 0);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        #endregion

        #endregion

        #region Products

        #region Entity Framework
        public Product GetProductByID(int prodID)
        {
            return DB.Products
                     .Where(x => x.ID == prodID).FirstOrDefault();
        }

        // Adds the new Branche
        public string SaveProduct(ProductModel product)
        {
            try
            {
                var prod = new Product();
                prod.ID = product.ID;
                prod.Name = product.Name;
                prod.WeightedItem = product.WeightedItem;
                prod.SuggestedSellingPrice = product.SuggestedSellingPrice;
                DB.Products.Add(prod);

                DB.SaveChanges();
                return prod.ID.ToString();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return "Error saving - " + ex.Message;
            }
        }

        public int GetProductMaxID()
        {
            try
            {
                return DB.Products.Select(x => x.ID).Max();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return 0;
            }
        }

        // Update the Branche
        public string UpdateProduct(int prodID, string name, decimal? sellingPrice, bool weightedItem)
        {
            try
            {
                var result = DB.Products
                            .Where(x => x.ID == prodID)
                            .FirstOrDefault();
                if (result != null)
                {
                    result.Name = name;
                    result.SuggestedSellingPrice = sellingPrice;
                    result.WeightedItem = weightedItem;
                }
                DB.SaveChanges();
                return prodID.ToString();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                return "Error saving the product - " + ex.Message;
            }
        }

        public List<Product> GetAllProduct()
        {
            return DB.Products.Select(x => x).ToList();
        }        

        public void DeleteProduct(int productID)
        {
            try
            {
                var result = DB.Products
                             .Where(x => x.ID == productID)
                             .FirstOrDefault();
                if (result != null)
                {
                    DB.Products.Remove(result);
                }
                DB.SaveChanges();
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        #endregion

        #region SQL
        // Retrieve Product's details using ID
        public DataTable GetProducts(int prodID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlConnectionManager.GetConnectionString().ConnectionString))
                {
                    string sqlCmd = @"SELECT pro.ID AS ID, pro.[Name] AS ProductName, pro.WeightedItem, pro.SuggestedSellingPrice AS SellingPrice, bra.[Name] AS Branch FROM Product pro
                                LEFT JOIN BranchProduct proBra on proBra.ProductID = pro.ID
                                LEFT JOIN Branch bra on bra.ID = proBra.BranchID";

                    if (prodID > 0)
                    {
                        sqlCmd += "WHERE pro.ID = " + prodID;
                    }

                    SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd, conn);
                    sqlDA.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return dt;
        }

        // Retrieve Product's details using BranchID
        public DataTable GetProductsByBranchID(int branchID)
        {
            var productList = new DataTable();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlConnectionManager.GetConnectionString().ConnectionString))
                {
                    string sqlCmd = @" SELECT DISTINCT p.[Name]
                                      FROM [FoodLovers].[dbo].Product p
                                      LEFT JOIN BranchProduct bp on p.ID = bp.ProductID ";

                    if (branchID > 0)
                    {
                        sqlCmd += " WHERE bp.BranchID = " + branchID;
                    }

                    SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd, conn);
                    sqlDA.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return dt;
        }

        public DataTable GetBranchesByProductID(int productID)
        {
            var productList = new DataTable();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlConnectionManager.GetConnectionString().ConnectionString))
                {
                    string sqlCmd = @"SELECT DISTINCT b.[Name]
                                      FROM [FoodLovers].[dbo].Branch b
                                      LEFT JOIN BranchProduct bp on b.ID = bp.BranchID";

                    if (productID > 0)
                    {
                        sqlCmd += " WHERE bp.ProductID = " + productID;
                    }

                    SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd, conn);
                    sqlDA.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return dt;
        }

        public void DeleteBranchProductByProductID(int productID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlConnectionManager.GetConnectionString().ConnectionString))
                {
                    string sqlCmd = @"DELETE [BranchProduct]
                                      WHERE ProductID = " + productID;

                    SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }

        #endregion

        #endregion

    }
}
