using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using MarsAdvancedTask.Pages.Profile.Components;
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
    public class profileSkill_Test:MarsDriver
    {
        marsProfilePageSkill skillPage => new marsProfilePageSkill();
        MarsLoginPage loginPage = new MarsLoginPage();

        [Test, Order(1)]
        public void Addskill()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillPage.marsProfilePageSkillAdd();

        }
        [Test, Order(2)]
        public void sameskill()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(3);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.addSameskill(user.Username,user.Password, user.Skill.Addskill, user.Skill.Chooselevel);
           
        }
        [Test, Order(3)]
        public void skillEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(4);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsProfilePageSkillEdit(user.Username, user.Password, user.SkillUpdate.Addskill, user.SkillUpdate.Chooselevel);
           string editSkillalert = skillPage.alert();
            string skillupdate = skillPage.updatelst();
            Assert.That(editSkillalert==skillupdate + " has been updated to your skills","Error While update");

        }
        [Test, Order(4)]
        public void sameSkillEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(5);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.updateSameSkill(user.Username, user.Password, user.SameSkillUpdate.Addskill, user.SameSkillUpdate.Chooselevel);


        }
        [Test, Order(5)]
        public void cancelWithoutEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(4);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsSkillEditCancel(user.Username, user.Password);


        }
        [Test, Order(6)]
        public void delLastskill()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(3);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsProfilePageSkillDelete(user.Username,user.Password);


        }


    }
}
