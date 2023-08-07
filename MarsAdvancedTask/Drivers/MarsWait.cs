
using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Drivers
{
 
    public class MarsWait: MarsDriver
    {
        public static void MarsWaitToBeClickable(string LocatorType, int seconds, string LocatorValue)
        {
            var wait = new WebDriverWait(marsDriver, new TimeSpan(0, 0, seconds));
            if (LocatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }
            else if (LocatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(LocatorValue)));

            }
            else if (LocatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(LocatorValue)));

            }
            else if (LocatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(LocatorValue)));

            }
        }
        public static void MarsWaitToBeVisible(string LocatorType, int seconds, string LocatorValue)
        {
            var wait = new WebDriverWait(marsDriver, new TimeSpan(0, 0, seconds));

            if (LocatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(LocatorValue)));
            }
            if (LocatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(LocatorValue)));
            }
            if (LocatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(LocatorValue)));
            }
            else if (LocatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(LocatorValue)));

            }
        }
            public static bool IsElementVisible(string locatorType, int seconds, string locatorValue)
            {
                try
                {
                    var wait = new WebDriverWait(marsDriver, TimeSpan.FromSeconds(seconds));
                    if (locatorType == "XPath")
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
                    }
                    else if (locatorType == "Id")
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
                    }
                    else if (locatorType == "CssSelector")
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
                    }
                    else if (locatorType == "Name")
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
                    }
                    return true; // Return true if the element is visible
                }
                catch (NoSuchElementException)
                {
                    return false; // Return false if the element is not found
                }
                catch (TimeoutException)
                {
                    return false; // Return false if the element is not visible within the specified timeout
                }
            }
    }
}