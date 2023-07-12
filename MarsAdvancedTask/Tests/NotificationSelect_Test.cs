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
    public class NotificationSelect_Test:MarsDriver
    {
        NotificationSelect notificationselObj => new NotificationSelect();
       
        [Test, Order(1)]
        public void notifSelectUnselect()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.notificationSelectUnselect();

        }

        [Test, Order(2)]
        public void notifSelectUnselectMulti()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.notificationSelUnselMultiple();

        }
        [Test, Order(3)]
        public void unselectAll()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select 1st notification and unselect notification");
            notificationselObj.unselAllNotification();

        }


    }
}
