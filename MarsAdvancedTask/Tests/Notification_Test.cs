using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.NotificationComponents;
using MarsAdvancedTask.Driver;
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
    [TestFixture]
    [Parallelizable]
    public class Notification_Test : MarsDriver
    {
        Login_Test login = new Login_Test();
        MarsNotification notification = new MarsNotification();

        [Test]
        public void markNotificationAsRead()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            login.loginSuccessfully();
            notification.markFirstNotificationAsRead(user.notificationMessage);
        }

    }
}
