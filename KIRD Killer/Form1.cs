using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MSHTML;
using System.IO;
using System.Net;

// MAME145
// MAME20101569

namespace KIRD_Killer
{
    public partial class Form1 : Form
    {
        AutoLogin autoLogin;

        int step = 1;
        int ch_no = 1;
        int cl_no = 1;
        private int timerCount = 0;
        HtmlDocument doc = null;

        string id="";
        string password="";

        string resResult = string.Empty;
        string cookie;
        bool start = true;

        string year = "";
        string trimester = "";

        public Form1()
        {
            InitializeComponent();

            DateTime dt = DateTime.Now;
            yearLabel.Text = dt.Year.ToString() + " 년도";

            year = dt.Year.ToString();

            autoLogin = new AutoLogin();

            comboBox1.SelectedIndex = 0;

            if (autoLogin.ReadRegistry(ref id, ref password))
            {
                idTxt.Text = id;
                passwordTxt.Text = password;

                if (id != "")
                {
                    checkBox1.Checked = true;
                    checkBox2.Enabled = true;
                }

                if (password != "")
                {
                    checkBox2.Enabled = true;
                    checkBox2.Checked = true;
                }
            }
            start = false;
        }

        private void getResponse(String url, string str_ch, string str_cl, string ch_no, string cl_no)
        {
            string send_message = "cmd=StudyStart&ch=" + ch_no + "&cl=" + cl_no + "&pg=" + cl_no + "&url=" + str_ch + str_cl + ".htm&edu_year=" + year + "&course_code=0001100513&course_sq=" + trimester + "&lecplan_seq=1&chapter_no=" + ch_no + "&clause_no=" + cl_no + "&ctype=lms";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.SetCookies(new Uri(url), cookie.Substring(cookie.IndexOf("JSESSIONID")));

            byte[] byteArray = Encoding.UTF8.GetBytes(send_message);

            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = byteArray.Length;
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.6; hello; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; InfoPath.2)";
            request.Accept = "*/*";
            request.Referer = "http://www.kird.re.kr/front/htma/content/wizlms/wizlms.htm?ctype=lms&edu_year=" + year + "&course_code=0001100513&course_sq=" + trimester + "&lecplan_seq=1&chapter_no=" + ch_no + "&clause_no=" + cl_no + "&lmsSvr=http://www.kird.re.kr/front/portal&scp=/front&debug=0&contentUrl=http://www.kird.re.kr/front/htma/content/0001/B000000105/00" + str_ch + "/" + str_ch + str_cl + ".htm&pgm=/00" + str_ch + "/" + str_ch + str_cl + ".htm\r\n";
            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();

            dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void sendFinish(String url, string str_ch, string str_cl, string ch_no, string cl_no)
        {
            string content = "cmd=StudyFinish&ch=" + ch_no + "&cl=" + cl_no + "&pg=" + cl_no + "&url=" + str_ch + str_cl + ".htm&edu_year="+year+"&course_code=0001100513&course_sq="+trimester+"&lecplan_seq=1&chapter_no=" + ch_no + "&clause_no=" + cl_no + "&ctype=lms\r\n";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.SetCookies(new Uri(url),  cookie.Substring(cookie.IndexOf("JSESSIONID")));

            byte[] byteArray = Encoding.UTF8.GetBytes(content);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.6; hello; Trident/5.0)";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.Referer = "http://www.kird.re.kr/front/htma/content/wizlms/wizlms.htm?ctype=lms&edu_year="+year+"&course_code=0001100513&course_sq=1&lecplan_seq="+trimester+"&chapter_no=" + ch_no + "&clause_no=" + cl_no + "&lmsSvr=http://www.kird.re.kr/front/portal&scp=/front&debug=0&contentUrl=http://www.kird.re.kr/front/htma/content/0001/B000000105/00" + str_ch + "/" + str_ch + str_cl + ".htm&pgm=/00" + str_ch + "/" + str_ch + str_cl + ".htm\r\n";

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();

            dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState.Equals(WebBrowserReadyState.Complete))
            {
                switch (step)
                {
                    case 1:
                        loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        loginOkLabel.Text = "";
                        loginOkLabel.Text = "Checking...   Please wait :)";
                        Login();
                        step++;
                        break;
                    case 2:
                        if (LoginCheck())
                        {
                            loginOkLabel.Text = "";
                            loginOkLabel.Text = "Success!";
                            groupBox2.Enabled = false;
                            cookie = webBrowser1.Document.Cookie;

                            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                            trimesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

                            comboBox1.Enabled = true;
                            killBtn.Enabled = true;
                        }
                        else
                        {
                            step = 1;
                            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                            loginOkLabel.Text = "Please check your ID and Password!";
                            return;
                        }
                        break;
                    case 3:
                        loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        killingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                       
                        if (cl_no == 9)
                        {
                            ch_no++;
                            cl_no = 0;
                        }
                        if (ch_no == 23) // 수정후 배포======================23=========================
                        {
                            step++;
                        }
                        cl_no++;
                        break;
                    case 4:
                        cl_no = 1;
                        ch_no = 1;
                        progressBar1.Enabled = false;
                        killingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        waitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        Wait();
                        break;
                    case 5:
                        progressBar2.Enabled = false;
                        waitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        finishingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        
                        if (cl_no == 9)
                        {
                            ch_no++;
                            cl_no = 0;
                        }
                        if (ch_no == 23) // 수정후 배포=======================23
                        {
                            step++;
                        }
                        cl_no++;
                        break;
                    case 6:
                        DialogResult dialogResult = MessageBox.Show("We will open KIRD.\nPlease check your syllabus.\nIf success, you have to take EXAM\n\nAnd we want to show you a new Program :)\nDo you want to see it?", "Finish!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Program.seeAd = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Program.seeAd = false;
                        }
                        Program.cookie = this.cookie;
                        Program.success = true;
                        this.Close();
                        break;
                }
            }
        }

        private void Login()
        {
            if (checkBox1.Checked == true)
            {
                autoLogin.WriteRegistry(idTxt.Text, "");
            }

            if (checkBox2.Checked == true)
            {
                autoLogin.WriteRegistry(idTxt.Text, passwordTxt.Text);
            }

            doc = webBrowser1.Document as HtmlDocument;

            try
            {
                int nOrder = 0;

                MSHTML.HTMLDocument hDoc = doc.DomDocument as MSHTML.HTMLDocument;

                foreach (MSHTML.IHTMLElement hElement in (MSHTML.IHTMLElementCollection)hDoc.body.all)
                {
                    try
                    {
                        if (hElement.getAttribute("type", 0).ToString().Trim() != "")
                        {
                            if (hElement.getAttribute("type", 0).ToString().Trim().IndexOf("text") > -1)
                            {
                                hElement.setAttribute("value", idTxt.Text);
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                foreach (MSHTML.IHTMLElement hElement in (MSHTML.IHTMLElementCollection)hDoc.body.all)
                {
                    try
                    {
                        if (hElement.getAttribute("type", 0).ToString().Trim() != "")
                        {
                            if (hElement.getAttribute("type", 0).ToString().Trim().IndexOf("password") > -1)
                            {
                                hElement.setAttribute("value", passwordTxt.Text);
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                nOrder = 0;

                foreach (MSHTML.IHTMLElement hElement in (MSHTML.IHTMLElementCollection)hDoc.body.all)
                {
                    try
                    {
                        if (hElement.getAttribute("src", 0).ToString().Trim() != "")
                        {
                            if (hElement.getAttribute("src", 0).ToString().Trim().IndexOf("images/btn/btn_login.gif") > -1)
                            {
                                if (nOrder == 0)
                                    hElement.click();
                                nOrder++;
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message + "\n" + err.Source);
            }
        }

        private bool LoginCheck()
        {
            try
            {
                MSHTML.HTMLDocument hDoc = doc.DomDocument as MSHTML.HTMLDocument;

                foreach (MSHTML.IHTMLElement hElement in (MSHTML.IHTMLElementCollection)hDoc.body.all)
                {
                    try
                    {
                        if (hElement.getAttribute("src", 0).ToString().Trim() != "")
                        {
                            if (hElement.getAttribute("src", 0).ToString().Trim().IndexOf("images/btn/btn_login.gif") > -1)
                            {
                                MessageBox.Show("ID or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                loginBut.Enabled = true;
                                return false;
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message + "\n" + err.Source);
            }

            loginOkLabel.Text = "";
            loginOkLabel.Text = "Success!";

            return true;
        }

        private void Kill()
        {
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            killingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            
            loginOkLabel.Text = "";
            loginOkLabel.Text = "Success!";
            
            cookie = webBrowser1.Document.Cookie;

            string strUrl = "http://www.kird.re.kr/front/portal/mylearn/lms/LmsCallDataProG.jsp";
            
            for (int ch_no = 1; ch_no < 23; ch_no++)
            {
                for (int cl_no = 1; cl_no < 10; cl_no++)
                {
                    string str_ch=ch_no.ToString("D2");
                    string str_cl=cl_no.ToString("D2");

                    getResponse(strUrl, str_ch, str_cl, ch_no.ToString(), cl_no.ToString());
                    
                    progressBar1.PerformStep();
                }
            }
            step = 4;

            webBrowser1.Navigate("http://www.kird.re.kr/");

            progressBar1.Value = progressBar1.Maximum;
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            loginOkLabel.Text = "";
            loginOkLabel.Text = "Checking...   Please wait :)";

            if (idTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("ID and Password is needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*DialogResult dr = MessageBox.Show("If you entered wrong Password, we can't finish the Killing!\r\nAre you sure about your password?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dr == DialogResult.Cancel)
            {
                return;
            }*/

            step = 1;
            webBrowser1.Navigate("http://www.kird.re.kr/front/portal/main/Login.jsp");
            loginBut.Enabled = false;
        }

        private void ControlSB(object sender)
        {
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            ((TextBox)sender).ScrollToCaret();
            ((TextBox)sender).Refresh();
        }

        private void progressTxt_TextChanged(object sender, EventArgs e)
        {
            ControlSB(sender);
        }

        private void Wait()
        {
            timer1.Start();
        }

        private void Finish()
        {
            string strUrl = "http://www.kird.re.kr/front/portal/mylearn/lms/LmsCallDataProG.jsp";

            for (int ch_no = 1; ch_no < 23; ch_no++)
            {
                for (int cl_no = 1; cl_no < 10; cl_no++)
                {
                    string str_ch = ch_no.ToString("D2");
                    string str_cl = cl_no.ToString("D2");

                    sendFinish(strUrl, str_ch, str_cl, ch_no.ToString(), cl_no.ToString());

                    progressBar3.PerformStep();
                }
            }
            step++;
            progressBar3.Value = progressBar3.Maximum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformStep();

            // 타이머 중지 조건
            if (++timerCount == 480) // 수정후 배포====================480
            {
                timer1.Stop();
                progressBar2.Enabled = false;
                step = 5;
                Finish();
                webBrowser1.Navigate("http://www.kird.re.kr/front/portal/main/Main.jsp");
            }
            int leftTime=480-timerCount;

            string min = (leftTime/60).ToString();
            string sec = (leftTime - (leftTime / 60) * 60).ToString();

            leftTimeLabel.Text = string.Format(min + "m " + sec + "s");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void aTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBut_Click(sender, e);
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            InjectAlertBlocker();
        }

        private void InjectAlertBlocker()
        {
            HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowser1.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            string alertBlocker = "window.alert = function () { }";
            element.text = alertBlocker;
            head.AppendChild(scriptEl);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (start == false)
            {
                if (checkBox1.Checked == true)
                {
                    autoLogin.WriteRegistry(idTxt.Text, "");

                    checkBox2.Enabled = true;
                }
                else
                {
                    autoLogin.WriteRegistry("", "");

                    checkBox2.Enabled = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (start == false)
            {
                if (checkBox2.Checked == true)
                {
                    autoLogin.WriteRegistry(idTxt.Text, passwordTxt.Text);

                    checkBox2.Enabled = true;
                }
                else
                {
                    autoLogin.WriteRegistry(idTxt.Text, "");
                }
            }
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            killBtn.Enabled = false;
            comboBox1.Enabled = false;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    trimester = "1";
                    break;
                case 1:
                    trimester = "2";
                    break;
                case 3:
                    trimester = "3";
                    break;
            }

            trimesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif,", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            System.Threading.Thread.Sleep(1000);
            Kill();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
