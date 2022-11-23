using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Data.SqlClient;
using System.Text;

namespace HopeForHumanity
{
    public class GlobalClass
    {
        public static string AESPass = "UGFzc0B3b3JkMQ==";
        public static string AESSalt = "U0AxdFNAMXQ=";
        public static string AESIV = "ZTY3NWY3MjVlNjc1ZjcyNQ==";
        public static string Seed = "UEBzc3dvcmQxYWJjYmFuaw==";
        public static string GetRandomNumber(int length)
        {
            char[] chars = "1234567890".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password;
        }
        public static string GetRandomPassword(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password + GetRandomPassword1(2);
        }
        public static string GenerateToken(String AccountID)
        {

            return Shuffle(AccountID + GetPassword(1) + DateTime.Now.ToString("yyyyMMddHHmmss"));

        }
        public static string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        public static string GetPassword(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password + "3";
        }
        public static string GetRandomPassword1(int length)
        {
            char[] chars = "1234567890".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password + GetPassword(2);
        }
        public static string GetRandomPassword2(int length)
        {
            char[] chars = "!@#$%&*".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //Don't Allow Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password;
        }
        public static void SaveUserActivity(string Activity, string ModuleID)
        {
            string SQl = "Execute sp_addAuditTrail @UserID = '" + HttpContext.Current.Session["UserName"].ToString() +
                "', @Activity = '" + Activity + "', @ModuleID = '" + ModuleID + "', @RemoteIP='" +
                HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString() + "'";
            try
            {
                using (SqlConnection Con = new SqlConnection(GlobalClass.ConnectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(SQl, Con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
            }
        }
        public static string ConnectionString
        {
            get
            {
                string Key = "K3yFor3lm@";
                try
                {
                    string ServerName = ConfigurationManager.AppSettings["DBServer"];
                    string DBName = ConfigurationManager.AppSettings["DBName"];
                    string Username = ConfigurationManager.AppSettings["DBUser"];
                    Username = EncDec.Decryption(Username, Key);
                    string Pwd = ConfigurationManager.AppSettings["DBPWD"];
                    Pwd = EncDec.Decryption(Pwd, Key);

                    return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};MultipleActiveResultSets=true",
                        ServerName, DBName, Username, Pwd);
                }
                catch (Exception ex)
                {
                    LogError(ex.Message + "\r\n" + ex.StackTrace);
                    return "";
                }
            }
        }
        #region MainMenu    
        public static string MainMenu
        {
            get
            {
                try
                {

                    return "<div class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-1\"><nav><ul class=\"nav navbar-nav\"><li class=\"active\"><a href=\"Default.aspx\">Home</a></li><li><a href=\"javascript:;\" data-toggle=\"dropdown\" class=\"submenu-icon\">Causes <span class=\"glyphicon glyphicon-chevron-down\"></span><span class=\"glyphicon glyphicon-chevron-up\"></span></a><!-- Drop Down  --><div class=\"dropdown-menu\"><ul><li><a href=\"Causes.aspx\">Our Causes</a></li></ul></div></li><li><a href=\"javascript:;\" data-toggle=\"dropdown\" class=\"submenu-icon\">about us <span class=\"glyphicon glyphicon-chevron-down\"></span><span class=\"glyphicon glyphicon-chevron-up\"></span></a><!-- Drop Down  --><div class=\"dropdown-menu\"><ul><li><a href=\"Ourstory.aspx\">Our Story</a></li><li><a href=\"Ourmission.aspx\">Our Mission</a></li><li><a href=\"Volunteer.aspx\">Become a Volunteer</a></li><li><a href=\"Faq.aspx\">Faq </a></li><li><a href=\"Events.aspx\">event </a></li><li><a href=\"Launch.aspx\">launch </a></li></ul></div><!-- end  --></li><li><a href=\"javascript:;\" data-toggle=\"dropdown\" class=\"submenu-icon\">Blog <span class=\"glyphicon glyphicon-chevron-down\"></span><span class=\"glyphicon glyphicon-chevron-up\"></span></a><!-- Drop Down  --><div class=\"dropdown-menu\"><ul><li><a href=\"Blog.aspx\">Our Blog</a></li></ul></div></li><li><a href=\"Contactus.aspx\">contact us</a></li></ul></nav><div class=\"navbar-form navbar-right search-form\" role=\"search\"><div class=\"form-group\"><input type=\"text\" class=\"form-control\" placeholder=\"Search Here\" id=\"autocomplete\" onkeyup=\"changeInput(this.value)\"/><div id=\"result\"></div></div><button type=\"submit\"><i class=\"icon-search\"></i></button></div></div>";
                }
                catch (Exception ex)
                {
                    LogError(ex.Message + "\r\n" + ex.StackTrace);
                    return "";
                }
            }
        }
        #endregion
        #region PageLinks    
        public static string PageLinks
        {
            get
            {
                try
                {

                    return "<ul class=\"social-icons hidden-xs\"><li><a href=\"https://www.facebook.com/Hope-For-Humanity-H4M-159212461473638/\" target=\"_blank\"><i class=\"fa fa-facebook\"></i></a></li><li><a href=\"https://plus.google.com/u/0/112243020770520188557/\" target=\"_blank\"><i class=\"fa fa-google-plus\"></i></a></li><li><a href=\"https://twitter.com/hope_humanity2/\" target=\"_blank\"><i class=\"fa fa-twitter\"></i></a></li><li><a href=\"https://www.linkedin.com/in/hope-for-humanity/\" target=\"_blank\"><i class=\"fa fa-linkedin\"></i></a></li><li><a href=\"https://www.youtube.com/channel/UCu2DZ19ad_i0WPqTBxH2BAw/\" target=\"_blank\"><i class=\"fa fa-youtube\"></i></a></li></ul>";
                }
                catch (Exception ex)
                {
                    LogError(ex.Message + "\r\n" + ex.StackTrace);
                    return "";
                }
            }
        }
        #endregion
        #region Footer
        public static string Footer
        {
            get
            {
                try
                {
                    return "<div class=\"row\"><div class=\"col-xs-12 col-sm-4\"><div class=\"footer-logo\"><a href=\"Default.aspx\" title=\"Welcome to Hope for Humanity\"><img src=\"assets/img/logo.png\" alt=\"Charity\"/></a></div><p>New Hope For Humanity is a fundraising association that works globally to provide support in education via charity. Our members have spread worldwide to ensure that fundraising amounts to delivering help to the needy at the right place and for the right purpose.</p><address style=\"width:100%;\"><span><i class=\"fa fa-home\"></i><span>3982 Chardonnay Drive, Seattle, WA</span> </span><span><i class=\"fa fa-phone-square\"></i><span>+1 206-233-6742</span></span><span><i class=\"fa fa-envelope\"></i><span><a href=\"mailto:admin@newhopeforhumanity.org\">admin@newhopeforhumanity.org</a></span></span></address></div><div class=\"col-xs-12 col-sm-4 twitter-update\"><h6>Twitter Feed</h6><p><a href=\"https://twitter.com/john_ndosh/status/943573298419560448\" target=\"_blank\"><span class=\"charity\">@john_ndosh</span> Great job you are doing in helping the less fortunate. Keep up the good work. <span class=\"comment-time\">2 hours ago</span> </a></p><p><a href=\"https://twitter.com/hope_humanity2/status/943574380742938625\" target=\"_blank\"><span class=\"charity\">@hope_humanity2</span>We are doing the best we can to make sure that children in Africa are getting the basic education, health care and other social amenities. Your help is most welcome. <span class=\"comment-time\">2 hours ago</span> </a></p></div><div class=\"col-xs-12 col-sm-4\"><h6>Newsletter Signup</h6><p>Sign up for our newsletter that will undoubtedly help you get acquainted with our current events.</p><div role=\"form\" class=\"sign-up\"><div class=\"input-group\"><input id=\"subEmail\" class=\"form-control\" type=\"email\" placeholder=\"Email\"/><div class=\"input-group-addon\"><input type=\"submit\" class=\"btn btn-theme\" value=\"Submit\" onclick =\"return validateEmail();\"/></div></div></div><h6>Follow us</h6><div runat=\"server\" id=\"divLinksFooter\">{0}</div></div></div>";
                }
                catch (Exception ex)
                {
                    LogError(ex.Message + "\r\n" + ex.StackTrace);
                    return "";
                }
            }
        }
        #endregion
        #region BaseURL
        public static string BaseURL
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["BaseURL"];
                }
                catch (Exception ex)
                {
                    LogError(ex.Message + "\r\n" + ex.StackTrace);
                    return "";
                }
            }
        }
        #endregion
        #region Encode to Base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion
        #region DecodeBase64
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        #endregion
        #region Log
        public static void Log(string Data)
        {
            try
            {
                string ErrorFolderPath = StartPath + @"\Logs\" + string.Format("{0:dd MMM yyyy}.log", DateTime.Now);
                ErrorFolderPath = ErrorFolderPath.Replace("\\bin", "");
                StreamWriter Writer = new StreamWriter(ErrorFolderPath, true);
                Writer.WriteLine(string.Format("{0:HH:mm:ss}", DateTime.Now) + ": " + Data);
                Writer.Close();
            }
            catch (Exception ex)
            {
                LogError(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
        #endregion
        #region LogMobileTrx
        public static void MobileLog(string Data)
        {
            try
            {
                string ErrorFolderPath = StartPath + @"\MobileLogs\" + string.Format("{0:dd MMM yyyy}.log", DateTime.Now);
                ErrorFolderPath = ErrorFolderPath.Replace("\\bin", "");
                StreamWriter Writer = new StreamWriter(ErrorFolderPath, true);
                Writer.WriteLine(string.Format("{0:HH:mm:ss}", DateTime.Now) + ": " + Data);
                Writer.Close();
            }
            catch (Exception ex)
            {
                LogError(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
        #endregion
        #region LogAgentTrx
        public static void AgentLog(string Data)
        {
            try
            {
                string ErrorFolderPath = StartPath + @"\AgentLogs\" + string.Format("{0:dd MMM yyyy}.log", DateTime.Now);
                ErrorFolderPath = ErrorFolderPath.Replace("\\bin", "");
                StreamWriter Writer = new StreamWriter(ErrorFolderPath, true);
                Writer.WriteLine(string.Format("{0:HH:mm:ss}", DateTime.Now) + ": " + Data);
                Writer.Close();
            }
            catch (Exception ex)
            {
                LogError(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
        #endregion
        #region LogError
        public static void LogError(string Error)
        {
            try
            {
                string ErrorFolderPath = StartPath + @"\Errors\" + string.Format("{0:dd MMM yyyy}.log", DateTime.Now);
                ErrorFolderPath = ErrorFolderPath.Replace("\\bin", "");
                StreamWriter Writer = new StreamWriter(ErrorFolderPath, true);
                Writer.WriteLine(string.Format("{0:HH:mm:ss}", DateTime.Now) + ": " + Error);
                Writer.Close();
            }
            catch (Exception)
            {
            }
        }
        #endregion
        #region StartPath
        public static string StartPath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            }
        }
        #endregion      


        public static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        #region Oraconnect
        private static string ConnectionStringOracleLive
        {
            get
            {
                try
                {
                    string DBName = ConfigurationSettings.AppSettings["DBNameOracle"];
                    string Username = ConfigurationSettings.AppSettings["DBUserOracle"];
                    string Pwd = ConfigurationSettings.AppSettings["DBPWDOracle"];

                    return string.Format("Data Source={0};User ID={1};Password={2};",
                        DBName, Username, Pwd);
                }
                catch (Exception ex)
                {
                    //WriteErrorLog(ex.Message + "\r\n" + ex.StackTrace);

                    return "";
                }
            }
        }
        #endregion

    }

}