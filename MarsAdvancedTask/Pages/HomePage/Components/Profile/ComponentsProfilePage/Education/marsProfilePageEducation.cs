using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Education
{
    public class marsProfilePageCertification : MarsDriver
    {
        private IWebElement MarsProfilePageCertificationTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"fourth\"]"));
        private IWebElement MarsProfilePageEducationAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement MarsProfilePagEducationAddCertificateOrAwardName => marsDriver.FindElement(By.Name("certificationName"));
        private IWebElement MarsProfilePageEducationCertifiedFrom => marsDriver.FindElement(By.Name("certificationFrom"));
        private IWebElement MarsProfilePageEducationYear => marsDriver.FindElement(By.Name("certificationYear"));
        private IWebElement MarsProfilePageEducationAddButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        private IWebElement MarsProfilePageEducationCancelButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[2]"));
        private IWebElement MarsProfilePageEducationEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
                                                                                                   
        private IWebElement MarsProfilePageEducationDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i"));

        public void marsProfilePageEducationAdd()
        {

        }
        public void marsProfilePageEducationEdit()
        {
        }
        public void marsProfilePageEducationDelete()
        {
        }

    }
}
