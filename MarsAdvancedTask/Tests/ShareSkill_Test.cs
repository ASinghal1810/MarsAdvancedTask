using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.ManageListingsComponents;
using MarsAdvancedTask.Components.ShareSkillComponents;
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
    public class ShareSkill_Test : MarsDriver
    {
        Login_Test login = new Login_Test();
        MarsManageListingsPage listingsPage = new MarsManageListingsPage();
        MarsProfilePage profilePage = new MarsProfilePage();
        MarsShareSkills shareSkills = new MarsShareSkills();
        MarsManageListings manageListings = new MarsManageListings();

        [Test, Order(1)]
        public void createSkillListing()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            SkillListing skillListing1 = user.skillListings.ElementAt(0);
            ShareSkillTag shareSkillTag1 = skillListing1.tags.ElementAt(0);
            ShareSkillTag shareSkillTag2 = skillListing1.tags.ElementAt(1);
            ShareSkillExchangeTag skillExchangeTag1 = skillListing1.skillExchangeTags.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("New listing has been created!");

            login.loginSuccessfully();
            profilePage.clickShareSkillButton();
            shareSkills.ShareSkillAction(skillListing1.title, skillListing1.description, shareSkillTag1.tag, shareSkillTag2.tag, skillListing1.startDate, skillListing1.endDate, skillListing1.startTime, skillListing1.endTime, skillExchangeTag1.skillExchangeTag);
        }

        [Test, Order(2)]
        public void deleteSkillListing()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Title Jazz Club Listing has been deleted!");
            login.loginSuccessfully();
            listingsPage.goToManageListingsPage();
            manageListings.marsDeleteListing(user.listingTitleName);
        }
    }
}
