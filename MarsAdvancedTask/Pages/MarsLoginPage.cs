using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Newtonsoft.Json;
using MarsAdvancedTask.Components.LoginPageComponents;
using Microsoft.Office.Interop.Excel;

namespace MarsAdvancedTask.Pages
{
    public class MarsLoginPage : MarsDriver
    {
        MarsLogin marsLogin = new MarsLogin();

        public void loginSuccessfully(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            marsLogin.loginWithValidCredentails();
        }

        public void loginWithInvailEmailAddress(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            marsLogin.invailEmailaddress();
        }

        public void loginWithInvailPassword(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            marsLogin.invailPassword();
        }
    }
}

