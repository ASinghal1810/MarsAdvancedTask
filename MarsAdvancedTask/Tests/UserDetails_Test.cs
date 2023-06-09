using MarsAdvancedTask.Components.ProfilePageComponents;
using MarsAdvancedTask.Driver;
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
    public class UserDetails_Test : MarsDriver
    {
        MarsLoginPage loginPage = new MarsLoginPage();
        MarsProfilePage profilePage = new MarsProfilePage();

        [Test, Order(1)]
        public void addUserDetails()
        {
            loginPage.loginSuccessfully("Login Successfully!");
            profilePage.addProfileUserDetail("User details has been added!!");
        }

        [Test, Order(2)]
        public void editUserDetails()
        {
            loginPage.loginSuccessfully("Login Successfully!");
            profilePage.editProfileUserDetail("User details has been edited!!");
        }
    }
}
