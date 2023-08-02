using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using NUnit.Framework;
using MarsAdvancedTask.Pages.MasterPage;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.MasterPage.Login;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;
using OpenQA.Selenium;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class CertificationNUnit : MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethods lMObj => new LoginMethods();
        ProfileAssertion lAObj => new ProfileAssertion();

        MarsProfilePageCertificationsMethods certObj = new MarsProfilePageCertificationsMethods();
        private IWebElement xpathnew => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        ProfileMethods profileMethods => new ProfileMethods();



        [Test, Order(1), Description("Profile --> Certification Add")]
        public void TestCaseAdd()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);

            User user = users.users.ElementAt(0);
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
            Thread.Sleep(2000);
            certObj.marsProfilePageCertificationsAddClick();
            
                certObj.marsProfilePageCertificationsAdd();
            

        }
        [Test, Order(2), Description("Profile --> Certification Edit")]
        public void TestCaseEdit()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);

            User user = users.users.ElementAt(0);
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
            Thread.Sleep(2000);
            certObj.marsProfilePageCertificationsAddClick();

            certObj.marsProfilePageCertificationsEdit();


        }
        [Test, Order(3), Description("Profile --> Certification Delete")]
        public void TestCaseDelete()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);

            User user = users.users.ElementAt(0);
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
            Thread.Sleep(2000);

            certObj.marsProfilePageCertificationsAddClick();
            certObj.marsProfilePageCertificationsDelete();


        }

    }
}

