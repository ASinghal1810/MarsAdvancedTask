using MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MongoDB.Bson.IO;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow.CommonModels;

namespace MarsAdvancedTask.ComponentsProfilePage.ProfilePage
{
    public class SkillEdit : MarsDriver
    {
        private IWebElement skillsEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement addSkillEditText => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement skillLevelEdit => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private IWebElement lastUpdateButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));

        AssertNotify pa = new AssertNotify();
     
     
        public void marsProfilePageSkillEdit()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            Skills skills = Newtonsoft.Json.JsonConvert.DeserializeObject<Skills>(dataPath);
            
            try
            {
                Skill ski = skills.skills.ElementAt(0);
                //click on pen button to edit
                skillsEditButton.Click();
                addSkillEditText.Clear();
                addSkillEditText.SendKeys(ski.Addskill);
                MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");

                skillLevelEdit.SendKeys(ski.Chooselevel);

                //click on update button
                MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");

                lastUpdateButton.Click();
                string compNoti = ski.Addskill + " has been updated to your skills";
                // Console.WriteLine(compNoti);
                
                if (pa.assertNotification() == compNoti)
                {
                    Console.WriteLine("Test Successful");
                 
                }
                else
                {

                    Console.WriteLine("Test Not Successful and below message displayed");
                    Console.WriteLine(pa.assertNotification().Trim());
                }


            }

            catch (NoSuchElementException)
            {
            }
        }

    }


}