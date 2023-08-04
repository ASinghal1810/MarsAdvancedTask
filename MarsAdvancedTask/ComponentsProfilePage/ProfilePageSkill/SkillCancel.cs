using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill
{
    public class SkillCancel:MarsDriver
    {
        private IWebElement skillsEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement addSkillEditText => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement skillLevelEdit => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private IWebElement MarsProfilePageSkillsCancelButton => marsDriver.FindElement(By.XPath("///*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"cancel\"]"));
        private IWebElement noEditCancel => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
        IReadOnlyCollection<IWebElement> rows => tableSkill.FindElements(By.TagName("tr")).ToList();
        private IWebElement tableSkill => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
        public void marsSkillEditCancel()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            Skills skills = JsonConvert.DeserializeObject<Skills>(dataPath);
            Skill ski = skills.skills.ElementAt(0);
            //click on pen button to edit
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
            skillsEditButton.Click();
            addSkillEditText.Clear();
            addSkillEditText.SendKeys(ski.Addskill);
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");

            skillLevelEdit.SendKeys(ski.Chooselevel);

            noEditCancel.Click();
            Thread.Sleep(1000);

            IWebElement lastRow = rows.Last();

            // Extract the text from the last row
            string lastRowText = lastRow.Text;
            Console.WriteLine(lastRowText);
            string expectedText = lastRowText;
            Console.WriteLine(expectedText);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedText, lastRowText, "Last row text does not match the expected text");


        }
    }
}
