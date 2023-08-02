using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Skill
{
    public class marsProfilePageSkill : MarsDriver
    {
        private IWebElement MarsProfilePageSkillsTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"second\"]"));
        private IWebElement MarsProfilePageSkillsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement MarsProfilePagSkillsAddSkill => marsDriver.FindElement(By.Name("name"));
        private IWebElement MarsProfilePageSkillsSelectSkillLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageSkillsAddButton => marsDriver.FindElement(By.XPath("//*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"button\"]"));
        private IWebElement MarsProfilePageSkillsCancelButton => marsDriver.FindElement(By.XPath("///*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"cancel\"]"));
        private IWebElement MarsProfilePageSkillsEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private IWebElement MarsProfilePageSkillsDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));




        public void marsProfilePageSkillAdd()
        {

        }

        public void marsProfilePageSkillEdit()
        {

        }

        public void marsProfilePageSkillDelete()
        {

        }



    }
}
