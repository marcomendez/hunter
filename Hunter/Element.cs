using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyloggerExample
{
    public static class CreateElement
    {
        public static string GetControlName(this string resouse)
        {
            return FindTagValue(resouse, "Name");
        }
        public static string GetControlAutomationId(this string resouse)
        {
            return FindTagValue(resouse, "AutomationId");
        }

        public static string GetControlType(this string resouse)
        {
            try
            {
                string locatorType = string.Empty;
                string control = FindTagValue(resouse, "LocalizedControlType").ToUpper();
                LoadDictionary().TryGetValue(control, out locatorType);
                return locatorType; 
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string BuildElement(string resources)
        {
            string controlName = resources.GetControlName();
            string controlType = resources.GetControlType();
            string controlAutomationId = resources.GetControlAutomationId();
            string controlLocatorType = GetLocatorType(controlName, ref controlAutomationId);

            StringBuilder element = new StringBuilder();
            element.AppendLine($"[Element(\"{controlName}\", ElementType.{controlType})]");
            element.AppendLine($"[Locator(PlatformType.Desktop, LocatorType.{controlLocatorType}, \"{controlAutomationId}\")]");
            element.Append($"public I{controlType} {controlName.Replace(" ", string.Empty)}").Append("{ get; }");
            element.AppendLine("\n").AppendLine("\n");
            return element.ToString();
        }

        private static string GetLocatorType(string controlName, ref string controlAutomationId)
        {
            string controlLocatorType;
            if (string.IsNullOrEmpty(controlAutomationId))
            {
                controlAutomationId = controlName;
                controlLocatorType = "Name";
                if (string.IsNullOrEmpty(controlName))
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

        private static Dictionary<string, string> LoadDictionary()
        {
            Dictionary<string, string> locators = new Dictionary<string, string>();
            string[] allLocators = File.ReadAllText("locators.txt", Encoding.UTF8).Split(';');
            string[] value;
            foreach (var locator in allLocators)
            {
                value = locator.Split(':');
                locators.Add(value[0].CleanSpaces(), value[1].CleanSpaces());
            }
            return locators;
        }
        private static string FindTagValue(string resouse, string value)
        {
            var match = Regex.Match(resouse, $"{value}:(.*)");
            string control = match.Groups[1].Value.CleanSpaces();
            return control;
        }

        private static string CleanSpaces(this string cad)
        {
            return cad.TrimEnd().TrimStart().Replace("\"", string.Empty);
        }
    }
}
