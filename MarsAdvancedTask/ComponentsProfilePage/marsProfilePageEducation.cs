using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage
{
    public class marsProfilePageEducation:MarsDriver
    {
        private IWebElement MarsProfilePageEducationTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"second\"]"));
        private IWebElement MarsProfilePageEducationAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement MarsProfilePagEducationAddCollegeName => marsDriver.FindElement(By.Name("name"));
        private IWebElement MarsProfilePageEducationSelectUniversity => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageEducationSelectTitle => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageEducationDegree => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageEducationSelectYear => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageEducationAddButton => marsDriver.FindElement(By.XPath("//*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"button\"]"));
        private IWebElement MarsProfilePageEducationCancelButton => marsDriver.FindElement(By.XPath("///*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"cancel\"]"));
        private IWebElement MarsProfilePageEducationEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private IWebElement MarsProfilePageEducationDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

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
