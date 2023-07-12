using AventStack.ExtentReports;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage
{
    [TestFixture]
    [Parallelizable]
    public class manageRequestReceived:MarsDriver
    {
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement manageReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
        private IWebElement receivedReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
        private IWebElement acceptReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
        private IWebElement checkStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement actualStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement manageReqDecline => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]"));
                                                                                //*[@id="received-request-section"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]
        private IWebElement actualDecline => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        //*[@id="received-request-section"]/div[2]/div[1]/table/tbody/tr[2]/td[5]

        public void receiveReqAccept()
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

           MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");
           Thread.Sleep(1000);
           manageReqTab.Click();
           MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");
           Thread.Sleep(2000);
           receivedReqTab.Click();

            //accept request
            Thread.Sleep(1000);
            if(checkStatus.Text == "Pending")
            {
                MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[2]/td[8]/button[1]");
                Thread.Sleep(1000);
               acceptReqTab.Click();
                //*[@id="received-request-section"]/div[2]/div[1]/table/tbody/tr[1]/td[5]
                Thread.Sleep(1000);
                Assert.That(actualStatus.Text== "Accepted","Actual result and expected result so not match");
            }
            else
            {
                Console.WriteLine("There is no pending request");
            }
            
        }
        public void reqDecline()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            // profileSkill skills = user.skills.ElementAt(0);
            //Do login
            Thread.Sleep(1000);
            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");
            Thread.Sleep(1000);
            manageReqTab.Click();
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");
            Thread.Sleep(2000);
            receivedReqTab.Click();

            Thread.Sleep(1000);
            if(checkStatus.Text == "Pending")
            {
                MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]");
                Thread.Sleep(1000);
                manageReqDecline.Click();
                Thread.Sleep(1000);
                Assert.That(actualDecline.Text == "Declined", "Actual Result and Expected result do not match");
            }
            else
            {
                Console.WriteLine("There is no request to Decline");
            }


        }

    }
}
