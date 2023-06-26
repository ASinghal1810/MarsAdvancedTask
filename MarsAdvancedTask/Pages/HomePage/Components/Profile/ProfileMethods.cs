using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Pages.MasterPage.Login;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumExtras;
using OpenQA.Selenium.Support.UI;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile
{
    public class ProfileMethods:MarsDriver
    {
        private IWebElement location => marsDriver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[1]/div/span/i"));
        private IWebElement availability => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement hours => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement earnTarget => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));


        public void profileEditButtonLoc(int i)
        {

                location.Click();
         
        }

        public void profileEditButtonAvailability(int i)
        {

                Thread.Sleep(500);
                availability.Click();
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Availability.json");
                Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
                Profile profile = profiles.profileAvailability.ElementAt(i);
                SelectElement selavail = new SelectElement(marsDriver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select")));
                selavail.SelectByText(profile.Availability);
                //return profile.Availability;
        }
        public void profileEditButtonHours(int i)
        {
                hours.Click();
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Loc.json");
                Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
                Profile profile = profiles.profileHours.ElementAt(i);
                SelectElement selavail = new SelectElement(marsDriver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select")));
                selavail.SelectByText(profile.Hours);
            
        }
        public void profileEditButtonEarnTarget(int i)
        {
                earnTarget.Click();
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Loc.json");
                Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
                Profile profile = profiles.profileEarnTarget.ElementAt(i);
                SelectElement selavail = new SelectElement(marsDriver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select")));
                selavail.SelectByText(profile.EarnTarget);
           
        }
        
    }
}

