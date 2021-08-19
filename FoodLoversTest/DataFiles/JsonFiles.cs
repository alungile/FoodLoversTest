using FoodLoversTest.Helpers;
using log4net.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLoversTest.DateFiles
{
    public class JsonFiles
    {
        CommonClasses comm = new CommonClasses();

        public List<BranchModel> ImportBranchJson(string jsonFile)
        {
            string error = string.Empty;
            var importDataList = new List<BranchModel>();
            try
            {
                using (StreamReader r = new StreamReader(jsonFile))
                {
                    string json = r.ReadToEnd();
                    importDataList = JsonConvert.DeserializeObject<List<BranchModel>>(json);

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

        public List<ProductModel> ImportProductJson(string jsonFile)
        {
            string error = string.Empty;
            var importDataList = new List<ProductModel>();
            try
            {
                using (StreamReader r = new StreamReader(jsonFile))
                {
                    string json = r.ReadToEnd();
                    importDataList = JsonConvert.DeserializeObject<List<ProductModel>>(json);

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

        public List<BranchProductModel> ImportBranchProductJson(string jsonFile)
        {
            string error = string.Empty;
            var importDataList = new List<BranchProductModel>();
            try
            {
                using (StreamReader r = new StreamReader(jsonFile))
                {
                    string json = r.ReadToEnd();
                    importDataList = JsonConvert.DeserializeObject<List<BranchProductModel>>(json);

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

        public string ExportToJson(DataTable table, string tableName)
        {
            try
            {
                string fileName = tableName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".json";

                string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                string JSONString = JsonConvert.SerializeObject(table);

                File.WriteAllText(destPath, JSONString);

                
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
