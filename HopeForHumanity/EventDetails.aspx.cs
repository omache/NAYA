using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopeForHumanity
{
    public partial class EventDetails : System.Web.UI.Page
    {
        public string request = string.Empty;
        public string RetVal = string.Empty;
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
            var c = HttpContext.Current;
            request = c.Request["Request"];
            if (IsPostBack)
                return;
            LoadMenus();
            LoadEventDetails(request);
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

        #region LoadEventDetails
        public void LoadEventDetails(string rqst)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                switch (rqst)
                {
                    case "101300":
                        sb.Append("<div class=\"event_detail\"><figure><img src=\"assets/img/img_container-runner.jpg\" alt=\"img_container\" /></figure><div class=\"event_date\"><strong>05</strong> <span>Aug</span></div></div><div class=\"event_heading clearfix\"><h2><a href=\"#\">Half Marathon event for fundraising</a></h2><div class=\"event_time clearfix\"><div class=\"venue_block\"><div class=\"location-svg\"><img src=\"assets/svg/location.svg\" alt=\"\" class=\"svg\" /></div><span>venue :</span><strong>Kigali, Rwanda</strong></div><div class=\"date_block\"><div class=\"date-svg\"><img src=\"assets/svg/calendar.svg\" alt=\"\" class=\"svg\" /></div><span>date :</span><strong>05-08-2017</strong></div><div class=\"time_block\"><div class=\"time-svg\"><img src=\"assets/svg/timer.svg\" alt=\"\" class=\"svg\" /></div><span>Time :</span><strong>10 PM</strong></div></div><div class=\"event_description\"><p>Hundreds of youth participated in a Half Marathon held Saturday, Aug 05, 10:00 a.m. - at Glory High School, KG 690 Street, Kigali, Rwanda. The Half Marathon culminated a year-long series of fundraising efforts held throughout the year to benefit the orphans, disabled children and promote girl child education in the community.</p><p>The Marathon dubbed H4M after Hope for Humanity foundation, had a fair share of success witnessing a very promising turnout. At this year's event, students, faculty members and community members came together and participated after which the evening was lit with entertainment where people danced, sang, and partied with fellow students while helping a great cause. It was fun and a considerable amount of donation was also collected in the process.</p></div><div class=\"event_descript\"><p>The Honorable Mayor served as this year's Honorary Chair. A total of $25,366.10 was raised. Approximately 10 percent will go towards the Education Foundation, which supports poor African students in financial need. </p></div></div><div class=\"row\"><div class=\"col-xs-12 col-md-7\"><div class=\"hightlight_event\"><h2>Highlights of the event</h2><p>The H4M Half Marathon is an event organised for Kigali schools, which helps raise funds for different causes each year. Throughout the year, through donations raised by bake sales, canning, benefit nights, events, and pure dedication, the young committed members of H4M help the charity by raising money all year long. </p><p>The Hope for Humanity Foundation strives to raise awareness among the people for the underprivileged children of Africa by providing proper education to the children. And eradication of poverty and providing the people with balanced diet to keep malnutrition at bay. It also aimed to improve the standard of living among the families by providing them skills and jobs.</p></div></div><div class=\"col-xs-12 col-md-5\"><div class=\"hightlight_rightblock\"><figure><img src=\"assets/img/height_light_img.jpg\" alt=\"hightImg\" /></figure><div class=\"hightlight_content\"><figure><img src=\"assets/img/hightlight_content.jpg\" alt=\"hightLight_Content\" /></figure></div></div></div></div><div class=\"forward_content clearfix\"><a href=\"EventDetails.aspx?Request=101301\" class=\"next btn btn-default\">Next</a><a href=\"EventDetails.aspx?Request=101302\" class=\"previous btn btn-default\">previous</a></div>");
                        divEventDetails.InnerHtml = sb.ToString();
                        break;
                    case "101301":
                        sb.Append("<div class=\"event_detail\"><figure><img src=\"assets/img/img_container-cyclist.jpg\" alt=\"img_container\" /></figure><div class=\"event_date\"><strong>09</strong> <span>Sep</span></div></div><div class=\"event_heading clearfix\"><h2><a href=\"#\">Half Marathon event for fundraising</a></h2><div class=\"event_time clearfix\"><div class=\"venue_block\"><div class=\"location-svg\"><img src=\"assets/svg/location.svg\" alt=\"\" class=\"svg\" /></div><span>venue :</span><strong>Kigali, Rwanda</strong></div><div class=\"date_block\"><div class=\"date-svg\"><img src=\"assets/svg/calendar.svg\" alt=\"\" class=\"svg\" /></div><span>date :</span><strong>09-09-2017</strong></div><div class=\"time_block\"><div class=\"time-svg\"><img src=\"assets/svg/timer.svg\" alt=\"\" class=\"svg\" /></div><span>Time :</span><strong>10 PM</strong></div></div><div class=\"event_description\"><p>This event was held in Uganda's capital Kampala on Saturday, 09 Sep from 10 AM in the morning. Hundreds of youth turned up to grace the occassion which included events such as road bicycle racing, time trialling, cyclo-cross and mountain bike racing.</p><p>The cycling event was a great success which saw members of the community actively involved in the competition and cheering squad. The winners in each category were awarded their trophies and gift hampers for their hard work and resilience. The evening had a twist of events as local celebrities surprised the occasion for a climatic close.</p></div><div class=\"event_descript\"><p>The Honorable Mayor served as this year's Honorary Chair. A total of $53,896 was raised during the event with gifts and vegetable donations from the local community church. </p></div></div><div class=\"row\"><div class=\"col-xs-12 col-md-7\"><div class=\"hightlight_event\"><h2>Highlights of the event</h2><p>Due to the success of this event, more events will be organised quarterly to help raise funds for the less fortunate in Kampala.</p><p>Funds collected during this event will be ploughed back to the local community to assist the orphaned children, educate the girl child and enrich local women with skills to cater for their own families.</p></div></div><div class=\"col-xs-12 col-md-5\"><div class=\"hightlight_rightblock\"><figure><img src=\"assets/img/hightlight_content_1.jpg\" alt=\"hightImg\" /></figure><div class=\"hightlight_content\"><figure><img src=\"assets/img/height_light_img_1.jpg\" alt=\"hightLight_Content\" /></figure></div></div></div></div><div class=\"forward_content clearfix\"><a href=\"EventDetails.aspx?Request=101302\" class=\"next btn btn-default\">Next</a><a href=\"EventDetails.aspx?Request=101300\" class=\"previous btn btn-default\">previous</a></div>");
                        divEventDetails.InnerHtml = sb.ToString();
                        break;
                    case "101302":
                        sb.Append("<div class=\"event_detail\"><figure><img src=\"assets/img/img_container-life.jpg\" alt=\"img_container\" /></figure><div class=\"event_date\"><strong>03</strong> <span>Mar</span></div></div><div class=\"event_heading clearfix\"><h2><a href=\"#\">Volunteering for a better life</a></h2><div class=\"event_time clearfix\"><div class=\"venue_block\"><div class=\"location-svg\"><img src=\"assets/svg/location.svg\" alt=\"\" class=\"svg\" /></div><span>venue :</span><strong>Nairobi, Kenya</strong></div><div class=\"date_block\"><div class=\"date-svg\"><img src=\"assets/svg/calendar.svg\" alt=\"\" class=\"svg\" /></div><span>date :</span><strong>03-03-2018</strong></div><div class=\"time_block\"><div class=\"time-svg\"><img src=\"assets/svg/timer.svg\" alt=\"\" class=\"svg\" /></div><span>Time :</span><strong>10 PM</strong></div></div><div class=\"event_description\"><p>Many underprivileged children in Africa have limited opportunity for sporting activities, necessary for physical development and important in learning social and life skills. You can put to use your sporting skills and passion to change these kids’ lives and ensure a better future for them.</p><p>You can volunteer with us and let us know your athletic/sporting skills so that we can plan on how best you can assist these kids.</p></div><div class=\"event_descript\"><p>Fill out the volunteer form or get in touch with us via mail to get started. </p></div></div><div class=\"row\"><div class=\"col-xs-12 col-md-7\"><div class=\"hightlight_event\"><h2>Highlights of the event</h2><p>On 03, March 2018, we are organising an open day in Nairobi, Kenya where we shall recruit various youths based on their skills in various sporting events. This will be done in the hope that youth actively involved in sporting activities shall have their minds occupied in these extra-curriculum activities and hence reduce joblessness among the youth which leads to crime.</p></div></div><div class=\"col-xs-12 col-md-5\"><div class=\"hightlight_rightblock\"><figure><img src=\"assets/img/hightlight_content_2.jpg\" alt=\"hightImg\" /></figure><div class=\"hightlight_content\"><figure><img src=\"assets/img/height_light_img_2.jpg\" alt=\"hightLight_Content\" /></figure></div></div></div></div><div class=\"forward_content clearfix\"><a href=\"EventDetails.aspx?Request=101300\" class=\"next btn btn-default\">Next</a><a href=\"EventDetails.aspx?Request=101301\" class=\"previous btn btn-default\">previous</a></div>");
                        divEventDetails.InnerHtml = sb.ToString();
                        break;
                    default:
                        sb.Append("<div style=\"text-align:center;\"><p><strong>CONTENT NOT FOUND!</strong></p></div>");
                        divEventDetails.InnerHtml = sb.ToString();
                        break;
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