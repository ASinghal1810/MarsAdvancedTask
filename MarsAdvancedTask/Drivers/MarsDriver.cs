﻿using MarsAdvancedTask.Drivers;
using Microsoft.Exchange.WebServices.Data;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Driver
{
    [TestFixture]
    public class MarsDriver
    {

        public static IWebDriver marsDriver;
       // public static string testDataPath = @"C:\Users\ankur\Desktop\MarsAdvancedTask\MarsAdvancedTask\MarsAdvancedTask\MarsAdvancesTaskTestData.xlsx";
        protected MarsBroswer marsBroswer;


        [SetUp]
        public void MarsDriverStartWebsite()
        {
            MarsExtentReporting.MarsExtentReportingCreateTest(TestContext.CurrentContext.Test.MethodName);
             marsDriver = new EdgeDriver();
           // marsDriver = new ChromeDriver();
          // marsDriver = new ChromeDriver(@"C:\Users\jeelp\Downloads\chromedriver\chromedriver.exe");
            marsDriver.Manage().Window.Maximize();
            
            
            marsDriver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(5000);
            marsBroswer = new MarsBroswer(marsDriver);
        }


        [TearDown]
        public void MarsDriverCloseBrowser()
        {
            MarsDriverEndTest();
            MarsExtentReporting.MarsExtentReportingEndReporting();
            marsDriver.Quit();
        }

        private void MarsDriverEndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    MarsExtentReporting.MarsExtentReportingLogFail($"Test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    MarsExtentReporting.MarsExtentReportingLogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            MarsExtentReporting.MarsExtentReportingLogScreenShot("Ending test", marsBroswer.MarsBroswerGetScreenShot());
        }
    }
}