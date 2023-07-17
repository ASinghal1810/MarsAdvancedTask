using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.ProfilePageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarsAdvancedTask.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Login_Test : MarsDriver
    {
        MarsLogin marsLogin = new MarsLogin();

        [Test, Order(1)]
        public void loginSuccessfully()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with vaild credentials!!");

            marsLogin.loginWithValidCredentails(user.emailAddress, user.password, user.userName);
        }

        [Test, Order(2)]
        public void invailEmailaddress()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User2.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with invail email address");
            marsLogin.invailEmailaddress(user.emailAddress, user.password, user.errorMessage);
        }

        [Test, Order(3)]
        public void invailPassword()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User3.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with invail password");
            marsLogin.invailPassword(user.emailAddress, user.password, user.errorMessage);      
        }

        [Test, Order(4)]
        public void invailEmailAddressAndPassword()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User4.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with invail emailaddress and password");
            marsLogin.invailEmailAddressAndPassword(user.emailAddress, user.password, user.errorMessage);
        }

        [Test, Order(5)]
        public void nullEmailAddress()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User5.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with null emailaddress");
            marsLogin.nullEmailAddress(user.emailAddress, user.password, user.errorMessage);
        }

        [Test, Order(6)]
        public void nullEmailAddressAndPassword()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User6.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with null emailaddress and null password");
            marsLogin.nullEmailAddressAndPassword(user.emailAddress, user.password, user.errorMessage);
        }

        [Test, Order(7)]
        public void nullPassword()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData\User7.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with null password");
            marsLogin.nullPassword(user.emailAddress, user.password, user.errorMessage);
        }
    }
}
