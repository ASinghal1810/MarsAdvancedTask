using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json;
using MarsAdvancedTask.Pages.MasterPage.Login;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    public class Notification : MarsDriver
    {
        
        private IWebElement deleteBox => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteCheckBox => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        AssertNotify pa => new AssertNotify();
        public void marsNotificationDelete()
        {

            try
            {
                Thread.Sleep(3000);
                deleteBox.Click();
                Thread.Sleep(3000);
                deleteIcon.Click();
                if (pa.assertNotification().Trim() == "Notification updated")
                {
                    Console.WriteLine("Test Successful");
                }
                else
                {

                    Console.WriteLine("Test Not Successful and below message displayed");
                    Console.WriteLine(pa.assertNotification().Trim());
                }
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("No Existing Notification to Delete");
                Console.WriteLine("Test Successful");
            }

        }

    }
}