using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Pages;
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
        MarsLoginPage loginPage = new MarsLoginPage();
        MarsProfilePage profilePage = new MarsProfilePage();

        [Test]
        public void markNotificationAsRead()
        {
            loginPage.loginSuccessfully("Login Successfully!");
            profilePage.notificationMarkAsRead("First Notification has been marked as read!");
        }

    }
}
