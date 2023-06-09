using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsAdvancedTask.Components.LoginPageComponents
{
    public class MarsLogin : MarsDriver
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


        public void loginWithValidCredentails()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\SignInData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataPath);
            User user = users.users.ElementAt(0);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.emailAddress);
            loginPassword.SendKeys(user.password);
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
        public void invailEmailaddress()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\SignInData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataPath);
            User user = users.users.ElementAt(2);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.emailAddress);
            loginPassword.SendKeys(user.password);
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

        public void invailPassword()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\SignInData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataPath);
            User user = users.users.ElementAt(1);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.emailAddress);
            loginPassword.SendKeys(user.password);
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
