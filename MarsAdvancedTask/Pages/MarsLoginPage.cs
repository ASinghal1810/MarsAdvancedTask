using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;

namespace MarsAdvancedTask.Pages
{
    public class MarsLoginPage : MarsDriver
    {
        // Resgiration Action
        private IWebElement joinButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
        private IWebElement firstName => marsDriver.FindElement(By.Name("firstName"));
        private IWebElement lastName => marsDriver.FindElement(By.Name("lastName"));
        private IWebElement emailAddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement password => marsDriver.FindElement(By.Name("password"));
        private IWebElement comfirmPassword => marsDriver.FindElement(By.Name("confirmPassword"));
        private IWebElement agreeButton => marsDriver.FindElement(By.Name("terms"));
        private IWebElement join => marsDriver.FindElement(By.Id("submit-btn"));
        private IWebElement successMessage => marsDriver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        // Login Action
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=>\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement actualAccountName => marsDriver.FindElement(By.XPath("//div[contains(text(), \"Eddie He\")]"));
        private IWebElement comfireEmailaddress => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));

        public void RegistrationAction(string firstname, string lastname, string emailaddress, string passWord, string comdirmpassword)
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"home\"]/div/div/div[1]/div/button");
            // Identify the Join button and click on it
            joinButton.Click();
            // Identify each each textbox and input valid value
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            emailAddress.SendKeys(emailaddress);
            password.SendKeys(passWord);
            comfirmPassword.SendKeys(comdirmpassword);
            agreeButton.Click();
            join.Click();
            // Assertion message
            MarsWait.MarsWaitToBeVisible("XPath", 5, "//div[@class=\"ns-box-inner\"]");
            if (successMessage.Text == "Registration successful")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }

        public void RegistrationWithoutComplate(string firstname, string lastname, string emailaddress, string passWord, string comdirmpassword)
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"home\"]/div/div/div[1]/div/button");
            // Identify the Join button and click on it
            joinButton.Click();
            // Identify each each textbox and input valid value
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            emailAddress.SendKeys(emailaddress);
            password.SendKeys(passWord);
            comfirmPassword.SendKeys(comdirmpassword);
            agreeButton.Click();

            if(join.Enabled == true)
            {
                join.Click();
            }
            else
            {
                Assert.Fail("Unable to click join button while not complated the form!");
            }
        }


        public void RegistrationWithoutAgree(string firstname, string lastname, string emailaddress, string passWord, string comdirmpassword)
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"home\"]/div/div/div[1]/div/button");
            // Identify the Join button and click on it
            joinButton.Click();
            // Identify each each textbox and input valid value
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            emailAddress.SendKeys(emailaddress);
            password.SendKeys(passWord);
            comfirmPassword.SendKeys(comdirmpassword);

            if (join.Enabled == true)
            {
                join.Click();
            }
            else
            {
                Assert.Fail("Unable to click join button while not complated the form!");
            }
        }

        public void SignInAction(string emailaddress, string passWord)
        {
            signInButton.Click();
            loginEmailaddress.SendKeys(emailaddress);
            loginPassword.SendKeys(passWord);
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

        public void SignInWithInvildCredentals(string emailaddress, string passWord)
        {
            signInButton.Click();
            loginEmailaddress.SendKeys(emailaddress);
            loginPassword.SendKeys(passWord);
            rememberMe.Click();
            loginButton.Click();
            if(comfireEmailaddress.Text == "Confirm your email")
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