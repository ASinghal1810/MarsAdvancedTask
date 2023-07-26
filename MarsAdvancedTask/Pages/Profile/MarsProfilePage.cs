using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using NUnit.Framework;


using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.Profile
{

    public class MarsProfilePage : MarsDriver
    {
        //marsProfilePageCertifications marsProPgCertObj = new marsProfilePageCertifications();
        MarsMasterPage marsMstrPgObj = new MarsMasterPage();
        //  private int i;

        public void MarsProfilePageAddNewCertification(int key)
        {
            // MarsExcelLib.MarsExcelLibPopulateInCollection(testDataPath, "Certifications");
            //marsProPgCertObj.marsProfilePageCertificationsAdd(MarsExcelLib.MarsExcelLibReadData(i, "Certificate"), MarsExcelLib.MarsExcelLibReadData(i, "From"), MarsExcelLib.MarsExcelLibReadData(i, "Year"));

        }


        // User Details
        private IWebElement availability => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement fullTimeOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
        private IWebElement hours => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement moreOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
        private IWebElement erTarget => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private IWebElement moreThanOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));

        // Languages Action
        private IWebElement languagesTag => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement languagesAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextBox => marsDriver.FindElement(By.Name("name"));
        private IWebElement languageLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement basicOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement languageAddButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        // Skills Action
        private IWebElement skillsTag => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement skillsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement skillTextBox => marsDriver.FindElement(By.Name("name"));
        private IWebElement skillLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement intermediateOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement skillAddButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        // Education Action
        private IWebElement educationTag => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private IWebElement educationAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private IWebElement universityNameTextBox => marsDriver.FindElement(By.Name("instituteName"));
        private IWebElement countryDropDown => marsDriver.FindElement(By.Name("country"));
        private IWebElement nzOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
        private IWebElement titleDropDown => marsDriver.FindElement(By.Name("title"));
        private IWebElement bfaOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[5]"));
        private IWebElement degreeTextBox => marsDriver.FindElement(By.Name("degree"));
        private IWebElement yearOfGraduatDropdown => marsDriver.FindElement(By.Name("yearOfGraduation"));
        private IWebElement select2020Option => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]"));
        private IWebElement educationAddButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        public void UserDetails()
        {
            // Identify Availablity and select Full time option
            availability.Click();
            fullTimeOption.Click();
            // Identify Hours and select "More than 30hours a week" option
            hours.Click();
            moreOption.Click();
            // Identify EarnTaget and select "More than $1000 per month"
            erTarget.Click();
            moreThanOption.Click();
        }

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

        public void SkillsAction()
        {
            // Identify the Skill tag and click on it
            skillsTag.Click();
            // Idenfity the Add New Button and click on it
            skillsAddNewButton.Click();
            // Fill up the skill form
            skillTextBox.SendKeys("MusicSince");
            // Select the Intermediate option
            skillLevel.Click();
            intermediateOption.Click();
            // Identify the add button and click on it
            skillAddButton.Click();
        }

        public void EducationAction()
        {
            // Identify the Education tag and click on it
            educationTag.Click();
            // Identify the Add New button and click on it
            educationAddNewButton.Click();
            // Write university name in the textbox
            universityNameTextBox.SendKeys("USQ");
            // Select Country of College, and selete New Zealand option
            countryDropDown.Click();
            nzOption.Click();
            // Select Title of education, select BFA optiion
            titleDropDown.Click();
            bfaOption.Click();
            // Identify Degree textbox and write degree
            degreeTextBox.SendKeys("Master");
            // Identify Year of graduat dropdown list and select 2020 option
            yearOfGraduatDropdown.Click();
            select2020Option.Click();
            // Identify the add button and click on it
            educationAddButton.Click();
        }

    }


}
