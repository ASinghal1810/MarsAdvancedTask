using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ProfilePageComponents
{
    public class MarsProfileUserDetails : MarsDriver
    {
        // User Details
        private IWebElement availabilityPenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement availabilityDropdownList => marsDriver.FindElement(By.Name("availabiltyType"));
        private IWebElement fullTimeOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
        private IWebElement partTimeOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
        private IWebElement hoursPenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement hoursDropdownList => marsDriver.FindElement(By.Name("availabiltyHour"));
        private IWebElement moreOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
        private IWebElement asNeedOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
        private IWebElement earnTargetPenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private IWebElement earnTargetDropdownList => marsDriver.FindElement(By.Name("availabiltyTarget"));
        private IWebElement moreThanOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
        private IWebElement lessThanOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]"));
        private IWebElement updateSuccessfullyMessage => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));

        public void addUserDetails()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
            // Identify Availablity and select Full time option
            availabilityPenIcon.Click();
            availabilityDropdownList.Click();
            fullTimeOption.Click();

            // Identify Hours and select "More than 30hours a week" option
            hoursPenIcon.Click();
            hoursDropdownList.Click();
            moreOption.Click();

            // Identify EarnTaget and select "More than $1000 per month"
            earnTargetPenIcon.Click();
            earnTargetDropdownList.Click();
            moreThanOption.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 5, "/html/body/div[1]/div");
            if (updateSuccessfullyMessage.Text == "Availability updated")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }

        public void editUserDetails()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
            // Identify Availablity and select Part time option
            availabilityPenIcon.Click();
            availabilityDropdownList.Click();
            partTimeOption.Click();

            // Identify Hours and select "As need" option
            hoursPenIcon.Click();
            hoursDropdownList.Click();
            asNeedOption.Click();

            // Identify EarnTaget and select "More than $1000 per month"
            earnTargetPenIcon.Click();
            earnTargetDropdownList.Click();
            lessThanOption.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 5, "/html/body/div[1]/div");
            if (updateSuccessfullyMessage.Text == "Availability updated")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }
    }

}

