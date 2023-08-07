﻿using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage
{
    public class ChatHistory:MarsDriver
    {
       
        private IWebElement searchTab => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/input"));
        private IWebElement searchButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
        private IWebElement selectuser => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[7]/div[1]"));
        private IWebElement chatButton => marsDriver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a/i"));

        private IWebElement chatRoom => marsDriver.FindElement(By.XPath("//*[@id=\"chatList\"]/div[2]/div[2]/div[1]"));
        private IWebElement Chat => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[1]"));
        private IWebElement selectUserChat => marsDriver.FindElement(By.XPath("//*[@id=\"chatList\"]/div[4]/div[2]/div[1]"));
        private IWebElement lastMsgCheck => marsDriver.FindElement(By.XPath("//*[@id=\"right\"]/div"));
        public void createChatRoom()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\ChatHistory_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
           
            MarsWait.MarsWaitToBeClickable("XPath", 10, " //*[@id=\"account-profile-section\"]/div/div[1]/div[1]/input");
            searchTab.Click();
            searchTab.SendKeys(user.SearchSkill.EnterSkill);
           
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i");
            
            searchButton.Click();
            
            //Choose User from learning skill from list of users
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[7]/div[1]");
            
            selectuser.Click();

           
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a/i");
            Thread.Sleep(1000); 
            chatButton.Click();


           MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"chatList\"]/div[2]/div[2]/div[1]");
            Thread.Sleep(1000); 
            chatRoom.Click();
            if (chatRoom.Text=="sweety")
            {
                Console.WriteLine("Pass chat room is created with user sweety patel");
            }
            else
            {
                Console.WriteLine("User not found in chatroom");
            }



        }
        public void openConversationSelectedUser()
        {
           
            //click on chat
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[1]");
          
            Chat.Click();

            //choose user
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"chatList\"]/div[4]/div[2]/div[1]");
           
            selectUserChat.Click();

            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"right\"]/div");
            
            lastMsgCheck.Click();
            if (lastMsgCheck.Text== "hi i cant accept your skill sorry")
            {
                Console.WriteLine("selected user chat is open");
            }
            else
            {
                Console.WriteLine("Its is not conversation of appropriate user");
            }

            

        }
    }
}