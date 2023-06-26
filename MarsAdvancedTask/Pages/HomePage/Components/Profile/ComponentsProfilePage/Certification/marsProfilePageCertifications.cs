using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    public class marsProfilePageCertifications : MarsDriver
    {
        private IWebElement MarsProfilePageCertificationsTab => marsDriver.FindElement(By.XPath("//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]"));
        private IWebElement MarsProfilePageCertificationsAddNewButton => marsDriver.FindElement(By.XPath("//div[@class='ui teal button' and contains(text(),'Add New')]"));
        private IWebElement MarsProfilePageCertificationsTabCertificateOrAward => marsDriver.FindElement(By.XPath("//*[@class=\"certification-award capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationFrom => marsDriver.FindElement(By.XPath("//*[@class=\"received-from capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationYear => marsDriver.FindElement(By.XPath("//*[@name=\"certificationYear\"]"));
        private IWebElement MarsProfilePageCertificationsTabAddButton => marsDriver.FindElement(By.XPath("//*[@value=\"Add\"]"));
        private IWebElement MarsProfilePageCertificationsTabCancelButton => marsDriver.FindElement(By.XPath("//*[@value=\"Cancel\"]"));
        private IWebElement MarsProfilePageCertificationsTabEditButton => marsDriver.FindElement(By.XPath("//*/tbody/tr/td[4]/span[1]/i"));
        private IWebElement MarsProfilePageCertificationsTabDeleteButton => marsDriver.FindElement(By.XPath("//*/tbody/tr/td[4]/span[2]/i"));

        public void marsProfilePageCertificationsAdd(string certificate, string from, string year)
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]");
            MarsProfilePageCertificationsTab.Click();
            Thread.Sleep(3000);
            MarsProfilePageCertificationsAddNewButton.Click();
            Thread.Sleep(3000);
            MarsProfilePageCertificationsTabCertificateOrAward.SendKeys(certificate);
            MarsProfilePageCertificationsTabCertificationFrom.SendKeys(from);
            MarsProfilePageCertificationsTabCertificationYear.SendKeys(year);
            MarsProfilePageCertificationsTabAddButton.Click();
        }
        public void marsProfilePageCertificationsEdit()
        {
        }
        public void marsProfilePageCertificationsDelete()
        {
        }

    }
}
