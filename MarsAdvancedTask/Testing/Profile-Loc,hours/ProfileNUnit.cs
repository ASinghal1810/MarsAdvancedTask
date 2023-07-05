using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using NUnit.Framework;
using MarsAdvancedTask.Pages.MasterPage;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.MasterPage.Login;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using Microsoft.Exchange.WebServices.Data;
using AventStack.ExtentReports.Utils;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class ProfileNunit : MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethods lMObj => new LoginMethods();
        LoginAssertion lAObj => new LoginAssertion();
        private IWebElement xpathnew => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        ProfileMethods profileMethods => new ProfileMethods();

        
        [Test, Order(1), Description("Profile --> Availability")]
        public void TestCaseAvailability()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            
                User user = users.users.ElementAt(0);
                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
                Thread.Sleep(2000);
            for (int i = 0; i < 2; i++)
            {
                profileMethods.profileEditButtonAvailability(i);
            }
            
        }
        [Test, Order(2), Description("Profile --> Hours")]
        public void TestCaseHours()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            
                User user = users.users.ElementAt(0);

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
                Thread.Sleep(2000);
            for (int i = 0; i < 3; i++)
            {
                profileMethods.profileEditButtonHours(i);
            }
        }
        [Test, Order(3), Description("Profile --> Earn Target")]
        public void TestCaseEarnTarget()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            
                User user = users.users.ElementAt(0);

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

                Thread.Sleep(200);
                marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
                Thread.Sleep(2000);
                for (int i = 0; i < 3; i++)
                {
                    profileMethods.profileEditButtonEarnTarget(i);
                }
            }
        }

    }



