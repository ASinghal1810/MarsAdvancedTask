using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill
{
    public class AssertNotify:MarsDriver
    {
        private static IWebElement notiText => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));

        public string assertNotification()
        {
            MarsWait.MarsWaitToBeVisible("XPath", 3, "/html/body/div[1]/div");

            return notiText.Text;

           
        }
    }
}
