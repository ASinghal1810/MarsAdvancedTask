using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechTalk.SpecFlow.CommonModels;

namespace MarsAdvancedTask.Pages
{
    public class MarsLoginPage : MarsDriver
    {
        // Login Action Element
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement actualAccountName => marsDriver.FindElement(By.XPath("//div[contains(text(), \"Eddie He\")]"));
        private IWebElement errorEmailMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
        private IWebElement errorPasswordMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));



        public void signInAction(string name, string sheetName, int key)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", sheetName);
            signInButton.Click();
            loginEmailaddress.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "EmailAddress"));
            loginPassword.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "Password"));
            rememberMe.Click();
            loginButton.Click();

            // Assertion message
            MarsWait.MarsWaitToBeVisible("XPath", 5, "//div[contains(text(), \"Eddie He\")]");
            if (actualAccountName.Text == "Eddie He")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }

        public void invailEmailaddress(string name, string sheetName, int key)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", sheetName);
            signInButton.Click();
            loginEmailaddress.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "EmailAddress"));
            loginPassword.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "Password"));
            rememberMe.Click();
            loginButton.Click();

            if (errorEmailMessage.Text == "Please enter a valid email address")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }

        public void invailPassword(string name, string sheetName, int key)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", sheetName);
            signInButton.Click();
            loginEmailaddress.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "EmailAddress"));
            loginPassword.SendKeys(MarsExcelLib.MarsExcelLibReadData(key, "Password"));
            rememberMe.Click();
            loginButton.Click();

            if (errorPasswordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }
    }
}

