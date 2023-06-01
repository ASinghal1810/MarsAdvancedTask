using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Microsoft.Office.Interop.Excel;
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
            loginPage.signInAction("Login with valid credentials", "LoginData", 1);        
        }

        [Test, Order(2)]
        public void WrongPassword()
        {
            loginPage.invailPassword("Login with wrong password", "LoginData", 2);        
        }

        [Test, Order(3)]
        public void WrongEmailaddress()
        {
            loginPage.invailEmailaddress("Login with wrong email address", "LoginData", 3);
        }

        [Test, Order(4)]
        public void WrongEmailaddressAndPassword()
        {
            loginPage.invailEmailaddress("Login with wrong email address", "LoginData", 4);
        }

        [Test, Order(5)]
        public void nullEmailaddress()
        {
            loginPage.invailEmailaddress("Login with wrong email address", "LoginData", 5);
        }

        [Test, Order(6)]
        public void nullCredentals()
        {
            loginPage.invailEmailaddress("Login with wrong email address", "LoginData", 6);
        }

        [Test, Order(7)]
        public void nullPassword()
        {
            loginPage.invailPassword("Login with wrong password", "LoginData", 7);
        }
    }
}
