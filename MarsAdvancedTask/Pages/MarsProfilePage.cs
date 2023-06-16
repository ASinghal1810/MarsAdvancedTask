using MarsAdvancedTask.Components.NotificationComponents;
using MarsAdvancedTask.Components.ProfilePageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{
    public class MarsProfilePage : MarsDriver
    {
        MarsProfileUserDetails userDetails = new MarsProfileUserDetails();
        MarsProfileLanguages languages = new MarsProfileLanguages();
        MarsProfileDescription description = new MarsProfileDescription();
        MarsProfileSkills skills = new MarsProfileSkills();
        MarsProfileEducation education = new MarsProfileEducation();
        MarsNotification notification = new MarsNotification();


        public void addProfileUserDetail(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);

            userDetails.addUserDetails();
            description.marsProfileDecriptionAdd();
            languages.marsProfileLanguageAdd();
        }
        public void editProfileUserDetail(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);

            userDetails.editUserDetails();
            description.marsProfileDecriptionEdit();
            languages.marsProfileLanguageEdit();
        }

        public void notificationMarkAsRead(string name)
        {
            notification.markFirstNotificationAsRead();
        }
    }
}
