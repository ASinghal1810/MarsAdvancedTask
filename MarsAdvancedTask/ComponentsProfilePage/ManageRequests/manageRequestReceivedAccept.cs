using AventStack.ExtentReports;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ManageRequests
{
    [TestFixture]
    [Parallelizable]
    public class manageRequestReceivedAccept : MarsDriver
    {
      
       
        private IWebElement receivedReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
        private IWebElement acceptReqTab => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
        private IWebElement checkStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement actualStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
       
        public void receiveReqAccept()
        {
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
       
    }
}
