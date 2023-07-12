using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Tests
{

    [TestFixture]
    [Parallelizable]
    public class Login_Test : MarsDriver
    {
        MarsLoginPage loginPage = new MarsLoginPage();

        [Test, Order(1)]
        public void LoginSuccessfully()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            // MarsExcelLib.MarsExcelLibPopulateInCollection(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\Xlfiles\MarsAdvanceTask (1).xlsx", "Login");
            loginPage.SignInAction();
        }

  
        [Test, Order(2)]
        public void WrongEmailaddress()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address");
           // MarsExcelLib.MarsExcelLibPopulateInCollection(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\Xlfiles\MarsAdvanceTask (1).xlsx", "Login");
            loginPage.invailEmailaddress();
        }

        [Test, Order(3)]
        public void WrongPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address");
           // MarsExcelLib.MarsExcelLibPopulateInCollection(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\Xlfiles\MarsAdvanceTask (1).xlsx", "Login");
            loginPage.invailPassword();
        }

        [Test, Order(4)]
        public void WrongEmailaddressAndPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address and password");
//            MarsExcelLib.MarsExcelLibPopulateInCollection(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\Xlfiles\MarsAdvanceTask (1).xlsx", "Login");
           loginPage.invalidEmailPassword();
        }
        [Test, Order(5)]
        public void nullvalue()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with null email address and null password with less than 6 digit");
            loginPage.nullEmailaddressPassword();
        }
        [Test, Order(6)]
        public void nullvalueEmail()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with random value in email and password");
            loginPage.nullEmail();
        }
        [Test, Order(7)]    
        public void nullvaluPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with right email address and random password");
            loginPage.nullPassword();
        }
        [Test, Order(8)]
        public void emptyvaluEmailPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Not passing any value in username and password and click on login");
            loginPage.emptyEmailPassword();
        }
        [Test, Order(9)]
        public void emptyvaluEmail()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Not passing any value in username and random password with more than 6 digits");
            loginPage.emptyEmail();
        }
        [Test, Order(10)]
        public void emptyvaluPasswordRightEmail()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Right username and No value in password field");
            loginPage.emptyPassword();
        }
        [Test, Order(11)]
        public void invalidvaluEmailNoPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Right username and No value in password field");
            loginPage.invalidEmailNoPassword();
        }

    }
}
