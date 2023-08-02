using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages.HomePage.Components.Profile;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages.HomePage.Search_Skills
{
    public class SkillSearch:MarsDriver
    {
        private IWebElement marsLogo => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
        private IWebElement programmingAndTech => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/section[1]/div/div[2]/div/div[2]/div[2]/a/img"));
        private IWebElement dataAnalysisAndReports => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]"));
        private IWebElement skillSelect => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]/p"));

        private IWebElement skillFound => marsDriver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));

        public void skillToSearch(string skill, string category, string subCategory)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\SearchSkill.json");
            SearchSkills searchskills = JsonConvert.DeserializeObject<SearchSkills>(dataJson);
            SearchSkill sSkill = searchskills.searchskills.ElementAt(0);
            marsLogo.Click();
            if (sSkill.Category == category)
            {
                MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"home\"]/div/section[1]/div/div[2]/div/div[2]/div[2]/a/img");
                programmingAndTech.Click();
                if(sSkill.SubCategory == subCategory)
                {
                    MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]");
                    dataAnalysisAndReports.Click();
                    MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]/p");
                    skillSelect.Click();
                    if (sSkill.Skill==skillFound.Text.Trim())
                    {
                        
                        Console.WriteLine("Skill Found");
                    }
                    else
                    {
                        Console.WriteLine("Skill Not Found");
                    }
                }
            }

        }
    }
}
