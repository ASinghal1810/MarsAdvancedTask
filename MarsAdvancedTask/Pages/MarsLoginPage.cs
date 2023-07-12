using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;


namespace MarsAdvancedTask.Pages
{
    public class MarsLoginPage : MarsDriver
    {
        // private User i;


        // Login Action
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement actualAccountName => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement emailMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
        private IWebElement passwordMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));
        private IWebElement emailVerification => marsDriver.FindElement(By.CssSelector(".fluid.ui.teal.button"));

        private IWebElement signof => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        public void SignInAction()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            //for (int counter = 0; counter <= users.Count; counter++)
            User user = users.ElementAt(0);
           
                    Thread.Sleep(1000);
                    signInButton.Click();
                    loginEmailaddress.SendKeys(user.Username);
                    loginPassword.SendKeys(user.Password);
                    rememberMe.Click();
                    loginButton.Click();
            // Assertion message
            MarsWait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
            if (actualAccountName.Text == "Hi zeel")
            {
                Console.WriteLine("Pass1");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");

            }
        }
        public void invailEmailaddress()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(1);
           
            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address")
            {
                Console.WriteLine("Pass2");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
          
        }

        public void invailPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(2);
            
            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();

            if (passwordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass3");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }

        public void invalidEmailPassword()
        {

            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(3);
            
            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();

            Thread.Sleep(1000);
            if (emailVerification.Text == "Send Verification Email")
            {
                Console.WriteLine("Pass4");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }
        public void nullEmailaddressPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(4);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address" && passwordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass5");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }
        public void nullEmail()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(5);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address")
            {
                Console.WriteLine("Pass6");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }
        public void nullPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(6);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailVerification.Text == "Send Verification Email")
            {
                Console.WriteLine("Pass7");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }
        public void emptyEmailPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(7);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address" && passwordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass8");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }
        public void emptyEmail()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(8);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address")
            {
                Console.WriteLine("Pass9");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }
        public void emptyPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(9);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();

            if (passwordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass10");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }
        }
        public void invalidEmailNoPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(10);

            signInButton.Click();
            loginEmailaddress.SendKeys(user.Username);
            loginPassword.SendKeys(user.Password);
            rememberMe.Click();
            loginButton.Click();
            Thread.Sleep(1000);

            if (emailMessage.Text == "Please enter a valid email address" && passwordMessage.Text == "Password must be at least 6 characters")
            {
                Console.WriteLine("Pass11");
            }
            else
            {
                Assert.Fail("Actual message and expected message do not match!");
            }

        }
      

        }
    }