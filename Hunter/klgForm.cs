using KeyloggerExample;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class klgForm : Form
    {
        public klgForm()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        Process app = null;
        IntPtr h;

        private void cbKeyloggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeyloggerEnabled.Checked)
            {
                keylogger1.Enabled = true;
            }
            else
            {
                keylogger1.Enabled = false;
            }
        }

        private void klgForm_Load(object sender, EventArgs e)
        {
            string inspect = File.ReadAllText("App.txt", Encoding.UTF8);
            app = Process.Start(inspect);
            Thread.Sleep(2000);
            app.WaitForInputIdle();
            h = app.MainWindowHandle;
            SetForegroundWindow(h);
        }

        private void keylogger1_VKCodeAsStringDown(string value, bool isChar)
        {
            if (value == "s")
            {
                resourcesTxt.Clear();
                SetForegroundWindow(h);
                SendKeys.Send("^+4");
                resourcesTxt.Paste();
                BuildElement();
            }
        }

        private void BuildElement()
        {
            string controlName = resourcesTxt.Text.ToString().GetControlName();
            string controlType = resourcesTxt.Text.ToString().GetControlType();
            string controlAutomationId = resourcesTxt.Text.ToString().GetControlAutomationId();
            string controlLocatorType = "...";
            controlLocatorType = GetLocatorType(controlName, ref controlAutomationId);

            StringBuilder element = new StringBuilder();
            element.AppendLine($"[Element(\"{controlName}\", ElementType.{controlType})]");
            element.AppendLine($"[Locator(PlatformType.Desktop, LocatorType.{controlLocatorType}, \"{controlAutomationId}\")]");
            element.Append($"public I{controlType} {controlName.Replace(" ", string.Empty)}").Append("{ get; }");
            element.AppendLine("\n").AppendLine("\n");
            showElementsTxt.Text += element.ToString();

        }

        private static string GetLocatorType(string controlName, ref string controlAutomationId)
        {
            string controlLocatorType;
            if (string.IsNullOrEmpty(controlAutomationId))
            {
                controlAutomationId = controlName;
                controlLocatorType = "Name";
                if(string.IsNullOrEmpty(controlName))
                {
                    controlLocatorType = "...";
                }
            }
            else
            {
                controlLocatorType = "AccessibilityId";
            }

            return controlLocatorType;
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            showElementsTxt.Clear();
            resourcesTxt.Clear();
        }

        private void klgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                app.Kill();
            }
            catch { }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
