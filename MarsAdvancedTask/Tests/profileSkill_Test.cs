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
    [TestFixture]
    [Parallelizable]
    public class profileSkill_Test:MarsDriver
    {
        marsProfilePageSkill skillPage => new marsProfilePageSkill();

        [Test, Order(1)]
        public void Addskill()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsProfilePageSkillAdd();

        }
        [Test, Order(2)]
        public void sameskill()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.addSameskill();
           
        }
        [Test, Order(3)]
        public void skillEdit()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsProfilePageSkillEdit();
           

        }
        [Test, Order(4)]
        public void sameSkillEdit()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.updateSameSkill();


        }
        [Test, Order(5)]
        public void cancelWithoutEdit()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsSkillEditCancel();


        }
        [Test, Order(6)]
        public void delLastskill()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            skillPage.marsProfilePageSkillDelete();


        }


    }
}
