using MarsAdvancedTask.Drivers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Driver
{
    [TestFixture]
    public class MarsDriver
    {

        public static IWebDriver marsDriver;
        public static string testDataPath = @"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json";
        protected MarsBroswer marsBroswer;


        [SetUp]
        public void MarsDriverStartWebsite()
        {
            MarsExtentReporting.MarsExtentReportingCreateTest(TestContext.CurrentContext.Test.MethodName);

            marsDriver = new ChromeDriver();
            marsDriver.Manage().Window.Maximize();
            marsDriver.Navigate().GoToUrl("http://localhost:5000/");

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