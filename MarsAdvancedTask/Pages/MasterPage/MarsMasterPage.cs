using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.MasterPage
{
    public class MarsMasterPage:MarsDriver
    {
        private IWebElement marsMasterPageJoinButton => marsDriver.FindElement(By.XPath("//*[@class='ui green basic button' and 'Join']"));
        private IWebElement marsMasterPageSignInButton => marsDriver.FindElement(By.XPath("//*[@class='item' and 'Sign In']"));
        private IWebElement marsMasterPageLoginButton => marsDriver.FindElement(By.XPath("//button[@class=\"fluid ui teal button\"]"));
        private IWebElement marsMasterPageFirstName => marsDriver.FindElement(By.Name("firstName"));
        private IWebElement marsMasterPageLastName => marsDriver.FindElement(By.Name("lastName"));
        private IWebElement marsMasterPageEmail => marsDriver.FindElement(By.Name("email"));
        private IWebElement marsMasterPagePassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement marsMasterPageConfirmPassword => marsDriver.FindElement(By.Name("confirmPassword"));
        private IWebElement marsMasterPageTermsCheckBox => marsDriver.FindElement(By.Name("terms"));
        private IWebElement marsMasterPageSubmitButton => marsDriver.FindElement(By.Id("submit-btn"));


        public void MarsMasterPageNavigateToLandingPage() => marsDriver.Navigate().GoToUrl("http://localhost:5000/");

        public void MarsMasterPageNavigateToJoinForm() => marsMasterPageJoinButton.Click();

        public void MarsMasterPageNavigateToSignInForm() => marsMasterPageSignInButton.Click();

        public void MarsMasterPageResisterUserDetails(string fName, string lName, string eMail, string password, string confirmPassword)
        {

            marsMasterPageFirstName.SendKeys(fName);
            marsMasterPageLastName.SendKeys(lName);
            marsMasterPageEmail.SendKeys(eMail);
            marsMasterPagePassword.SendKeys(password);
            marsMasterPageConfirmPassword.SendKeys(confirmPassword);
            marsMasterPageTermsCheckBox.Click();
            marsMasterPageSubmitButton.Click();

        }

        public void MarsMasterPageLoginUser(string username, string password)
        {
            marsMasterPageEmail.SendKeys(username);
            marsMasterPagePassword.SendKeys(password);
            marsMasterPageLoginButton.Click();

        }
    }
}