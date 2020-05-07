using Hunter;
using KeyloggerExample;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Develop by Marco Mendez
/// </summary>
namespace WindowsFormsApplication1
{
    public partial class klgForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        Process app = null;
        IntPtr h;
        string keyWord = ConfigurationManager.AppSettings["KeyWord"];

        public klgForm()
        {
            InitializeComponent();
        }

        private void cbKeyloggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            keylogger1.Enabled = cbKeyloggerEnabled.Checked ? true : false;
        }

        private void klgForm_Load(object sender, EventArgs e)
        {
            string inspect = ConfigurationManager.AppSettings["Inspect"];
            app = Process.Start(inspect);
            Thread.Sleep(2000);
            app.WaitForInputIdle();
            h = app.MainWindowHandle;
            SetForegroundWindow(h);
        }

        private void keylogger1_VKCodeAsStringDown(string value, bool isChar)
        {
            if (value.ToUpper() == keyWord.ToUpper())
            {
                txtResources.Clear();
                SetForegroundWindow(h);
                SendKeys.Send("^+4");
                txtResources.Paste();
                txtElements.Text += CreateElement.BuildElement(txtResources.Text.ToString());
                txtAppName.Text = CreateElement.GetControlName(txtResources.Text.ToString());
            }
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            txtElements.Clear();
            txtResources.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinApp appXML = new WinApp();
            appXML.SwitchToWindow(txtAppName.Text);

            txtResources.Clear();
            txtResources.Text = appXML.GetPageSource();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void klgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                app.Kill();
            }
            catch { }
        }
    }
}
