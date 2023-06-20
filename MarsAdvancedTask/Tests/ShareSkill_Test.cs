using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.ManageListingsComponents;
using MarsAdvancedTask.Components.ShareSkillComponents;
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
    public class ShareSkill_Test : MarsDriver
    {
        MarsLoginPage loginPage = new MarsLoginPage();
        MarsManageListingPage manageListingPage = new MarsManageListingPage();
        MarsProfilePage profilePage = new MarsProfilePage();
        MarsShareSkills shareSkill = new MarsShareSkills();

        [Test, Order(1)]
        public void createSkillListing()
        {
            loginPage.loginSuccessfully("Login with valid credentials");
            profilePage.createNewListing("New listing has been created!");
        }

        [Test, Order(2)]
        public void deleteSkillListing()
        {
            loginPage.loginSuccessfully("Login with valid credentials");
            manageListingPage.deleteListing("Title Jazz Club Listing has been deleted!");
        }
    }
}
