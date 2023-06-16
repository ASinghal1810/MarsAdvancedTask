using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using RazorEngine;
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
        private IWebElement languagesAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextBox => marsDriver.FindElement(By.Name("name"));
        private IWebElement languageLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement basicOption => marsDriver.FindElement(By.XPath("//option[@value=\"Basic\"]"));
        private IWebElement fluentOption => marsDriver.FindElement(By.XPath("//option[@value=\"Fluent\"]"));
        private IWebElement conversationalOption => marsDriver.FindElement(By.XPath("//option[@value=\"Conversational\"]"));
        private IWebElement nativeOption => marsDriver.FindElement(By.XPath("//option[@value=\"Native/Bilingual\"]"));
        private IWebElement languageAddButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement firstLanguagePenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private IWebElement secondLanguagePenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
        private IWebElement firstLanguageDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        private IWebElement secondLanguageDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
        private IWebElement languageUpdateButton => marsDriver.FindElement(By.XPath("//input[@value=\"Update\"]"));
        private IWebElement languageMessage => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));



        public void marsProfileJumpToLanguageTag()
        {
            languagesTag.Click();
        }


        public void marsProfileLanguageAdd()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileLanguage language1 = user.languages.ElementAt(0);
            ProfileLanguage language2 = user.languages.ElementAt(1);

            // Identify the Add New button and click on it
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            languagesAddNewButton.Click();

            // Add first language (English)
            languageTextBox.SendKeys(language1.language);
            languageLevel.Click();
            basicOption.Click();
            languageAddButton.Click();
         
            
            // Add second language (Chinese)
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            languagesAddNewButton.Click();
            languageTextBox.SendKeys(language2.language);
            languageLevel.Click();
            fluentOption.Click();

            // Click the add button after fill up the form
            languageAddButton.Click();
        }

        public void marsProfileLanguageEdit()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            ProfileLanguage language3 = user.languages.ElementAt(2);
            ProfileLanguage language4 = user.languages.ElementAt(3);

            // Edited first language (Japanese)
            firstLanguagePenIcon.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(language3.language);
            languageLevel.Click();
            nativeOption.Click();
            languageUpdateButton.Click();

            // Edited second language
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i");
            secondLanguagePenIcon.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(language4.language);
            languageLevel.Click();
            conversationalOption.Click();
            languageUpdateButton.Click();
        }

        public void marsProfileLanguageDelete()
        {
            firstLanguageDeleteButton.Click();
            secondLanguageDeleteButton.Click();
        }
    }
}


