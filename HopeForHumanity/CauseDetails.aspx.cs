using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopeForHumanity
{
    public partial class CauseDetails : System.Web.UI.Page
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
            LoadCauseDetails(request);
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

        #region LoadCauseDetails
        public void LoadCauseDetails(string rqst)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                switch (rqst)
                {
                    case "101200":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Help African children to get shelter</h2><span class=\"date-desc\">06 august, 2017 </span><span class=\"palce-name\">African Child Care</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-01.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"9.7\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">9.7% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$58,354 <small>/ $600,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Being homeless is perhaps hardest on the children. They need to feel safe and secure, so that they can concentrate in school. In addition to this, they need exercise, recreation and playtime. You can donate to help African children to help them get their shelter. In short, homeless children need everything that we take for granted but they need it every day.</p><p>You can offer any kind of support to homeless children by providing therapeutic support services with the goal of improving their emotional and behavioral well being. This helps the children’s progression towards increased financial stability.</p><p>Homeless children need a wide range of support services to address their mental and physical health. They often need addiction treatment, psychological counseling, job training, childcare and eventual job placement help. Providing an overall growth to homeless children is not an easy task and the job cannot be fulfilled without your support. Hence, help us raise the standards of these poverty stricken children in any of the manners possible. We attempt to provide shelter, security and a bright future to the children in the following manner.</p><ul class=\"list-trangled\"><li>Fulfillment of primary necessities that includes food, clothing and shelter</li><li>Medical care to the children who have a poor health or to those who require special medical attention</li><li>Education opportunities to homeless children so that they can have a bright future ahead</li><li>Security to their future by providing them training on sports and other curriculum activities</li></ul><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101201":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Help girls to get Education</h2><span class=\"date-desc\">13 September, 2017 </span><span class=\"palce-name\">Girl Child Education</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-02.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"7.7\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">7.7% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$93,106 <small>/  $1,206,540</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Millions of pregnant and married adolescent girls across many African countries are being denied their education because of discriminatory policies and practices, Human Rights Watch said today, on the Day of the African Child. More than 49 million girls are out of primary and secondary school in sub-Saharan Africa, with 31 million of them out of secondary education, undermining their rights and limiting their opportunities.</p><p>Early marriage and teenage pregnancy are significant factors. In sub-Saharan Africa, 40 percent of girls marry before age 18, and African countries account for 15 of the 20 countries with the highest rates of child marriage globally. The region also has the world’s highest prevalence of adolescent pregnancies. In 14 sub-Saharan countries, between 30 and 51 percent of girls give birth before they are 18. Cultural or religious beliefs often stigmatize unmarried, pregnant girls, with the result that many pregnant girls are forced into early marriages.</p><ul class=\"list-trangled\"><li>A girl in South Sudan is more likely to die in childbirth than to finish primary school.</li><li>Fewer than 2% of girls in Somalia attend secondary school.</li><li>By grade 5 only half as many girls as boys attend school in Uganda and Kenya.</li><li>Only one disabled woman is educated for every five disabled men in East Africa.</li><li>Fewer than 12% of teachers in Uganda are female, and only 3% in Somalia.</li></ul><p>Creating long term change for women and girls requires addressing the systems and approaches that exclude them from education. We work from community to government level to help women and girls voice their concerns and create cultures that value and support women’s education. We attempt to address these issues affecting girls and women in the following manner:</p><ul class=\"list-trangled\"><li>Making schools girl-friendly with proper sanitation facilities and a private, safe place to study.</li><li>Training women in the community to provide mentorship and life skills to young girls, and advocate for girls’ education.</li><li>Providing grants and scholarship to girls to help struggling families and demonstrate the advantage of educating girls.</li><li>Providing accelerated secondary school education so women can graduate and go on to careers such as educators and health care professionals.</li></ul><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101202":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Help us grow food for the children</h2><span class=\"date-desc\">27 June, 2017 </span><span class=\"palce-name\">Farm For The Children</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-03.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"18.8\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">18.8% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$150,620 <small>/  $800,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Due to severe food shortage mainly because of prolonged drought, Green House Vegetables have become a quick solution for rural communities especially in East Africa. Green House Farming is the cultivating of tender plants or growing plants out of season under controlled conditions for protection against pests and diseases and adverse weather and also effectively managed nutrition.</p><p>Green House Production has enormous benefits which makes it a worthy investment e.g.</p><ul class=\"list-trangled\"><li>Time spent on labor is less since the area under production is small.</li><li>Production per unit area is high.</li><li>Production is done throughout the year.</li><li>Pest and diseases are easily controlled.</li><li>Effective water use since its scarce.</li><li>Maximum utilization of land.</li><li>less damage to the environment.</li><li>Vegetables are available throughout the year.</li><li>Land rotation leads to food security.</li><li>Green House Crops mature slightly earlier.</li></ul><p>The crops that can be grown in Green House conditions include: Tomatoes, Sweet pepper, Celery, Cucumber, Cabbages, Kales, onions, Spinach, Strawberry etc. and they are also sold in local markets to generate more income to run the children’s homes.The structure is simple to construct and cost friendly. The materials used for construction of the Green House are wood, polythene and insect net and are locally available. </p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101203":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Feed a child Program</h2><span class=\"date-desc\">05 November, 2017 </span><span class=\"palce-name\">Eradicate Severe Malnutrition</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-04.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"18.2\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">18.2% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$456,200 <small>/  $2,500,00</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Feed a Child focuses on the most vulnerable: malnourished children under the age of 5, pregnant and lactating women, and people living with HIV/AIDS. We do this in a variety of ways, including teaching parents about basic nutrition, fortifying food at home and supplementing with vitamins. To help kids continue to eat good food, we serve kids in over 60 schools. This program alone has helped a total of 65,000 women and children.</p><p>Safe and clean water can take women and children hours to haul, keeping them from going to school or working at paying jobs. By building water pans and rainwater harvesting systems, Feed a Child improves their health and gives them time that they can spend on education or enterprise. These new systems can hold water for up to seven months after the rains stop for the year.</p><p>Of course we couldn’t have done this without you. That is why we encourage you to keep on donating for the children in Africa. Your continued support will change the life of a child and his or her community forever!</p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101204":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Help us build schools</h2><span class=\"date-desc\">12 November, 2017 </span><span class=\"palce-name\">Education Is Key</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-05.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"25.01\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">25.01% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$750,305 <small>/  $3,000,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">All the schools we help reconstruct are provided with a new Ventilated Improved Pit (VIP) Latrine and we have recently started to include handwashing facilities as well.  We also try to provide clean drinking water at any of our schools that don’t already have this.  Many of these water supplies have benefitted whole communities and we have witnessed a great reduction in water-borne disease at all of the villages where we have worked.</p><p>When it comes to education, we believe that children deserve more than second best. So, we work hard to bring even the most remote of schools up to both national and international standards. That's why we have developed an effective way of working with schools in community clusters rather than focusing on individual locations.</p><p>We want as much of your donation to reach as many children as possible, however traditional methods of supporting a single school at a time can often be costly and inefficient. We also know that developing an isolated school can even lead to problems such as overcrowding when parents move their children from unsupported schools in the same area – meaning more pressure on teachers and resources.</p><p>Instead, by working with small groups of schools simultaneously, you can help us reach entire communities and transform education for a more sustainable and brighter future for every child.</p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101205":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Give a child basic medical care</h2><span class=\"date-desc\">03 October, 2017 </span><span class=\"palce-name\">Help Save A Life</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-06.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"80\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">80% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$850,000 <small>/  $1,300,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Healthcare in Africa differs widely, depending on the country and also the region – those living in urban areas are more likely to receive better healthcare services than those in rural or remote regions.</p><p>Many communities lack clean water and proper sanitation facilities, particularly in rural areas. This means that illnesses caused by poor hygiene, such as cholera and diarrhea, are common in some countries.</p><p>Hope for humanity has collaborated with various medical providers to setup medical camps in East Africa where people in the community can walk in with their children and obtain basic checkups, vaccinations and medication. This has seen over 80,000 men, women and children obtain free medical care courtesy of our sponsors. We encourage you to continue touching these lives for this noble cause.</p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101206":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Sponsorship Program</h2><span class=\"date-desc\">12 October, 2017 </span><span class=\"palce-name\">Sponsor a child</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-07.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"53.4\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">53.4% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Sponsors Donation : <span class=\"value\">$267,000 <small>/  $500,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">For just $40 a month, you can provide food and other life essentials to a child in need. You can give a child living in a poor community hope for tomorrow. As a sponsor, you’ll help rescue a boy or girl from the enemies of childhood — hunger, disease and poverty. You’ll meet urgent physical needs and offer the chance for a brighter future.</p><p>By your sponsorship, this is what you will afford a child:</p><ul class=\"list-trangled\"><li>Nutritious food: you give a child a hot meal at school plus provide nutritional support and education for their family.</li><li>Clean water: you give a child access to safe, clean water close to home.</li><li>Education and school supplies: you free a child to go to school and have hope for the future instead of work for food.</li><li>Livelihoods: Through sponsorship, you help parents find new ways to support their families.</li><li>Essential vitamins, and more!</li></ul><p>In return, you will be able to get: </p><ul class=\"list-trangled\"><li>A photo and important information about your sponsored child.</li><li>The opportunity to communicate with your child through letters and show how much you care!</li><li>Regular updates on your child’s well being as well as notes and/or drawings from your child.</li></ul><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101207":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Child Trafficking</h2><span class=\"date-desc\">23 September, 2017 </span><span class=\"palce-name\">Reunite a child with their family</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-08.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"35\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">35% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Sponsors Donation : <span class=\"value\">$35,000 <small>/  $100,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">For decades, countries in Africa have been marked with the issue of child trafficking. In the past few years, this problem has been increasing. In a 2014 Global Report by the UN, child trafficking has increased by 5 percent from 2007-2010. Governments in Rwanda, South Africa, and Ethiopia have all reported a discernible rise in child trafficking cases.</p><p>Most child trafficking victims come from poor neighborhoods and have little to no education. Kidnapped or lured by the prospects of a job, these children are forced to work as domestic laborers, sex slaves, and miners. Their captors subject them to a violent environment, and they do not provide sufficient amounts of food and water.</p><p>Despite positive developments to end human trafficking, the problem is nowhere near over. Millions of children in Africa are still trapped in this modern-day slave trade. Besides laws and legal forces working to stop the situation, advancements made in education can help prevent children from being deceived into coerced labor. Education will paint a picture of a brighter future and engage children’s minds, making the alternative of work at such a young age undesirable.</p><p>We at hope for humanity have partnered with various different organizations, who help in finding children who are missing and bring them back to their respectful families. We are always providing means for children to pursue a better education through provisions of books, supplies, and scholarships. With aid from contributors and donations, we can continue to foster growth and combat trafficking in Africa.</p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    case "101208":
                        sb.Append("<div class=\"text-center section-header\"><h2 class=\"h4\">Slavery in Africa</h2><span class=\"date-desc\">15 December, 2017 </span><span class=\"palce-name\">Everyone deserves a chance</span></div><figure class=\"article-pic\"><img src=\"assets/img/detail-big-09.jpg\" alt=\"\" /></figure><div class=\"progress\"><div class=\"progress-bar\" role=\"progressbar\" aria-valuenow=\"11.4\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"progress-value\">11.4% </span></div></div><div class=\"detail-description\"><div class=\"donation-details\"><span class=\"donation\">Donation : <span class=\"value\">$5,700 <small>/  $50,000</small></span></span><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default pull-right\">DONATE NOW</a></div><p class=\"donation-summary\">Just in case you haven't been up to par with current news, heres CNN's recap of the current situation in Libya:</p><blockquote class=\"callout\"><ul><li><strong>October 2017,</strong> A CNN team travels to Libya and witnesses a dozen men auctioned -- some for as little as $400 each. The crew is also told of auctions taking place at nine locations in the country.</li><li><strong>November 14, 2017</strong> CNN publishes an exclusive report exposing how migrants are being sold by smugglers. In addition to alerting the Libyan authorities, CNN hands over footage as evidence to the International Criminal Court.</li><li><strong>November 17, 2017</strong> Libya opens an investigation into slave markets operating in the country following CNN's exclusive report. The probe is being overseen by the government's Anti-Illegal Immigration Agency. The International Organization for Migration (IOM), an intergovernmental organization based in Geneva that focuses on managing migration, welcomes Libya's investigation but warns that \"the smuggling networks are becoming stronger, more organized and better equipped.\"</li><li><strong>November 19, 2017</strong> Protesters gather near the Libyan Embassy in central Paris to denounce the slave auctions and urge authorities to act quickly. Later that day, soccer star Paul Pogba celebrates his goal for Manchester United with a handcuff gesture highlighting the plight of migrants in Libya.</li><li><strong>November 20, 2017</strong> Alpha Conde, president of the African Union, and Federica Mogherini, the European Union's foreign policy chief, pledge in a joint news release to assist Libya in swiftly combating the issue of human traffickers.</li><li><strong>November 20, 2017</strong> UN Secretary-General Antonio Guterres says he is \"horrified\" by the reports of African migrants sold as slaves. He says the footage demonstrates some of \"the most egregious abuses of human rights\" and may amount to crimes against humanity.</li><figure><img class=\"pull-left\" src=\"assets/img/img-blog-details-07.jpg\" alt=\"\" /></figure><li><strong>November 21, 2017</strong> The UN-backed Libyan Government of National Accord, or GNA, say they are keen to address violations against illegal immigrants but argued that the international community -- and countries from which migrants travel -- should also take responsibility.</li><li><strong>November 21, 2017</strong> A Nigerian official tells CNN that repatriation of migrants from Libya is not a straightforward procedure before adding that the Nigerian government is working with authorities in Libya and the IOM to speed up the process.</li><li><strong>November 22, 2017</strong> France's President Emmanuel Macron calls the practice of selling migrants as slaves \"a crime against humanity\" and vows to press for sanctions. France calls for an \"urgent\" meeting of the UN Security Council to discuss this treatment of migrants in Libya, Foreign Minister Jean-Yves Le Drian says.</li><figure><img class=\"pull-right\" src=\"assets/img/img-blog-details-08.jpg\" alt=\"\" /></figure><li><strong>November 22, 2017</strong> Diplomats at a UN Security Council meeting on human trafficking call for an investigation that would hold the perpetrators of slave auctions in Libya accountable. The council also adopts a resolution designed to clamp down on human trafficking and slavery.</li><li><strong>November 22, 2017</strong> Spain's foreign ministry expresses its \"deep concern\" over CNN's report. Spain urges Libya to follow the UN Convention against Transnational Organized Crime and its protocol on human trafficking, the Spanish Foreign Ministry posts on its official Twitter account.</li><li><strong>November 23, 2017</strong> African Union chairman Moussa Faki Mahamat tells CNN the situation in Libya is a \"shared responsibility\" that stems from the ensuing chaos after Moammar Gadhafi was ousted. He says that an AU representative has been sent to Libya to see what measures should be taken. Mahamat says he has asked the African commission on human rights to open an investigation so \"concrete steps(can) be taken.\"</li><figure><img class=\"pull-left\" src=\"assets/img/img-blog-details-09.jpg\" alt=\"\" /></figure></ul></blockquote><p>The \"End slavery in Africa\" Campaign has become an international tool for raising awareness and calling for action to end all forms of slavery against African men and women in Libya. The hope for humanity foundation has realized the role of mass and social media in combating slavery in Africa, which undermines human rights, social stability, public health and people's educational and employment opportunities. Social media is a powerful tool that can be a useful way to expose abuse of human rights wherever it happens, and for men and women across the world to come together and say “Enough is enough!”. You can help us too by sharing this campaign as widely as possible to help end the injustice that has crept up in Libya. Also you can help by donating so that we can keep the fire burning through social media campaigns across the globe to raise awareness of these heinous acts and hopefully bring them to an end.</p><a data-toggle=\"modal\" href=\"~/Error404.aspx\" data-target=\".donate-form\" class=\"btn btn-default\">DONATE NOW</a></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
                        break;
                    default:
                        sb.Append("<div style=\"text-align:center;\"><p><strong>CONTENT NOT FOUND!</strong></p></div>");
                        divCauseDetails.InnerHtml = sb.ToString();
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
    }
}