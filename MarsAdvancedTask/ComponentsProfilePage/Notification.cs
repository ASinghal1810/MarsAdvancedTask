using EO.WebBrowser.DOM;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage
{

    [TestFixture]
    [Parallelizable]
    public class Notification : MarsDriver
    {
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement dashboardTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
        private IWebElement loadMoreButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));
       
        private IWebElement showLessButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a"));
        private IWebElement actualloadMore => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));
        private IWebElement actualShowLess => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));
       
     

        public void notificationSeeAll()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            //Do login
            Thread.Sleep(1000);
            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();

            //Go to Dashboard
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
            Thread.Sleep(1000);
            dashboardTab.Click();
           // Console.WriteLine(actualloadMore.Size);

            //Click on load more
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");
            Thread.Sleep(1000);
            loadMoreButton.Click();
            Console.WriteLine(actualloadMore.Size);
            int actualWidth = 520;
            int actualHeight = 582;
            Size elementSize = actualloadMore.Size;
            Assert.AreEqual(actualWidth, elementSize.Width, "Element width does not match expected value.");
            Assert.AreEqual(actualHeight, elementSize.Height, "Element height does not match expected value.");
            


            Thread.Sleep(2000);

            //Click on ShowLess
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a");
            Thread.Sleep(1000);
            showLessButton.Click();
            int showLessWidth = 520;
            int showLessHeight = 364;
            Size elementSize2 = actualShowLess.Size;
            Console.WriteLine(actualShowLess.Size);
            Assert.AreEqual(showLessWidth, elementSize2.Width, "Element width does not match expected value.");
            Assert.AreEqual(showLessHeight, elementSize2.Height, "Element height does not match expected value.");


        }
    }
}