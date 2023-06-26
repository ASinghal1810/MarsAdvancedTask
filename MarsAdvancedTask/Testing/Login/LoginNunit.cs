using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using NUnit.Framework;
using MarsAdvancedTask.Pages.MasterPage;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.MasterPage.Login;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class LoginNunit : MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethods lMObj=> new LoginMethods();
        LoginAssertion lAObj=> new LoginAssertion();
     
        [Test, Order(1),Description("Sign In")]
        public void TestCaseOne()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            for (int i = 0; i < users.users.Count; i++)
            {
                User user = users.users.ElementAt(i);

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(i), lMObj.userPassword(i));

                Thread.Sleep(200);
                lAObj.assertLogin(i);
            }
        }
        [Test, Order(2), Description("Profile --> Loc, Availability, Hours, Earn Target")]
        public void TestCaseTwo()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            
                User user = users.users.ElementAt(0);

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));

                

            
        }
    }
}


