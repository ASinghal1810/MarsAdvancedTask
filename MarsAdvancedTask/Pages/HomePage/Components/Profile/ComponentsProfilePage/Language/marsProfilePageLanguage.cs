using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Language
{
    public class marsProfilePageLanguage : MarsDriver
    {
        private IWebElement MarsProfilePageLanguagesTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"first\"]"));
        private IWebElement MarsProfilePageLanguagesAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement MarsProfilePageLanguagesAddLanguage => marsDriver.FindElement(By.Name("name"));
        private IWebElement MarsProfilePageLanguagesSelectLanguageLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageLanguagesAddButton => marsDriver.FindElement(By.XPath("//*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"button\"]"));
        private IWebElement MarsProfilePageLanguagesCancelButton => marsDriver.FindElement(By.XPath("///*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"cancel\"]"));
        private IWebElement MarsProfilePageLanguagesEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private IWebElement MarsProfilePageLanguagesDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

        public void marsProfilePageLanguageAdd()
        {
        }
        public void marsProfilePageLanguageEdit()
        {
        }
        public void marsProfilePageLanguageDelete()
        {
        }



    }
}
