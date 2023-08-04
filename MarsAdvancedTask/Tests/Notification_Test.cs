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
        [Test, Order(1)]
        public void showLessNotification()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and Show Less notification");
            notificationObj.notificationSeeAll(user.Username,user.Password);

        }
    }
}
