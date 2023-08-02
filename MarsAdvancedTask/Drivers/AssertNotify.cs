using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;

namespace MarsAdvancedTask.Pages.MasterPage.Login
{
    public class AssertNotify : MarsDriver
    {
        private static IWebElement avail => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/span"));
        private static IWebElement hour => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
                                                                            
        private static IWebElement et => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[4]/div/div[4]/div/span"));
        
        private static IWebElement notiText => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));

        public string assertNotification()
        {
            MarsWait.MarsWaitToBeVisible("XPath", 20, "/html/body/div[1]/div");

            return notiText.Text;
        }
       
    }
}
