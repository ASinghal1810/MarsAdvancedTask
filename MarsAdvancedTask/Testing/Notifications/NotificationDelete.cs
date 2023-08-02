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
using System.Runtime.ConstrainedExecution;

namespace MarsAdvancedTask
{
    [TestFixture]
    [Parallelizable]

    public class NotificationDelete : MarsDriver
    {

        MarsMasterPage marsMstrPgObj => new MarsMasterPage();

        MarsHomePage mhpg => new MarsHomePage();

        Notification notify => new Notification();
        LoginMethods lMObj => new LoginMethods();

        

        [Test, Order(1), Description("Manage Listings --> Edit ")]
        public void notificationDelete()
        {         
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
            Thread.Sleep(200);
            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
            Thread.Sleep(2000);
            mhpg.manageDashboardComponentButton();
            notify.marsNotificationDelete();
            

        }

    }
}

