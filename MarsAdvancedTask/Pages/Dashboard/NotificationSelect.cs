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

        List<IWebElement> checkboxes = new List<IWebElement>(marsDriver.FindElements(By.CssSelector("input[type='checkbox']")));

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
            

            //unselect 1st notification
            selectnotificationCheckbox.Click();
            Assert.IsFalse(selectnotificationCheckbox.Selected, "Checkbox is checked, but it should be unchecked.");
           
            //unselect 2nd notification
            checkbox2.Click();
            Assert.IsFalse(checkbox2.Selected, "Checkbox is checked, but it should be unchecked.");
            
            //unselect 3rd notification
            checkbox3.Click();
            Assert.IsFalse(checkbox3.Selected, "Checkbox is checked, but it should be unchecked.");
            



            //// Iterate through the checkbox elements again and assert their states
            //bool checkboxselected = true;
            //int count = checkboxes.Count();
            //for (int i =0;i<count;i++)
            //{
            //    // Assert the state of each checkbox
            //    checkboxselected = checkboxes[i].Selected;
            //   // Assert.AreEqual(expectedState, checkbox.Selected, "Checkbox state is incorrect.");

            //   // index++;
            //    // Break the loop after asserting all 5 checkboxes
            //   // if (index == 5)
            //     //   break;
            //     if(checkboxselected)
            //    {
            //        checkboxes[i].Click();
            //    }
            //}
        }

        ////System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> checkboxes = marsDriver.FindElements(By.CssSelector("input[type='checkbox']"));
        //WebDriverWait wait = new WebDriverWait(marsDriver, TimeSpan.FromSeconds(10));
        //// Iterate through each checkbox and select them
        //foreach (var checkbox in checkboxes)
        //{
        //    wait.Until(ExpectedConditions.ElementToBeClickable(checkbox));
        //    // MarsWait.MarsWaitToBeVisible("XPath", 10, "input[type='checkbox']");
        //    Thread.Sleep(1000);
        //    if (!checkbox.Selected)
        //    {
        //        // Perform the action to select the checkbox (e.g., click on it)
        //        checkbox.Click();
        //    }

        //}



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

