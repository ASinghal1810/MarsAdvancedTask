using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.MarsProfilePages
{
    public class MarsProfileEducation : MarsDriver
    {
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
