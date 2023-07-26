using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using MongoDB.Driver.Core.Authentication;
using Newtonsoft.Json;
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
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
           
            loginPage.SignInAction(user.Username, user.Password);
        }

  
        [Test, Order(2)]
        public void WrongEmailaddress()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(1);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address");
          
            loginPage.invailEmailaddress(user.Username, user.Password);
        }

        [Test, Order(3)]
        public void WrongPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(2);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address");
          
            loginPage.invailPassword(user.Username, user.Password);
        }

        [Test, Order(4)]
        public void WrongEmailaddressAndPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(3);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with wrong email address and password");

           loginPage.invalidEmailPassword(user.Username, user.Password);
        }
        [Test, Order(5)]
        public void nullvalue()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(4);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with null email address and null password with less than 6 digit");
            loginPage.nullEmailaddressPassword(user.Username,user.Password);
        }
        [Test, Order(6)]
        public void nullvalueEmail()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(5);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with random value in email and password");
            loginPage.nullEmail(user.Username,user.Password);
        }
        [Test, Order(7)]    
        public void nullvaluPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(6);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with right email address and random password");
            loginPage.nullPassword(user.Username,user.Password);
        }
        [Test, Order(8)]
        public void emptyvaluEmailPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(7);
            MarsExtentReporting.MarsExtentReportingLogInfo("Not passing any value in username and password and click on login");
            loginPage.emptyEmailPassword(user.Username,user.Password);
        }
        [Test, Order(9)]
        public void emptyvaluEmail()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(8);

            MarsExtentReporting.MarsExtentReportingLogInfo("Not passing any value in username and random password with more than 6 digits");
            loginPage.emptyEmail(user.Username,user.Password);
        }
        [Test, Order(10)]
        public void emptyvaluPasswordRightEmail()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(9);

            MarsExtentReporting.MarsExtentReportingLogInfo("Right username and No value in password field");
            loginPage.emptyPassword(user.Username,user.Password);
        }
        [Test, Order(11)]
        public void invalidvaluEmailNoPassword()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(10);
            MarsExtentReporting.MarsExtentReportingLogInfo("Right username and No value in password field");
            loginPage.invalidEmailNoPassword(user.Username,user.Password);
        }

    }
}
