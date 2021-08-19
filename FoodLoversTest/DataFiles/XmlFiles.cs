using FoodLoversTest.Helpers;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FoodLoversTest.DateFiles
{
    public class XmlFiles
    {
        CommonClasses comm = new CommonClasses();

        public List<BranchModel> ImportBranchXml(string path)
        {
            string error = string.Empty;
            var importDataList = new List<BranchModel>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
               
                foreach (XmlNode node in doc.DocumentElement.SelectNodes("Branch"))
                {
                   var model = new BranchModel();
                    model.ID = Convert.ToInt32(node.Attributes["ID"].Value);
                    model.Name = (node.Attributes["Name"] != null) ? node.Attributes["Name"].Value : string.Empty;
                    model.TelephoneNumber = (node.Attributes["TelephoneNumber"] != null) ? node.Attributes["TelephoneNumber"].Value : string.Empty;
                    var date = (node.Attributes["OpenDate"] != null) ? node.Attributes["OpenDate"].Value : string.Empty;
                    model.OpenDate = comm.FromStringToDateTime(date);
                    importDataList.Add(model);
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return importDataList;
        }

        public List<ProductModel> ImportProductXml(string path)
        {
            string error = string.Empty;
            var importDataList = new List<ProductModel>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                foreach (XmlNode node in doc.DocumentElement.SelectNodes("Branch"))
                {
                    var model = new ProductModel();
                    model.ID = Convert.ToInt32(node.Attributes["ID"].Value);
                    model.Name = (node.Attributes["Name"] != null) ? node.Attributes["Name"].Value : string.Empty;
                    model.WeightedItem = (node.Attributes["WeightedItem"] != null && node.Attributes["WeightedItem"].Value == "Y") ? true : false;
                    var price = (node.Attributes["SuggestedSellingPrice"] != null) ? node.Attributes["SuggestedSellingPrice"].Value : string.Empty;
                    model.SuggestedSellingPrice = comm.FormatDecimal(price);
                    importDataList.Add(model);
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return importDataList;
        }

        public List<BranchProductModel> ImportBranchProductXml(string path)
        {
            string error = string.Empty;
            var importDataList = new List<BranchProductModel>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                foreach (XmlNode node in doc.DocumentElement.SelectNodes("Branch"))
                {
                    var model = new BranchProductModel();
                    model.BranchID = Convert.ToInt32(node.Attributes["BranchID"].Value);
                    model.ProductID = Convert.ToInt32(node.Attributes["ProductID"].Value);

                    importDataList.Add(model);
                }
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            return importDataList;
        }

        public string ExportToXml(DataTable table, string tableName)
        {
            try
            {
                string fileName = tableName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xml";

                string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                table.TableName = tableName;
                table.WriteXml(destPath);

                return "File exported Successfully";
            }
            catch (Exception ex)
            {
                BasicConfigurator.Configure();
                log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
                log.Error("Error Message: " + ex.Message.ToString(), ex);

                return "Error exporting your file, please try again later.";
            }
        }
    }
}
