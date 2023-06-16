using MarsAdvancedTask.Components.SearchSkillsComponents;
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
    public class MarsHomePage : MarsDriver
    {
       MarsSearchSkills searchSkills = new MarsSearchSkills();

        public void searchSkillByUsingOnlineOption(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            searchSkills.goToHomePage();
            searchSkills.searchByOnlineOption();
        }

        public void searchSkillByUsingOnSiteOption(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            searchSkills.goToHomePage();
            searchSkills.searchByOnsiteOption();
        }
    }
}
