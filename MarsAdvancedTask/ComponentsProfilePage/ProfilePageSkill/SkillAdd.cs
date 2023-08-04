using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MarsAdvancedTask.Drivers;
using MongoDB.Driver;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TechTalk.SpecFlow;

using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Drawing.Text;
using System.Linq.Expressions;
using OpenQA.Selenium.DevTools.V112.Storage;
using OpenQA.Selenium.DevTools.V112.Network;
using System.Runtime.ConstrainedExecution;
using MarsAdvancedTask.ComponentsProfilePage.ProfilePageSkill;

namespace MarsAdvancedTask.ComponentsProfilePage
{
    public class SkillAdd : MarsDriver
    {

        private IWebElement MarsProfilePageSkillsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement MarsProfilePagSkillsAddSkill => marsDriver.FindElement(By.Name("name"));
        private IWebElement MarsProfilePageSkillsSelectSkillLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageSkillsAddButton => marsDriver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));




        private IWebElement addSkillEditText => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement skillLevelEdit => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private IWebElement lastUpdateButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        private IWebElement skillsEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement actualSkillAdd => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private IWebElement confirmationSameSkill => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement actualskillupdate => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement actualSameSkillUpdate => marsDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement actualDel => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));




        AssertNotify pa => new AssertNotify();
        public void marsProfilePageSkillAdd()
        {
            //try
            //{
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            Skills skills = JsonConvert.DeserializeObject<Skills>(dataPath);
            for (int i = 0; i < skills.skills.Count; i++)
            {
                try
                {
                    Skill ski = skills.skills.ElementAt(i);

                    MarsWait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");

                    MarsProfilePageSkillsAddNewButton.Click();

                    Thread.Sleep(3000);
                    MarsProfilePagSkillsAddSkill.SendKeys(ski.Addskill);
                    MarsProfilePageSkillsSelectSkillLevel.SendKeys(ski.Chooselevel);

                    Thread.Sleep(1000);
                    MarsProfilePageSkillsAddButton.Click();



                    Thread.Sleep(3000);

                    string ele = ski.Addskill.Trim();
                    string compNoti = ele + " has been added to your skills";
                    if (pa.assertNotification() == compNoti)
                    {

                        Console.WriteLine("Test " + i + " Successful");
                    }
                    else
                    {

                        Console.WriteLine("Test " + i + " unsuccess ");
                    }
                    //continue;
                    //Console.WriteLine("Pass" + i + "  .....t");


                }
                catch (Exception)
                {
                    Console.WriteLine("Test " + i + "  Not Successful and below message displayed");
                }
            }
        }


       

        public void updateSameSkill()
        {


            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            Skills skills = JsonConvert.DeserializeObject<Skills>(dataPath);
            //click on pen button to edit

            Skill ski = skills.skills.ElementAt(0);

            skillsEditButton.Click();
            addSkillEditText.Clear();
            addSkillEditText.SendKeys(ski.Addskill);
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
            skillLevelEdit.SendKeys(ski.Chooselevel);


            //click on update button
            MarsWait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");

            lastUpdateButton.Click();
            Thread.Sleep(5000);
            if (actualSameSkillUpdate.Text == "This skill is already added to your skill list.")
            {
                Console.WriteLine("Pass skill already exist");
            }
            else
            {
                Console.WriteLine("Actual message and expected message do not match!");
            }

          


        }
    }
}
