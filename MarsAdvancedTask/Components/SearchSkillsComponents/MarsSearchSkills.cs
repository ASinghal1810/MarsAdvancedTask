﻿using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.SearchSkillsComponents
{
    public class MarsSearchSkills : MarsDriver
    {
        private IWebElement searchBarTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]/div/input"));
        private IWebElement searchButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]/div/button"));
        private IWebElement filterOnlineOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]"));
        private IWebElement filterOnsiteOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]"));
        private IWebElement filterShowAllOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[3]"));
        private IWebElement firstSkill => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img"));
        private IWebElement locationType => marsDriver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]"));

        public void searchByOnlineOption(string skill, string typeOfLocation)
        {
            searchBarTextBox.SendKeys(skill);
            searchButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]");
            filterOnlineOption.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img");
            firstSkill.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 5, "//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]");
            if(locationType.Text == typeOfLocation)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual Location Type and expected Location Type do not match!");
            }
        }

        public void searchByOnsiteOption(string skillName, string typeOfLocation)
        {
            searchBarTextBox.SendKeys(skillName);
            searchButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]");
            filterOnsiteOption.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img");
            firstSkill.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 5, "//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]");
            if (locationType.Text == typeOfLocation)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual Location Type and expected Location Type do not match!");
            }
        }
    }
}
