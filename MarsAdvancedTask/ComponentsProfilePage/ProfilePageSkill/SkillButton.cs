using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill
{
  
    public class SkillButton:MarsDriver
    {
        private IWebElement MarsProfilePageSkillsTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"second\"]"));
        public void skillTab()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");

            MarsProfilePageSkillsTab.Click();
        }
    }
}
