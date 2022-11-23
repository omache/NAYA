using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopeForHumanity
{
    public partial class Ourstory : System.Web.UI.Page
    {
        public string strAmount = string.Empty;
        public string strType = string.Empty;
        public string strFreq = string.Empty;
        public string strFname = string.Empty;
        public string strLname = string.Empty;
        public string strEmail = string.Empty;
        public string strPhone = string.Empty;
        public string strAddress = string.Empty;
        public string strMessage = string.Empty;
        public string TrxReference = string.Empty;
        public string TrxDateTime = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
                return;
            LoadMenus();
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

        protected void btnDonate_Click(object sender, EventArgs e)
        {
            if (iAmount.Value != "")
                strAmount = iAmount.Value;
            else
                strAmount = hfAmount.Value;
            strType = ddlType.SelectedValue.ToString();
            strFreq = ddlFreq.SelectedValue.ToString();
            strFname = fname.Value;
            strLname = lname.Value;
            strEmail = email.Value;
            strPhone = phone.Value;
            strAddress = Address.Value;
            strMessage = message.Value;
            TrxReference = string.Format("{0:ssMMyyHHddmm}", DateTime.Now);
            TrxDateTime = string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
            //Now set sessions here:
            Session["Amount"] = strAmount;
            Session["Type"] = geType(strType);
            Session["Freq"] = strFreq;
            Session["Fname"] = strFname;
            Session["Lname"] = strLname;
            Session["Email"] = strEmail;
            Session["Phone"] = strPhone;
            Session["Address"] = strAddress;
            Session["Message"] = strMessage;
            Session["TrxReference"] = TrxReference;
            Session["TrxDateTime"] = TrxDateTime;
            //Response.Redirect("~/Payment.aspx", false);
            Global.Database database = new Global.Database();
            database.SaveTrx(TrxReference, TrxDateTime, geType(strType), strFreq, strFname, strLname, strEmail, strPhone, strAddress, strMessage, strAmount, "0");
            Response.Redirect("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=johnspax@gmail.com&item_name=" + geType(strType) + "&amount=" + strAmount
                + "&shopping_url=https://www.newhopeforhumanity.org&return=https://www.newhopeforhumanity.org/PaymentSuccess.aspx&cancel_return=https://www.newhopeforhumanity.org/PaymentFail.aspx"
                + "&currency_code=USD", false);
        }

        protected void btnDonateBitcoin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaymentBitcoin.aspx", false);
        }

        #region geType
        public string geType(string strVal)
        {
            string strRetVal = string.Empty;
            switch (strVal)
            {
                case "Educate":
                    strRetVal = "Educate A Child";
                    break;
                case "Feed":
                    strRetVal = "Feed A Child";
                    break;
                case "Grow":
                    strRetVal = "Grow Food";
                    break;
                case "School":
                    strRetVal = "Build Schools";
                    break;
                case "Health":
                    strRetVal = "Health Care";
                    break;
                default:
                    strRetVal = "Other";
                    break;
            }
            return strRetVal;
        }
        #endregion
    }
}