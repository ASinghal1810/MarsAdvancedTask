using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage
{
    public class MarsHomePage: MarsDriver
    {
        private IWebElement mListing => marsDriver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[3]"));
        private IWebElement dashboard => marsDriver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[1]"));


        public void manageListingComponentButton()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"ui eight item menu\"]/a[3]");
            mListing.Click();

        }
        public void manageDashboardComponentButton() 
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"ui eight item menu\"]/a[1]");
            dashboard.Click();
        }
    }
}
