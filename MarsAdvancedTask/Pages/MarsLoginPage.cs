using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{
    public class MarsLoginPage : MarsDriver
    {
        // Resgiration Action
        private IWebElement joinButton = marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
        private IWebElement firstName = marsDriver.FindElement(By.Name("firstName"));
        private IWebElement lastName = marsDriver.FindElement(By.Name("lastName"));
        private IWebElement emailAddress = marsDriver.FindElement(By.Name("email"));
        private IWebElement password = marsDriver.FindElement(By.Name("password"));
        private IWebElement comfirmPassword = marsDriver.FindElement(By.Name("confirmPassword"));
        private IWebElement agreeButton = marsDriver.FindElement(By.Name("terms"));
        private IWebElement join = marsDriver.FindElement(By.Id("submit-btn"));

        // Login Action
        private IWebElement signInButton = marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress = marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword = marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe = marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton = marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void RegistrationAction(string firstname, string lastname, string emailaddress, string passWord, string comdirmpassword)
        {
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
        }

        public void SignInAction(string emailaddress, string passWord)
        {
            signInButton.Click();
            loginEmailaddress.SendKeys(emailaddress);
            LoginPassword.SendKeys(passWord);
            rememberMe.Click();
            loginButton.Click();
        }
    }
}
