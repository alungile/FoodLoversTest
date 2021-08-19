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
    public class CSVFiles
    {
        CommonClasses comm = new CommonClasses();

        public List<BranchModel> ImportBranchCSV(string path)
        {
            string[] csvlines = null;
            string error = string.Empty;
            var importDataList = new List<BranchModel>();
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    csvlines = System.IO.File.ReadAllLines(path);
                }

                var query = from csvline in csvlines.Skip(1)
                              let data = csvline.Split(',')
                              select new { data };

                foreach (var x in query)
                {
                    importDataList.Add(new BranchModel
                    {
                        ID = Convert.ToInt32(x.data[0]),
                        Name = x.data[1],
                        TelephoneNumber = x.data[2],
                        OpenDate = comm.FromStringToDateTime(x.data[3]),
                    });
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

        public List<ProductModel> ImportProductCSV(string path)
        {
            string[] csvlines = null;
            string error = string.Empty;
            var importDataList = new List<ProductModel>();
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    csvlines = System.IO.File.ReadAllLines(path);
                }

                var query = from csvline in csvlines.Skip(1)
                            let data = csvline.Split(',')
                            select new { data };

                foreach (var x in query)
                {
                    importDataList.Add(new ProductModel
                    {
                        ID = Convert.ToInt32(x.data[0]),
                        Name = x.data[1],
                        WeightedItem = (x.data[2] == "N") ? true : false,
                        SuggestedSellingPrice = comm.FormatDecimal(x.data[3]),
                    });
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

        public List<BranchProductModel> ImportBranchProductCSV(string path)
        {
            string[] csvlines = null;
            string error = string.Empty;
            var importDataList = new List<BranchProductModel>();
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    csvlines = System.IO.File.ReadAllLines(path);
                }

                var query = from csvline in csvlines.Skip(1)
                            let data = csvline.Split(',')
                            select new { data };

                foreach (var x in query)
                {
                    importDataList.Add(new BranchProductModel
                    {
                        BranchID = Convert.ToInt32(x.data[0]),
                        ProductID = Convert.ToInt32(x.data[1]),
                    });
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

        public string ExportToCSV(DataTable dt, string tableName)
        {
            try
            {
                string fileName = tableName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn col in dt.Columns)
                {
                    sb.Append(col.ColumnName + ',');
                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sb.Append(row[i].ToString() + ",");
                    }

                    sb.AppendLine();
                }

                File.WriteAllText(destPath, sb.ToString());

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
