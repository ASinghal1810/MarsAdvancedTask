using AutoIt;
using AutoItX3Lib;
using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ShareSkillComponents
{
    public class MarsShareSkills : MarsDriver
    {
        private IWebElement titleTextBox => marsDriver.FindElement(By.Name("title"));
        private IWebElement descriptionTextArea => marsDriver.FindElement(By.Name("description"));
        private IWebElement categoryDropdownList => marsDriver.FindElement(By.Name("categoryId"));
        private IWebElement musicOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]"));
        private IWebElement subcategoryDropdownList => marsDriver.FindElement(By.Name("subcategoryId"));
        private IWebElement voiceOverOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
        private IWebElement firstTagsTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement secondTagsTextBox =>marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement oneoffOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        private IWebElement onsiteOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private IWebElement startDate => marsDriver.FindElement(By.Name("startDate"));
        private IWebElement endDate => marsDriver.FindElement(By.Name("endDate"));
        private IWebElement mondayOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        private IWebElement startTime => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        private IWebElement endTime => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
        private IWebElement tagTextbox => marsDriver.FindElement(By.XPath("//input[@class=\"ReactTags__tagInputField\"]"));
        private IWebElement skillExchangeTagTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement saveButton => marsDriver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));

        public void ShareSkillAction(string title, string description, string skillTag1, string skillTag2, string listingStartDate, string listingEndDate, string listingStartTime, string listingEndTime, string skillExchangeTag1)
        {
            MarsWait.MarsWaitToBeVisible("Name", 5, "title");
            // Identify the Title textbox and enter vaild title
            titleTextBox.SendKeys(title);

            // Identify the Description textarea and enter description
            descriptionTextArea.SendKeys(description);

            // Identify the Category dropdown list and select Music & Audio
            categoryDropdownList.Click();
            musicOption.Click();

            // Identify the Category dropdown list and select the Subcategory
            subcategoryDropdownList.Click();
            // Select the Voice over option
            voiceOverOption.Click();

            // Identify the Tgas input a tag
            firstTagsTextBox.SendKeys(skillTag1);
            firstTagsTextBox.SendKeys(Keys.Enter);
            secondTagsTextBox.SendKeys(skillTag2);
            secondTagsTextBox.SendKeys(Keys.Enter);


            // Identify the Start date and End date then input value
            startDate.SendKeys(listingStartDate);
            endDate.SendKeys(listingEndDate);

            // Identify the Monday checkbox and click on it
            mondayOption.Click();

            // Identify the Monday start time box and end time box then input value
            startTime.SendKeys(listingStartTime);
            endTime.SendKeys(listingEndTime);

            // Identify the Skill-Exchange and input a tag
            skillExchangeTagTextBox.SendKeys(skillExchangeTag1);
            skillExchangeTagTextBox.SendKeys(Keys.Enter);

            // Identify the Work Samples and click the plus button to upload photo
            workSamples.Click();

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            autoIt.Send("G:\\AdvancedTask\\AdvancedTask(Eddie)\\MarsAdvancedTask\\MarsAdvancedTask\\DataFiles\\TestImage\\JazzImage.jpg");
            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");


            // Identify the Save button and click on it
            saveButton.Click();
        }
    }
}
