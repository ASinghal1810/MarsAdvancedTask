using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.NotificationComponents
{
    public class MarsNotification : MarsDriver
    {
        private IWebElement notificationDropDownList => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div"));
        private IWebElement seeAllOption => marsDriver.FindElement(By.XPath("//a[@href=\"/Account/Dashboard\"]"));
        private IWebElement firstNoticCheckBox => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
        private IWebElement markAsReadTag => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]"));
        private IWebElement successfulMessage => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));



        public void markFirstNotificationAsRead()
        {
            notificationDropDownList.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, "//a[@href=\"/Account/Dashboard\"]");
            seeAllOption.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input");
            firstNoticCheckBox.Click();
            markAsReadTag.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 5, "/html/body/div[1]/div");
            if(successfulMessage.Text == "Notification updated")
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
