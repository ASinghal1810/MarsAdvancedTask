using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using NUnit.Framework;
using MarsAdvancedTask.Pages.MasterPage;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.MasterPage.Login;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;
using OpenQA.Selenium;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
using MarsAdvancedTask.Pages.HomePage.Search_Skills;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class SearchSkillTest : MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethods lMObj => new LoginMethods();
        SkillSearch skillObj => new SkillSearch();

        [Test, Order(1), Description("Search Skills --> by All Categories, Sub Categories")]
        public void TestCase()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);

            User user = users.users.ElementAt(0);
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
            Thread.Sleep(2000);
            skillObj.skillToSearch("sssssssssss", "Programming & Tech", "Data Analysis & Reports");
        }

    }
}