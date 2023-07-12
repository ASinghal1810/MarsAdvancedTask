using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
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
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and Show Less notification");
            notificationObj.notificationSeeAll();

        }
    }
}
