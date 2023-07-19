using MarsAdvancedTask.Driver;
using OpenQA.Selenium;

namespace MarsAdvancedTask.Pages
{
    public class MarsManageListingsPage : MarsDriver
    {
        private IWebElement manageListingsTag => marsDriver.FindElement(By.XPath("//*[@href=\"/Home/ListingManagement\"]"));

        public void goToManageListingsPage()
        {
            manageListingsTag.Click();
        }

    }
}
