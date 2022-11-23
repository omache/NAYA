using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace HopeForHumanity.Global
{
    public class Database
    {
        public SqlConnection conn = new SqlConnection(GlobalClass.ConnectionString);
        #region SaveTrx
        public void SaveTrx(string TrxRef, string TrxDateTime, string DonationType, string Frequency, string FirstName, string LastName, string Email, 
            string Phone, string Address, string Message, string Amount, string Action)
        {
            try
            {
                string query = string.Empty;
                StringBuilder sb = new StringBuilder();
                query = "EXEC sp_AddEditDonation @TrxReference='" + TrxRef + "',@UniqueID='" + TrxDateTime + "',@DonationType='" +
                    DonationType + "',@Frequency='" + Frequency + "',@FirstName='" + FirstName + "',@LastName='" +
                    LastName + "',@Email='" + Email + "',@Phone='" + Phone + "',@Address='" + Address +
                    "',@Message='" + Message + "',@Amount='" + Amount + "',@Action=" + Action;
                using (conn)
                {
                    conn.Open();
                    GlobalClass.MobileLog("SQLQuery: " + query);
                    SqlDataReader rd = PostToDB(conn, query);
                }
            }
            catch (Exception ex)
            {
                GlobalClass.LogError(ex.Message + "\r\n" + ex.StackTrace);
                //GlobalClass.MobileLog("Exception Result: " + RetVal);
                //Response.Redirect("~/assets/icons/404.svg");
            }
        }
        #endregion

        #region PostToDB with::returns data reader
        public SqlDataReader PostToDB(SqlConnection Conn, string sql)
        {
            SqlDataReader reader = null;
            try
            {
                GlobalClass.MobileLog("SQL Command PostToDB: " + sql);
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                GlobalClass.LogError(ex.Message + "\r\n" + ex.StackTrace);
            }
            //GlobalClass.MobileLog("Reader: " + reader);
            return reader;
        }
        #endregion
    }
}