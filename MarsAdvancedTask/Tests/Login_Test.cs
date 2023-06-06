using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using MarsAdvancedTask.Pages.MarsProfilePages;
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
            loginPage.signInAction("Login with valid credentials");
        }

        [Test, Order(2)]
        public void WrongPassword()
        {
            loginPage.invailPassword("Login with wrong password");        
        }

        [Test, Order(3)]
        public void WrongEmailaddress()
        {
            loginPage.invailEmailaddress("Login with wrong email address");
        }
    }
}
