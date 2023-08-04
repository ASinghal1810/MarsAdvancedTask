using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.Notifications
{
    public class DashboardButton:MarsDriver
    {
        private IWebElement dashboardButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
        public void dashboardTab()
        {
            //Go to Dashboard
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");

            dashboardButton.Click();
        }
    }
}
