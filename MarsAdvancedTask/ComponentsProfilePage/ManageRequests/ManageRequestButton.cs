using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ManageRequests
{
    public class ManageRequestButton:MarsDriver
    {
        private IWebElement receivedReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
        private IWebElement manageReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
        public void manageRequestTab()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");

            manageReqTab.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");

            receivedReqTab.Click();
        }
    }
}
