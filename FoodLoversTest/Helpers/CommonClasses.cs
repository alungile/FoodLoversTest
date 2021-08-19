using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLoversTest.Helpers
{
    public class CommonClasses
    {
        public int? FormatInteger(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                return null;
            }
        }

        public decimal? FormatDecimal(string value)
        {

            try
            {
                return Convert.ToDecimal(value);
            }
            catch (FormatException)
            {
                try
                {
                    //? code below is used to allow decimal to be corrected and stored in the DB
                    var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                    var separator = currentCulture.NumberFormat.CurrencyDecimalSeparator;
                    var newValue = value.Replace(".", separator);

                    return Convert.ToDecimal(newValue);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
        }

        public DateTime? FromStringToDateTime(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    return DateTime.Parse(value);
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void insertData(string sqlStatement)
        {
            SqlConnection conn = SqlConnectionManager.GetConnectionString();
            SqlCommand cmd = new SqlCommand(sqlStatement, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var msg = e.Message;
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

    }
}
