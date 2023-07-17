using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.SearchSkillsComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{ 
    public class MarsHomePage : MarsDriver
    {
       MarsSearchSkills searchSkillsPage = new MarsSearchSkills();

        public void searchSkillByUsingOnlineOption(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileSearchSkills searchSkills = user.searchSkills.ElementAt(0);
            ProfileLocationType locationType = user.skillType.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            searchSkillsPage.goToHomePage();
            searchSkillsPage.searchByOnlineOption(searchSkills.skill, locationType.skillType);
        }

        public void searchSkillByUsingOnSiteOption(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileSearchSkills searchSkills = user.searchSkills.ElementAt(1);
            ProfileLocationType locationType = user.skillType.ElementAt(1);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            searchSkillsPage.goToHomePage();
            searchSkillsPage.searchByOnsiteOption(searchSkills.skill, locationType.skillType);
        }
    }
}
