using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.SearchSkillsComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{ 
    public class MarsHomePage : MarsDriver
    {
        private IWebElement marsLogo => marsDriver.FindElement(By.XPath("//a[@href=\"/\"]"));

        public void goToHomePage()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//a[@href=\"/\"]");
            marsLogo.Click();
        }
    }
}
