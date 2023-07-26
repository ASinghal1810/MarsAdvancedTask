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

namespace MarsAdvancedTask.Pages.ManageRequest
{
    [TestFixture]
    [Parallelizable]
    public class manageRequestReceived : MarsDriver
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

        private IWebElement actualDecline => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));


        public void receiveReqAccept(string Username, string Password)
        {

            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");
            
            manageReqTab.Click();
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");
            
            receivedReqTab.Click();

            //accept request
            Thread.Sleep(1000);
            if (checkStatus.Text == "Pending")
            {
                MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[2]/td[8]/button[1]");
               
                acceptReqTab.Click();

                Thread.Sleep(1000);
                Assert.That(actualStatus.Text == "Accepted", "Actual result and expected result so not match");
            }
            else
            {
                Console.WriteLine("There is no pending request");
            }

        }
        public void reqDecline(string Username, string Password)
        {
           

            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]");
        
            manageReqTab.Click();
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]");
            
            receivedReqTab.Click();

            Thread.Sleep(1000);
            if (checkStatus.Text == "Pending")
            {
                MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]");
               
                manageReqDecline.Click();
                
                Assert.That(actualDecline.Text == "Declined", "Actual Result and Expected result do not match");
            }
            else
            {
                Console.WriteLine("There is no request to Decline");
            }


        }

    }
}
