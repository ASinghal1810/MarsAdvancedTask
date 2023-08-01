using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.Dashboard
{
    [TestFixture]
    [Parallelizable]
    public class NotificationSelect : MarsDriver
    {
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement dashboardTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
        private IWebElement selectnotificationCheckbox => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));

       
        List<IWebElement> checkboxes => new List<IWebElement>(marsDriver.FindElements(By.XPath("//*[@type=\"checkbox\"]")));

        private IWebElement checkbox2 => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[2]/div/div/div[3]/input"));
        private IWebElement checkbox3 => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[3]/div/div/div[3]/input"));

        private IWebElement unselAll => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]"));

        public void notificationSelectUnselect(string Username, string Password)
        {
           
            //Do login
           
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            //Go to Dashboard
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
           
            dashboardTab.Click();

            //select 1st notification
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input");

            Assert.IsFalse(selectnotificationCheckbox.Selected, "Checkbox is checked, but it should be unchecked.");
            selectnotificationCheckbox.Click();
            Assert.IsTrue(selectnotificationCheckbox.Selected, "Checkbox is unchecked, but it should be checked.");
            
            //unselect 1st notification
            selectnotificationCheckbox.Click();
            Assert.IsFalse(selectnotificationCheckbox.Selected, "Checkbox is checked, but it should be unchecked.");



        }
        public void notificationSelUnselMultiple(string Username, string Password)
        {
           


            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            //Go to Dashboard
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
            
            dashboardTab.Click();
            Thread.Sleep(1000);
            bool checkboxselected = true;
            int count = checkboxes.Count();
            for (int i = 0; i < count; i++)
            {
                // Assert the state of each checkbox
                checkboxselected = checkboxes[i].Selected;
                if (checkboxselected == false)
                {
                    checkboxes[i].Click();
                }
            }


        }
        public void assertforSelect()
        {
            foreach (var checkbox in checkboxes)
            {

                Assert.IsTrue(checkbox.Selected, "Checkbox is Unchecked but should not be.");
                //Thread.Sleep(1000);
                //if (!checkbox.Selected)
                //{
                //    // Perform the action to select the checkbox (e.g., click on it)
                //    checkbox.Click();
                //}
            }
        }
        public void unSelect()
        {
            bool checkboxselected = true;
            int count = checkboxes.Count();
            for (int i = 0; i < count; i++)
            {
                // Assert the state of each checkbox
                checkboxselected = checkboxes[i].Selected;
                if (checkboxselected)
                {
                    checkboxes[i].Click();
                }
            }

        }
        public void assertforUnselect()
        {
            foreach (var checkbox in checkboxes)
            {

                Assert.IsFalse(checkbox.Selected, "Checkbox is checked but should not be.");
                //Thread.Sleep(1000);
                //if (!checkbox.Selected)
                //{
                //    // Perform the action to select the checkbox (e.g., click on it)
                //    checkbox.Click();
                //}
            }
        }



        public void unselAllNotification(string Username, string Password)
        {
           

            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            //Go to Dashboard
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
            
            dashboardTab.Click();

            //select 1st notification
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input");

            Assert.IsFalse(selectnotificationCheckbox.Selected, "Checkbox is checked, but it should be unchecked.");
            selectnotificationCheckbox.Click();
            Assert.IsTrue(selectnotificationCheckbox.Selected, "Checkbox is unchecked, but it should be checked.");



            //select 2nd notification
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[2]/div/div/div[3]/input");
            
            Assert.IsFalse(checkbox2.Selected, "Checkbox is checked, but it should be unchecked.");
            checkbox2.Click();
            Assert.IsTrue(checkbox2.Selected, "Checkbox is unchecked, but it should be checked.");
            

            //select 3rd notification
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[3]/div/div/div[3]/input");

            Assert.IsFalse(checkbox3.Selected, "Checkbox is checked, but it should be unchecked.");
            checkbox3.Click();
            Assert.IsTrue(checkbox3.Selected, "Checkbox is unchecked, but it should be checked.");
          

            //click on unselect button
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]");
            unselAll.Click();

            Assert.IsFalse(selectnotificationCheckbox.Selected, "Checkbox is checked, but it should be unchecked.");

            Assert.IsFalse(checkbox2.Selected, "Checkbox is checked, but it should be unchecked.");

            Assert.IsFalse(checkbox3.Selected, "Checkbox is checked, but it should be unchecked.");
        }

    }
}

