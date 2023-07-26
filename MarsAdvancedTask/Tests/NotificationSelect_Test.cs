using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using MarsAdvancedTask.Pages.Dashboard;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Tests
{
    public class NotificationSelect_Test:MarsDriver
    {
        NotificationSelect notificationselObj => new NotificationSelect();
       
        [Test, Order(1)]
        public void notifSelectUnselect()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.notificationSelectUnselect(user.Username,user.Password);

        }

        [Test, Order(2)]
        public void notifSelectUnselectMulti()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.notificationSelUnselMultiple(user.Username, user.Password);

        }
        [Test, Order(3)]
        public void unselectAll()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.unselAllNotification(user.Username, user.Password);

        }


    }
}
