using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KIRD_Killer
{
    public partial class BrowserForm : Form
    {
        int clickedTabIndex = 0;
        List<ExtendedWebBrowser> browsers;

        public BrowserForm(string url)
        {
            InitializeComponent();

            extendedWebBrowser1.Navigate(url);

            InitializeBrowserEvents(extendedWebBrowser1);

            tabControl.ContextMenuStrip = closeMenuStrip;

            browsers = new List<ExtendedWebBrowser>();
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ExtendedWebBrowser web=(ExtendedWebBrowser)sender;

            if (web.CanGoBack)
            {
                backBtn.Enabled = true;
            }
            else
            {
                backBtn.Enabled = false;
            }
            if (web.CanGoForward)
            {
                nextBtn.Enabled = true;
            }
            else
            {
                nextBtn.Enabled = false;
            }

            currentUrlLabel.Text = e.Url.ToString();

            ((TabPage)(web.Parent)).Text = web.DocumentTitle;
        }

        private void browser_NewWindow(object sender, CancelEventArgs e)
        {
            // e.Cancel = true;
        }

        private void currentUrlLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExtendedWebBrowser ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
                ex.Navigate(currentUrlLabel.Text);
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                currentUrlLabel.SelectAll();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ExtendedWebBrowser ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
            ex.GoForward();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ExtendedWebBrowser ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
            ex.GoBack();
        }

        private void InitializeBrowserEvents(ExtendedWebBrowser SourceBrowser)
        {
            SourceBrowser.ScriptErrorsSuppressed = true;

            SourceBrowser.NewWindow2 += new EventHandler<NewWindow2EventArgs>(SourceBrowser_NewWindow2);
            SourceBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
        }

        void SourceBrowser_NewWindow2(object sender, NewWindow2EventArgs e)
        {
            TabPage NewTabPage = new TabPage();

            ExtendedWebBrowser NewTabBrowser = new ExtendedWebBrowser()
            {
                Parent = NewTabPage,
                Dock = DockStyle.Fill,
                Tag = NewTabPage
            };

            e.PPDisp = NewTabBrowser.Application;
            InitializeBrowserEvents(NewTabBrowser);

            tabControl.TabPages.Add(NewTabPage);
            tabControl.SelectedTab = NewTabPage;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtendedWebBrowser ex;

            if (tabControl.SelectedTab == null)
            {
                this.Visible = false;
                return;
            }
            else
            {
                ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
            }

            if (ex.Url == null)
                currentUrlLabel.Text = "";
            else
                currentUrlLabel.Text = ex.Url.ToString();

            if (ex.CanGoBack)
            {
                backBtn.Enabled = true;
            }
            else
            {
                backBtn.Enabled = false;
            }
            if (ex.CanGoForward)
            {
                nextBtn.Enabled = true;
            }
            else
            {
                nextBtn.Enabled = false;
            }
        }

        private void portalBtn_Click(object sender, EventArgs e)
        {
            TabPage NewTabPage = new TabPage();

            ExtendedWebBrowser NewTabBrowser = new ExtendedWebBrowser()
            {
                Parent = NewTabPage,
                Dock = DockStyle.Fill,
                Tag = NewTabPage
            };

            NewTabBrowser.Navigate("http://portal.unist.ac.kr/EP/web/portal/jsp/EP_Default1.jsp");
            InitializeBrowserEvents(NewTabBrowser);

            tabControl.TabPages.Add(NewTabPage);
            tabControl.SelectedTab = NewTabPage;

            // ExtendedWebBrowser ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
            // ex.Navigate("http://portal.unist.ac.kr/EP/web/portal/jsp/EP_Default1.jsp");
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // iterate through all the tab pages
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    Rectangle r = tabControl.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        clickedTabIndex = i;
                    }
                }
            }
        }

        private void 닫기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(clickedTabIndex);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExtendedWebBrowser ex = (ExtendedWebBrowser)(tabControl.SelectedTab.Controls[0]);
            ex.Refresh();
        }
    }
}
