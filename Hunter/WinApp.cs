using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;

namespace Hunter
{
    public class WinApp
    {
        private WindowsDriver<WindowsElement> WinAppDriver;
        private AppiumOptions _winAppCapabilities;
        private TimeSpan _explicitWait;
        private TimeSpan _implicitWait;
        private Uri _driverUri;

        public WinApp()
        {
            _implicitWait = TimeSpan.FromSeconds(20);
            _explicitWait = TimeSpan.FromSeconds(20);
            string winPort = ConfigurationManager.AppSettings["WinAppDriver"];
            _driverUri = new Uri(winPort);
        }

        public void SwitchToWindow(string windowTitle)
        {
            string windowHandle = GetWindowHandle(windowTitle);
            SwitchToWindowByWindowHandle(windowHandle);
        }

        public string GetPageSource()
        {
            return WinAppDriver.PageSource;
        }

        private string GetWindowHandle(string windowTitle)
        {
            string windowHandle = GetWindowHandleByWindowTitle(windowTitle);
            return windowHandle;
        }

        private void SwitchToWindowByWindowHandle(string windowHandle)
        {
            _winAppCapabilities = new AppiumOptions();
            _winAppCapabilities.AddAdditionalCapability("platformName", "Windows");
            _winAppCapabilities.AddAdditionalCapability("appTopLevelWindow", windowHandle);
            WinAppDriver = new WindowsDriver<WindowsElement>(_driverUri, _winAppCapabilities);
            WinAppDriver.Manage().Timeouts().ImplicitWait = _implicitWait;
        }

        private string GetWindowHandleByWindowTitle(string windowTitle)
        {
            var process = Process.GetProcesses().Where(p => p.MainWindowTitle.Contains(windowTitle)).FirstOrDefault();
            return process != null ? process.MainWindowHandle.ToString("X4") : string.Empty;
        }
    }
}
