using MarsAdvancedTask.Components.ProfilePageComponents;
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
        public void loginSuccessfully()
        {
            loginPage.loginSuccessfully("Login with valid credentials");
        }

        [Test, Order(2)]
        public void invailEmailaddress()
        {
            loginPage.loginWithInvailEmailAddress("Login with invail email address");
        }

        [Test, Order(3)]
        public void invailPassword()
        {
            loginPage.loginWithInvailPassword("Login with invail password");        
        }

        [Test, Order(4)]
        public void invailEmailAddressAndPassword()
        {
            loginPage.loginWithInvailEmailAddressAndPassword("Login with invail emailaddress and password");
        }

        [Test, Order(5)]
        public void nullEmailAddress()
        {
            loginPage.loginWithNullEmailAddress("Login with null emailaddress");
        }

        [Test, Order(6)]
        public void nullEmailAddressAndPassword()
        {
            loginPage.loginWithNullEmailAddressAndPassword("Login with null emailaddress and null password");
        }

        [Test, Order(7)]
        public void nullPassword()
        {
            loginPage.loginWithNullPassword("Login with null password");
        }
    }
}
