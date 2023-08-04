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
    public class NotificationSelect_Test : MarsDriver
    {
        NotificationSelect notificationselObj => new NotificationSelect();
        MarsLoginPage loginPage = new MarsLoginPage();
        DashboardButton dashboardButtonObj = new DashboardButton();

        [Test, Order(1)]
        public void notifSelectUnselect()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            loginPage.SignInAction(user.Username, user.Password);
            dashboardButtonObj.dashboardTab();
            notificationselObj.notificationSelectUnselect();

        }

        [Test, Order(2)]
        public void notifSelectUnselectMulti()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            loginPage.SignInAction(user.Username, user.Password);
            dashboardButtonObj.dashboardTab();
            notificationselObj.notificationSelUnselMultiple();
            notificationselObj.assertforSelect();
            notificationselObj.unSelect();
            notificationselObj.assertforUnselect();
        }
        [Test, Order(3)]
        public void unselectAll()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            loginPage.SignInAction(user.Username, user.Password);
            dashboardButtonObj.dashboardTab();
            notificationselObj.unselAllNotification();

        }


    }
}
