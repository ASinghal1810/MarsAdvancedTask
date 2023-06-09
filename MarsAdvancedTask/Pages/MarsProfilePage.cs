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
        MarsProfileSkills skills = new MarsProfileSkills();
        MarsProfileEducation education = new MarsProfileEducation();


        public void profileUserDetail(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            userDetails.setupUserDetails();
        }

    }
}
