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
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "LoginData");
            loginPage.SignInAction(MarsExcelLib.MarsExcelLibReadData(1, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(1, "Password"));
        }

        [Test, Order(2)]
        public void WrongPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong password");
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "LoginData");
            loginPage.SignInWithInvildCredentals(MarsExcelLib.MarsExcelLibReadData(2, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(2, "Password"));
        }

        [Test, Order(3)]
        public void WrongEmailaddress()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address");
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "LoginData");
            loginPage.SignInWithInvildCredentals(MarsExcelLib.MarsExcelLibReadData(3, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(3, "Password"));
        }

        [Test, Order(4)]
        public void WrongEmailaddressAndPassword()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address and password");
            MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "LoginData");
            loginPage.SignInWithInvildCredentals(MarsExcelLib.MarsExcelLibReadData(4, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(4, "Password"));
        }
    }
}
