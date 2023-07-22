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

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    public class Notification : MarsDriver
    {
        
        private IWebElement deleteBox => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteCheckBox => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        //*[@id="notification-section"]/div[2]/div/div/div[3]/div[1]/div[3]
        public void marsNotificationDelete()
        {

            try
            {
                Thread.Sleep(3000);
                deleteBox.Click();
                Thread.Sleep(3000);
                deleteIcon.Click();
            }

            catch (NoSuchElementException)
            {
            }

        }

    }
}