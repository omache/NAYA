using Pesapal.APIHelper;
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
    public partial class Payment : System.Web.UI.Page
    {
        public SqlConnection conn = new SqlConnection(GlobalClass.ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            LoadMenus();
            SaveTrx();
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

        #region SaveTrx
        public void SaveTrx()
        {
            try
            {
                string query = string.Empty;
                StringBuilder sb = new StringBuilder();
                query = "EXEC sp_AddEditDonation @TrxReference='" + Session["TrxReference"].ToString() + "',@UniqueID='" + Session["TrxDateTime"].ToString() + "',@DonationType='" +
                    Session["Type"].ToString() + "',@Frequency='" + Session["Freq"].ToString() + "',@FirstName='" + Session["Fname"].ToString() + "',@LastName='" +
                    Session["Lname"].ToString() + "',@Email='" + Session["Email"].ToString() + "',@Phone='" + Session["Phone"].ToString() + "',@Address='" + Session["Address"].ToString() +
                    "',@Message='" + Session["Message"].ToString() + "',@Amount='" + Session["Amount"].ToString() + "',@Action=0";                    
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

        protected string GetPesapalUrl()
        {
            //Live: https://www.pesapal.com/API/PostPesapalDirectOrderV4
            //Test: https://demo.pesapal.com/API/PostPesapalDirectOrderV4
            Uri pesapalPostUri = new Uri("https://www.pesapal.com/API/PostPesapalDirectOrderV4"); /*change to
            https://www.pesapal.com/API/PostPesapalDirectOrderV4 when you are ready to go live!*/
            Uri pesapalCallBackUri = new Uri("https://www.newhopeforhumanity.org/PaymentSuccess.aspx");
            // Setup builder
            IBuilder builder = new APIPostParametersBuilderV2()
                    //.ConsumerKey("gGDUpR+cIPyaxT/4JpSE6RPkuCYi23Wq")//Test
                    //.ConsumerSecret("vUAtCFCNGECNOiGoOinCmr02PWk=")//Test
                    .ConsumerKey("rRuHD+l/ddhNnMc7c+E259/08K43Eg/t")//Live
                    .ConsumerSecret("D+hw6HgDjfyYxGJHyLU4LbiGrag=")//Live
                    .OAuthVersion(EOAuthVersion.VERSION1)
                    .SignatureMethod(ESignatureMethod.HMACSHA1)
                    .SimplePostHttpMethod(EHttpMethod.GET)
                    .SimplePostBaseUri(pesapalPostUri)
                    .OAuthCallBackUri(pesapalCallBackUri);
            // Initialize API helper
            APIHelper<IBuilder> helper = new APIHelper<IBuilder>(builder);
            // Populate line items
            var lineItems = new List<LineItem> { };
            // For each item purchased, add a lineItem.
            // For example, if the user purchased 3 of Item A, add a line item as follows:
            var lineItem = new LineItem
            {
                Particulars = Session["Type"].ToString(),
                UniqueId = Session["TrxDateTime"].ToString(),
                Quantity = 1,
                UnitCost = Convert.ToInt32(Session["Amount"].ToString())
        };
            lineItem.SubTotal = (lineItem.Quantity * lineItem.UnitCost);
            lineItems.Add(lineItem);
            // Do the same for additional items purchased
            // Compose the order
            PesapalDirectOrderInfo webOrder = new PesapalDirectOrderInfo()
            {
                Amount = (lineItems.Sum(x => x.SubTotal)).ToString(),
                Description = Session["Message"].ToString(),
                Type = "MERCHANT",
                Reference = Session["TrxReference"].ToString(),
                Email = Session["Email"].ToString(),
                FirstName = Session["Fname"].ToString(),
                LastName = Session["Lname"].ToString(),
                PhoneNumber = Session["Phone"].ToString(),
                LineItems = lineItems
            };
            // Post the order to PesaPal, which upon successful verification,
            // will return the string containing the url to load in the iframe
            return helper.PostGetPesapalDirectOrderUrl(webOrder);
        }
    }
}