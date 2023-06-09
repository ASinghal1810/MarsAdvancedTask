using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ProfilePageComponents
{
    public class MarsProfileLanguages : MarsDriver
    {
        // Languages Action
        private IWebElement languagesTag => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement languagesAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextBox => marsDriver.FindElement(By.Name("name"));
        private IWebElement languageLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement basicOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement languageAddButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        public void LanguagesAction()
        {
            // Identify the Language tag and click on it
            languagesTag.Click();
            // Identify the Add New button and click on it
            languagesAddNewButton.Click();
            // fill up the language form
            languageTextBox.SendKeys("English");
            // Select the Basic option
            languageLevel.Click();
            basicOption.Click();
            // Click the add button after fill up the form
            languageAddButton.Click();
        }
    }
}


