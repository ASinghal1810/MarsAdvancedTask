using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.SearchSkillsComponents;
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
    public class SearchSkills_Test : MarsDriver
    {
        Login_Test login = new Login_Test();
        MarsHomePage homePage = new MarsHomePage();
        MarsSearchSkills searchSkillsPage = new MarsSearchSkills();

        [Test, Order(1)]
        public void searchSkillOnlineOption()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileSearchSkills searchSkills = user.searchSkills.ElementAt(0);
            ProfileLocationType locationType = user.skillType.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Search Skill by using Filter Online Option!");
            login.loginSuccessfully();
            homePage.goToHomePage();
            searchSkillsPage.searchByOnlineOption(searchSkills.skill, locationType.skillType);
        }

        [Test, Order(2)]
        public void searchSkillOnSiteOption()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileSearchSkills searchSkills = user.searchSkills.ElementAt(1);
            ProfileLocationType locationType = user.skillType.ElementAt(1);

            MarsExtentReporting.MarsExtentReportingLogInfo("Search Skill by using Filter On-Site Option!");
            login.loginSuccessfully();
            homePage.goToHomePage();
            searchSkillsPage.searchByOnsiteOption(searchSkills.skill, locationType.skillType);
        }

    }
}
