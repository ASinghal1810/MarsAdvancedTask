using MarsAdvancedTask.ComponentsProfilePage.Notifications;
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
    public class Notification_Test:MarsDriver
    {
        Notification notificationObj => new Notification();
        MarsLoginPage loginPage = new MarsLoginPage();
        DashboardButton dashboardButtonObj = new DashboardButton();
        [Test, Order(1)]
        public void loadMoreNotification()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
           
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and Show Less notification");
            loginPage.SignInAction(user.Username, user.Password);
            dashboardButtonObj.dashboardTab();
            notificationObj.notificationSeeAll();
            notificationObj.AssertForLoadMore();

        }
        [Test, Order(2)]
        public void showLessNotification()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and Show Less notification");
            loginPage.SignInAction(user.Username, user.Password);
            dashboardButtonObj.dashboardTab();
            notificationObj.notificationSeeless();
            notificationObj.AssertForSeeless();

        }
    }
}
