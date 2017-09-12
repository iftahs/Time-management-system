using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Facebook;
using System.Reflection;
using System.Net;
using System.IO;
using Bs_Pro14.Classes;
using Bs_Pro14.Utilities;

namespace Bs_Pro14
{

    public partial class frmFacebookLogin : Form
    {
        private const long app_id = 325924401169701;
        private const string redirect_uri = "https://www.facebook.com/connect/login_success.html";
        private const string client_secret = "f92cd70bf5b323e0ac2f6e16f946f0da";
        private string responseUrl;
        public string token { get; set; }
        public frmFacebookLogin()
        {
            InitializeComponent();
            //Go to login facebook url
            this.webBrowser1.Url = new Uri("https://www.facebook.com/v2.9/dialog/oauth?display=popup&response_type=token&client_id="
                + app_id
                + "&redirect_uri=" + redirect_uri);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            responseUrl = e.Url.ToString();
            if (responseUrl.Contains("#access_token="))
            {
                int start_token = responseUrl.IndexOf("=");
                int end_token = responseUrl.IndexOf("&expires_in");
                int len = end_token - start_token - 1;
                token = responseUrl.Substring(start_token + 1, len);
                showDetails(token);
            }

            if (responseUrl.Contains("access_denied") && !responseUrl.Contains("login.php"))
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }

        private void showDetails(string token)
        {
            string json = string.Empty;
            string url = @"https://graph.facebook.com/v2.9/me?fields=id%2Cname&access_token=" + token;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
                string id;
                id = json.Substring(7);
                id = id.Split('"')[0];
                login(id);
            }
        }

        public void login(string id)
        {
            Person p = Person.getPersonByFacebookID(id);
            if (p == null)
            { 
                if (Program.person == null)
                { 
                MessageBox.Show("לא נמצא משתמש שמתאים לפרופיל הנבחר. עליך להיכנס תחילה למערכת ואז להתחבר לחשבון הפייסבוק", "Facebook profile not found");
                Form2 frm = new Form2();
                frm.Show();
                }
                else
                {
                    Program.person.FacebookID = id;
                    Person.UpdateInDataBase(Program.person, Program.person.ID);
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }
            else
            { 
                Program.person = p;
                Form1 frm = new Form1();
                frm.Show();
            }
            this.Hide(); 
        }

        private void frmFacebookLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
