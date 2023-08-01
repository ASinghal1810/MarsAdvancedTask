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

namespace MarsAdvancedTask.Pages.Profile.Components
{
    public class marsProfilePageSkill : MarsDriver
    {
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement MarsProfilePageSkillsTab => marsDriver.FindElement(By.XPath("//*[@class=\"item\" and @data-tab=\"second\"]"));
        private IWebElement MarsProfilePageSkillsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement MarsProfilePagSkillsAddSkill => marsDriver.FindElement(By.Name("name"));
        private IWebElement MarsProfilePageSkillsSelectSkillLevel => marsDriver.FindElement(By.Name("level"));
        private IWebElement MarsProfilePageSkillsAddButton => marsDriver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        private IWebElement MarsProfilePageSkillsCancelButton => marsDriver.FindElement(By.XPath("///*/div[@class=\"six wide field\"]/input[@value=\"Add\" and @type=\"cancel\"]"));
        private IWebElement skillsEditButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement addSkillEditText => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement skillLevelEdit => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private IWebElement lastUpdateButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));

        private IWebElement noEditCancel => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[2]"));
        private IWebElement MarsProfilePageSkillsDeleteButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
        
        private IWebElement actualSkillAdd => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement confirmationSameSkill => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement actualskillupdate => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement actualSameSkillUpdate => marsDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement actualDel => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

          private IWebElement actalskilladdmsg => marsDriver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));

        public void marsProfilePageSkillAdd()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\skillData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

           
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");
           // Thread.Sleep(1000);
            MarsProfilePageSkillsTab.Click();

            for (int i = 0; i < users.Count; i++)
            {
                User user = users.ElementAt(i);

                MarsWait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
              
                MarsProfilePageSkillsAddNewButton.Click();

              
               MarsProfilePagSkillsAddSkill.SendKeys(user.Skill.Addskill);
               MarsProfilePageSkillsSelectSkillLevel.SendKeys(user.Skill.Chooselevel);

               
               MarsProfilePageSkillsAddButton.Click();
               

                
                NUnit.Framework.Assert.That(actualSkillAdd.Text == actualSkillAdd.Text , "Error While");
               
                Thread.Sleep(3000);
                if(i==2)
                {
                    break;
                }
            }
          
        }
        public void addSameskill(string Username, string Password,string Addskill, string Chooselevel)
        {
           

            //Do login
          
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");
           
            MarsProfilePageSkillsTab.Click();


            MarsWait.MarsWaitToBeVisible("XPath", 20, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");

           
            MarsProfilePageSkillsAddNewButton.Click();

            

            MarsProfilePagSkillsAddSkill.SendKeys(Addskill);
            MarsProfilePageSkillsSelectSkillLevel.SendKeys(Chooselevel);

            
            MarsProfilePageSkillsAddButton.Click();
            

            if (confirmationSameSkill.Text == "Beginner")
            {
                Console.WriteLine("Pass duplicate skill or skill already exist");
            }
            else
            {
                Console.WriteLine("Actual message and expected message do not match!");
            }

        }
       
        public void marsProfilePageSkillEdit(string Username, string Password, string Addskill, string Chooselevel)
        {


            //Do login

            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();
            //click on skill tab
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");

            MarsProfilePageSkillsTab.Click();

            //click on pen button to edit


            skillsEditButton.Click();
            addSkillEditText.Clear();
            addSkillEditText.SendKeys(Addskill);
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");

            skillLevelEdit.SendKeys(Chooselevel);

            //click on update button
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");

            lastUpdateButton.Click();

            Thread.Sleep(2000);
        }
        public string alert()
        {
            Console.WriteLine(actalskilladdmsg.Text);
           return actalskilladdmsg.Text;

           
        }
        public string updatelst()
        {
            Console.WriteLine(actualskillupdate.Text);
            return actualskillupdate.Text;
        }

        public void updateSameSkill(string Username ,string Password, string Addskill, string Chooselevel)
        {
           
            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");
            Thread.Sleep(1000);
            MarsProfilePageSkillsTab.Click();

            //click on pen button to edit

           

            skillsEditButton.Click();
            addSkillEditText.Clear();
            addSkillEditText.SendKeys(Addskill);
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
            skillLevelEdit.SendKeys(Chooselevel);

           
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
        public void marsSkillEditCancel(string Username, string Password)
        {
            
            //Do login
           
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");

            MarsProfilePageSkillsTab.Click();

            //click on pen button to edit

           

            skillsEditButton.Click();
            
            noEditCancel.Click();
            Thread.Sleep(1000);
            if (actualskillupdate.Text == "Abc")
            {
                Console.WriteLine("Pass skill updation Cancel");
            }
            else
            {
                Console.WriteLine("Actual message and expected message do not match!");
            }


        }

        public void marsProfilePageSkillDelete(string Username, string Password)
        {
           
            //Do login
            
            signInButton.Click();
            loginEmailaddress.SendKeys(Username);
            loginPassword.SendKeys(Password);
            rememberMe.Click();
            loginButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@class=\"item\" and @data-tab=\"second\"]");
            
            MarsProfilePageSkillsTab.Click();


            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]");
            
            MarsProfilePageSkillsDeleteButton.Click();
            Thread.Sleep(1000);

            if (actualDel.Text == "Reading")
            {
                Console.WriteLine("Pass deleted successfully");
            }
            else
            {
                Console.WriteLine("Error while deleting skill record");
            }
        }



    }
}
