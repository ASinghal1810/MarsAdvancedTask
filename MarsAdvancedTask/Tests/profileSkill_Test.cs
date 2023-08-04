using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.ComponentsProfilePage.ProfilePage;
using MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
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
        MarsLoginPage loginPage;
        SkillButton skillButtonObj;
        SkillAdd skillPage;
        SkillEdit skillEditObj;
        SkillDelete skillDeleteObj;
        SkillCancel skillCancelObj;
       
        public  profileSkill_Test()
        {
             loginPage = new MarsLoginPage();
             skillButtonObj = new SkillButton();
             skillPage = new SkillAdd();
            skillEditObj = new SkillEdit();
            skillDeleteObj = new SkillDelete();
            skillCancelObj = new SkillCancel();
         }
       
        [Test, Order(1)]
        public void Addskill()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillButtonObj.skillTab();
            skillPage.marsProfilePageSkillAdd();
            

        }
       
        [Test, Order(2)]
        public void skillEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillButtonObj.skillTab();
            skillEditObj.marsProfilePageSkillEdit();
           
        }
        [Test, Order(3)]
        public void sameSkillEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillButtonObj.skillTab();
            skillPage.updateSameSkill();


        }
        [Test, Order(4)]
        public void cancelWithoutEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillButtonObj.skillTab();
            skillCancelObj.marsSkillEditCancel();


        }
        [Test, Order(5)]
        public void delSkill()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
            skillButtonObj.skillTab();
            skillDeleteObj.marsProfilePageSkillDelete();
           
           


        }


    }
}
