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
        Login_Test login = new Login_Test();
        MarsManageListingPage manageListingPage = new MarsManageListingPage();
        MarsProfilePage profilePage = new MarsProfilePage();
        MarsShareSkills shareSkill = new MarsShareSkills();

        [Test, Order(1)]
        public void createSkillListing()
        {
            login.loginSuccessfully();
            profilePage.createNewListing("New listing has been created!");
        }

        [Test, Order(2)]
        public void deleteSkillListing()
        {
            login.loginSuccessfully();
            manageListingPage.deleteListing("Title Jazz Club Listing has been deleted!");
        }
    }
}
