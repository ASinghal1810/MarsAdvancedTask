using MarsAdvancedTask.Driver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ManageListingsComponents
{
    public class MarsManageListings : MarsDriver
    {
        private IWebElement manageListingsTag => marsDriver.FindElement(By.XPath("//*[@href=\"/Home/ListingManagement\"]"));
        private IWebElement titleName => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
        private IWebElement deleteFirstListing => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"));
        private IWebElement deleteYesOption => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        private IWebElement deleteNoOption => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));

        public void marsDeleteListing()
        {
            manageListingsTag.Click();

            if(titleName.Text == "Jazz Club")
            {
                deleteFirstListing.Click();
                deleteYesOption.Click();
            }
            else
            {
                Assert.Fail("Actual listing and expected listing do not match!");
            }
        }
    }
}
