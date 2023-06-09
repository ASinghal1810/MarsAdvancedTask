using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ProfilePageComponents
{
    public class MarsProfileSkills : MarsDriver
    {
        // Skills Action
        private IWebElement skillsTag => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement skillsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement skillTextBox => marsDriver.FindElement(By.Name("name"));
        private IWebElement skillLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement intermediateOption => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement skillAddButton => marsDriver.FindElement(By.XPath("//*[@id=>\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        public void SkillsAction()
        {
            // Identify the Skill tag and click on it
            skillsTag.Click();
            // Idenfity the Add New Button and click on it
            skillsAddNewButton.Click();
            // Fill up the skill form
            skillTextBox.SendKeys("MusicSince");
            // Select the Intermediate option
            skillLevel.Click();
            intermediateOption.Click();
            // Identify the add button and click on it
            skillAddButton.Click();
        }
    }
}
