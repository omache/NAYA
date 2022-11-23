using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopeForHumanity
{
    public partial class BlogDetails : System.Web.UI.Page
    {
        public string request = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = HttpContext.Current;
            request = c.Request["Request"];
            if (IsPostBack)
                return;
            if (IsPostBack)
                return;
            LoadMenus();
            LoadBlogDetails(request);
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

        #region LoadBlogDetails
        public void LoadBlogDetails(string rqst)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                switch (rqst)
                {
                    case "101400":
                        //Article
                        sb.Append("<article class=\"blog blog-details anim-section\"><figure><img src=\"assets/img/blog-pic.jpg\" alt=\"\" /></figure><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1 caption\"><h2 class=\"h1\">Fundraising initiatives for better life of the underprivileged children in Africa</h2><ul class=\"post-in\"><li>Posted In : Fundraising</li><li>3 : comments</li></ul><p>Early December, 2017, fund raising initiatives were taken up and drives were launched to attract donations for the education of the underprivileged children. Many people participated in the event donated their hearts out. </p><p>We assure our sponsors and contributors that the money will surely bring a great difference in the lives of these children. Almost $25M has been raised by using a direct debit processing platform that was rolled out by the Charities Aid Foundation last year.</p><blockquote class=\"callout\"><p>According to a statement released by the authority, the total amount given through the CAF Donate service stands at £34.8m. The statement said that over 2,000 charities are using the payment platform and 100 new charities are signing up every month.</p></blockquote><h3 class=\"h2\">Some facts and figures about donation</h3><p>CAF also said that 88,294 people have set up regular, direct debit donations in the last 12 months, while a further 91,081 individuals have made one-off donations from their bank account to individual charities. The average, one-off donation made via CAF Donate is £89.</p><figure><img class=\"pull-left\" src=\"assets/img/img-blog-details-01.jpg\" alt=\"\" /></figure><p>CAF Donate was launched in June 2014 to help ease the administrative burden of processing both online and offline donations for small to medium-sized charities. CAF also said it would make it easier for charities to take both regular donations and one-off gifts.</p><p>It was set up to differentiate itself from other, existing sites such as JustGiving, in that CAF Donate can be run on a charity’s own website, rather than through a third party. Chris Allwood, senior product development manager at CAF, said:</p><figure><img class=\"pull-right\" src=\"assets/img/img-blog-details-02.jpg\" alt=\"\" /></figure><ul><li>People now increasingly use card payments and direct debits as their preferred way of paying for things and giving to good causes.</li><li>While larger charities are well equipped to handle this, thousands of smaller organization have previously been priced out of being able to accept money in this way through a combination of processing fees and admin costs.</li><li>Prior to its introduction, cashless payments were not an option for most charities. </li><li>We now want every charity to have the option to receive donations in this way.</li><li>This will enable all charities to receive through a level platform.</li><li>This initiative will see donation moneys sky rocket.</li><li>More and more charity events are expected in the year.</li></ul><div class=\"row block-content\"><div class=\"col-xs-12 col-sm-6\"><h3>Our Charity Endeavour</h3><p>We conduct various charity events to ensure that the children in Africa get good education and better medical facilities. Our events include marathon, painting competitions and many such events to collect resources for the purpose.</p></div><div class=\"col-xs-12 col-sm-6\"><h3>Our Fundraising Goal</h3><p>Through continuous fundraising events, we strive to make the life of the impoverished children better. We also try to improve their nutrition level by providing them better food, so that they can provide a healthy life to their children.</p></div></div><p>We are always motivated and poised towards betterment of children who are leading miserable lives in the impoverished areas of Africa. Your donations can help us achieve our aim.</p></div></div></article>");
                        //Comments
                        //sb.Append("<div class=\"row\"><div class=\"col-xs-12\"><div class=\"comment-block\"><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1\"><article class=\"media comment profile-block\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">James Kerr</h4><span class=\"date\">Tue, 18/12/2017 - 10:19 AM</span></header><p>Working with the charity trust has been a very revealing and enriching experience. I realized that there are many small things that can be done to contribute to child rights. Yes, what is needed is a bit of sensitivity and willingness to do something worthwhile.</p><ul class=\"social-icons\"><li><a href=\"#\"><i class=\"fa fa-facebook\"></i></a></li><li><a href=\"#\"><i class=\"fa fa-twitter\"></i></a></li><li><a href=\"#\"><i class=\"fa fa-dribbble\"></i></a></li><li><a href=\"#\"><i class=\"fa fa-pinterest\"></i></a></li><li><a href=\"#\"><i class=\"fa fa-google-plus\"></i></a></li><li><a href=\"#\"><i class=\"fa fa-instagram\"></i></a></li></ul></div></article><section class=\"live-comment\"><h3>Comments</h3><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-01.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Martin Slater</h4><span class=\"date\">Tue, 19/12/2017 - 01:05 PM</span></header><p>Changing the lives of children is a continuous process. Nothing can be done in a limited period. As individuals we have to continue to give support by way of financial help, time as well as other resources. I believe in continuity and devotion without deviation. The charity is doing just that.</p></div></article><article class=\"media comment col-xs-offset-1\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-02.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Mary Mayall</h4><span class=\"date\">Tue, 20/12/2017 - 05:27 AM</span></header><p>Working with the charitable trust has been a very revealing and enriching experience. I realized that there are many small things that can be done to contribute to child rights. Yes, what is needed is a bit of sensitivity and willingness to do something worthwhile.</p></div></article><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-03.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">John Fitz Gerald</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>Putting children first is really about ensuring a healthy future for our nation. No country can hope to progress and become truly civilized unless its young have access to food, shelter, clothing, education and a life full of promise; a life that allows them to explore their immense potential.</p></div></article></section></div></div></div></div></div>");
                        divBlogDetails.InnerHtml = sb.ToString();
                        break;
                    case "101401":
                        //Article
                        sb.Append("<article class=\"blog blog-details anim-section\"><figure><img src=\"assets/img/blog-pic0.jpg\" alt=\"\" /></figure><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1 caption\"><h2 class=\"h1\">Fundraising for African unprivileged children</h2><ul class=\"post-in\"><li>Posted In : Fundraising</li><li>3 : comments</li></ul><p>We have been raising funds with great difficulty for the work that this charity does in Africa. We have just established a home for ophaned children in Eastern Malawi and also provided funding for widows to build businesses in order for them to help themselves and stimulate the local economy.</p><p>We work with young women to train and develop their expertise with skills such as sewing and tailoring so they can start their own business and contribute to the community. This ensures that they avoid joining the cohort of ladies in the oldest industry known to man- the “night trade”. </p><blockquote class=\"callout\"><p>Early October saw the light of a new day with Hope for humanity launching a program aimed at nurturing and developing a new cadre of African women leaders through training, coaching, mentoring, networking and research.</p><p>This has turned out to become the surest way for young women to achieve their financial independence and shun away from using sex as currency or tolerating sexual infidelity all together and gaining pathways out of poverty.</p><figure><img class=\"pull-left\" src=\"assets/img/img-blog-details-05.jpg\" alt=\"\" /></figure><p>The Hope for Humanity Women Employability Program is a workforce development program that seeks to improve employment prospects and income generating capacities of young women with high potential but disadvantaged in Lilongwe and Namitete towns of Malawi. Therefore the Hope for Humanity Women Employability solution is designed to provide a bridge to employment to these young women.</p><figure><img class=\"pull-right\" src=\"assets/img/img-blog-details-06.jpg\" alt=\"\" /></figure><p>In addition to this, lack of information or knowledge on HIV transmission and associated risk factors is also a major contributor. Hope for Humanity is actively involved in hosting voluntary HIV and Counselling sessions for its beneficiaries and their partners where they will be trained on HIV transmission and associated risk factors as well as voluntary counselling and testing methods.</p><p>All this is done in light of the foreseen future where these young women will be able to work and earn a living to support their children and eradicate poverty altogether.</p></blockquote></div></div></article>");
                        //Comments
                        //sb.Append("<div class=\"row\"><div class=\"col-xs-12\"><div class=\"comment-block\"><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1\"><section class=\"live-comment\"><h3>Comments</h3><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-12.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Mary J. McCloud</h4><span class=\"date\">Tue, 19/12/2017 - 01:05 PM</span></header><p>It is my hope that you will be able to achieve all that you have set out to achieve in terms of charity work. God Bless.</p></div></article><article class=\"media comment col-xs-offset-1\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-04.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Kevin Cervantes</h4><span class=\"date\">Tue, 20/12/2017 - 05:27 AM</span></header><p>I would really like to participate in some of the events that you have planned out come next year. Keep in loop please.</p></div></article><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-05.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Michael Vieira</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>I hope this charity serves people well but all looks good.</p></div></article></section></div></div></div></div></div>");
                        divBlogDetails.InnerHtml = sb.ToString();
                        break;
                    case "101402":
                        //Article
                        sb.Append("<article class=\"blog blog-details anim-section\"><figure><img src=\"assets/img/blog-pic4.jpg\" alt=\"\" /></figure><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1 caption\"><h2 class=\"h1\">Bringing Changes in 2018</h2><ul class=\"post-in\"><li>Posted In : Upcoming</li><li>3 : comments</li></ul><blockquote class=\"callout\"><p>The year 2017 has been a very exciting year for us and 2018 is promising to be even bigger. We are taking steps in preparation for 2018 to expand our influence throughout the rest of the Continent of Africa. This is why your donation to this cause is so important to us and we treasure every single coin that goes towards our projects. </p><p>Here is just a sneak peek of what we have lined up in 2018:</p><ul><li>When it comes to adventures and exploring, our events and challenges are the best way to fundraise for Hope for Humanity.</li><li>Whether you’re a seasoned pro or just looking for a new challenge, we’ve got something for everyone in 2018.</li><li>See breathtaking views, mountain ranges, national parks and challenge yourself with our new treks and walks in 2018.</li><li>We have lined up cycling events which are a great chance to challenge yourself, meet new people, and fundraise for Hope for Humanity.</li><li>Take the plunge for Hope for humanity and sign up to a swimming event. There will be loads to choose from coming year 2018.</li></ul><p>Do something you love. Do something you didn't think you could do. Do something incredible for people living with a terminal illness.</p><p>Signing up to an event for Hope for Humanity means our volunteers and workers can continue to be there for children living in poverty in Africa, when they're needed most.</p></blockquote></div></div></article>");
                        //Comments
                        //sb.Append("<div class=\"row\"><div class=\"col-xs-12\"><div class=\"comment-block\"><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1\"><section class=\"live-comment\"><h3>Comments</h3><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-07.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Kennedy Miller</h4><span class=\"date\">Tue, 19/12/2017 - 01:05 PM</span></header><p>Hello, I was wondering how to donate in any way possible. Please reach me on this.</p></div></article><article class=\"media comment col-xs-offset-1\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-06.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Jonathan Kent</h4><span class=\"date\">Tue, 20/12/2017 - 05:27 AM</span></header><p>It is my belief that acts of charity are the greatest act of service to humanity. This is great work indeed</p></div></article><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-13.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Joyce C. Magers</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>Good Work</p></div></article></section></div></div></div></div></div>");
                        divBlogDetails.InnerHtml = sb.ToString();
                        break;
                    case "101403":
                        //Article
                        sb.Append("<article class=\"blog blog-details anim-section\"><figure><img src=\"assets/img/blog-pic5.jpg\" alt=\"\" /></figure><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1 caption\"><h2 class=\"h1\">Improve the Health of some 200 kids in Uganda </h2><ul class=\"post-in\"><li>Posted In : Health</li><li>5 : comments</li></ul><p>This project will purchase a motor bikes to be used by project health contact persons to enable them monitor children's health in local villages. Visits by healthcare professionals to remote villages improve children's health by monitoring and increasing overall community awareness. </p><p>In Uganda, nearly 1 in 10 children die before they reach their fifth birthday due, in large part, to preventable diseases like malaria. As with most sub-Saharan African countries, the road networks in Uganda are poor, thus attempting to deliver even the most basic healthcare is extremely difficult. Fleet for Health is a program that will improved healthcare to nearly 12 million people across sub-Saharan Africa through a fleet of motorcycles, ambulances and trekking vehicles that enables doctors to reach even the most rural areas.</p><blockquote class=\"callout\"><p>In Uganda, nearly 1 in 10 children die before they reach their fifth birthday due, in large part, to preventable diseases like malaria.</p></blockquote><h3 class=\"h2\">Fleet of Health Program</h3><p>Many diseases that we know how to cure or prevent remain widespread, simply because patients cannot receive treatment. The World Health Organization estimates that two thirds of the 34.2 million people living with HIV/AIDS are located in sub-Saharan Africa, with T.B. being the leading cause of deaths among patients in this area. Most of the time, the science, education and technology with the potential to prevent these deaths, are all in place; however their availability is stifled due to challenges with mobility. Without reliable transport, the vaccines, drugs, bed-nets, condoms and trained-professionals won’t do any good if they can’t get to where they are needed in time.</p><figure><img class=\"pull-left\" src=\"assets/img/img-blog-details-03.jpg\" alt=\"\" /></figure><p>Fleet of Health, provides a simple solution: a fleet of over 1,400 motorcycles, ambulances and other four-wheel vehicles. There’s nothing new about donating vehicles for healthcare in Africa, but often these vehicles fall apart after 8 months and aren’t suited to the context of sub-Saharan Africa, where most people live in rural areas that can only be reached by small dirt paths (at best). What makes Fleet of Health so effective is that they charge a fixed price of 18 cents per km for motorcycles, which includes fuel. Fleet of Health also focuses on maintenance, so that the vehicles can be in constant use for years without breakdowns. The low and predictable prices allow government and aid groups to better incorporate maintenance in their budget planning.</p><figure><img class=\"pull-right\" src=\"assets/img/img-blog-details-04.jpg\" alt=\"\" /></figure><p>These simple, affordable and straightforward solutions improve access to healthcare and the potential to improve the lives of 12 million people. A mobilized outreach worker can see nearly 6 times more people and can double the time they spend in communities as they cut down travelling time. This means that not only can they monitor diseases more effectively, but also serve as a link to the nearest health facility when necessary.</p><p>Fleet of health is expected to have a visible impact during the first half of 2018. The visible impact that Fleet of Health will have on healthcare in Africa, will give hope that dependable transport could do the same for those out of reach of water, education and energy.</p></div></div></article>");
                        //Comments
                        //sb.Append("<div class=\"row\"><div class=\"col-xs-12\"><div class=\"comment-block\"><div class=\"row\"><div class=\"col-xs-12 col-sm-10 col-sm-offset-1\"><section class=\"live-comment\"><h3>Comments</h3><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-08.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Elden Thorne</h4><span class=\"date\">Tue, 19/12/2017 - 01:05 PM</span></header><p>Good work you guys are doing, Really looking forward to 2018.</p></div></article><article class=\"media comment col-xs-offset-1\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-14.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Blanche Tierney</h4><span class=\"date\">Tue, 20/12/2017 - 05:27 AM</span></header><p>Last month I was involved in charity work in Kigali Rwanda and it was an awesome event. Cant wait to return next year. Keep it up:-)</p></div></article><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-09.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Jeremy S. Doctor</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>I have been looking for a charity where I can give my donation and give towards uplifting humanity and this was just the thing of legends. Good stuff and keep going.</p></div></article><article class=\"media comment col-xs-offset-1\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-10.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Warren Calvert</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>Awesome.:-)</p></div></article><article class=\"media comment\"><figure><img class=\"media-object\" src=\"assets/img/profile-pic-11.jpg\" alt=\"\" /></figure><div class=\"media-body\"><header><h4 class=\"media-heading\">Vernon Williams</h4><span class=\"date\">Tue, 22/12/2017 - 11:46 AM</span></header><p>Great job you guys</p></div></article></section></div></div></div></div></div>");
                        divBlogDetails.InnerHtml = sb.ToString();
                        break;
                    default:
                        sb.Append("<div style=\"text-align:center;\"><p><strong>CONTENT NOT FOUND!</strong></p></div>");
                        divBlogDetails.InnerHtml = sb.ToString();
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