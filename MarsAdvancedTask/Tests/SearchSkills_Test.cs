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
    public class SearchSkills_Test : MarsDriver
    {
        Login_Test login = new Login_Test();
        MarsHomePage homePage = new MarsHomePage();

        [Test, Order(1)]
        public void searchSkillOnlineOption()
        {
            login.loginSuccessfully();
            homePage.searchSkillByUsingOnlineOption("Search Skill by using Filter Online Option!");
        }

        [Test, Order(2)]
        public void searchSkillOnSiteOption()
        {
            login.loginSuccessfully();
            homePage.searchSkillByUsingOnSiteOption("Search Skill by using Filter On-Site Option!");
        }

    }
}
