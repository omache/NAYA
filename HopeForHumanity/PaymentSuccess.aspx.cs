using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopeForHumanity
{
    public partial class PaymentSuccess : System.Web.UI.Page
    {
        public SqlConnection conn = new SqlConnection(GlobalClass.ConnectionString);
        public string TrackingID = string.Empty;
        public string MerchantRef = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = HttpContext.Current;
            TrackingID = c.Request["pesapal_transaction_tracking_id"];
            MerchantRef = c.Request["pesapal_merchant_reference"];
            if (IsPostBack)
                return;
            LoadMenus();
            UpdateTrx();
        }

        #region LoadMenus
        public void LoadMenus()
        {
            FillItems(0);
            FillItems(1);
            FillItems(2);
        }
        #endregion

        #region FillItems
        public void FillItems(int x)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (x == 0)     //Menu Items
                {
                    sb.Append(GlobalClass.MainMenu);
                    divMainMenu.InnerHtml = sb.ToString();
                }
                else if (x == 1) //Page Links
                {
                    sb.Append(GlobalClass.PageLinks);
                    divLinks.InnerHtml = sb.ToString();
                }
                else if (x == 2) //Entire Footer
                {
                    sb.Append(String.Format(GlobalClass.Footer, GlobalClass.PageLinks));
                    divFooter.InnerHtml = sb.ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                GlobalClass.LogError(ex.Message + "\r\n" + ex.StackTrace);
                Response.Redirect("~/Error404.aspx");
            }
        }
        #endregion

        #region UpdateTrx
        public void UpdateTrx()
        {
            try
            {
                string query = string.Empty;
                StringBuilder sb = new StringBuilder();
                query = "EXEC sp_AddEditDonation @PesapalTrxTrackingID='" + TrackingID + "',@PesapalMerchantReference='" + MerchantRef + "',@Action=1";                
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
                Response.Redirect("~/assets/icons/404.svg");
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