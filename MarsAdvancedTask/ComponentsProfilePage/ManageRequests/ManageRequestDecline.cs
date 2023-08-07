using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AventStack.ExtentReports;
using Newtonsoft.Json;
using NUnit.Framework;


namespace MarsAdvancedTask.ComponentsProfilePage.ManageRequests
{
    public class ManageRequestDecline:MarsDriver
    {
        private IWebElement checkStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement actualStatus => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));

        private IWebElement manageReqDecline => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]"));
       
        private IWebElement actualDecline => marsDriver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));

        public void reqDecline()
        {


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
