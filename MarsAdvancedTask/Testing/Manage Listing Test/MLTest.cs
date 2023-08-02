using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using NUnit.Framework;
using MarsAdvancedTask.Pages.MasterPage;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.MasterPage.Login;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;
using OpenQA.Selenium;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
using MarsAdvancedTask.Pages.HomePage;
using MarsAdvancedTask.Pages.HomePage.Components.ManageListings;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class ManageListingTest: MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();

        MarsHomePage mhpg = new MarsHomePage();

        ManageListingEdit MLMethod = new ManageListingEdit();
        LoginMethods lMObj => new LoginMethods();
        ProfileAssertion lAObj => new ProfileAssertion();

        MarsProfilePageCertificationsMethods certObj = new MarsProfilePageCertificationsMethods();
        private IWebElement xpathnew => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        ProfileMethods profileMethods => new ProfileMethods();

        AssertNotify pa => new AssertNotify();


        [Test, Order(1), Description("Manage Listings --> Edit ")]
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
            mhpg.manageListingComponentButton();
            Thread.Sleep(2000);
            MLMethod.MLEdit(0);
            
            

        }

    }
}

