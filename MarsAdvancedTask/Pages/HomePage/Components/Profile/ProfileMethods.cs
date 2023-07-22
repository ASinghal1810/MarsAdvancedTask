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
using System.Drawing;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile
{
    public class ProfileMethods:MarsDriver
    {
        private IWebElement location => marsDriver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[1]/div/span/i"));
        private IWebElement availability => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement hours => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement earnTarget => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        AssertNotify pa => new AssertNotify();

        public void profileEditButtonLoc()
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
           
                if (pa.assertNotification().Trim() == "Availability updated")
                {
                    Console.WriteLine("Test Successful");
                }
                else
                {
                
                Console.WriteLine("Test Not Successful and below message displayed");
                Console.WriteLine(pa.assertNotification().Trim());
                }
        }
        public void profileEditButtonHours(int i)
        {
                Thread.Sleep(500);
                hours.Click();
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Hours.json");
                Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
                Profile profile = profiles.profileHours.ElementAt(i);
                SelectElement selhr = new SelectElement(marsDriver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select")));
                selhr.SelectByText(profile.Hours);
                if (pa.assertNotification().Trim() == "Availability updated")
                {
                    Console.WriteLine("Test Successful");
                }

                else
                    {

                        Console.WriteLine("Test Not Successful and below message displayed");
                        Console.WriteLine(pa.assertNotification().Trim());
                }
        }
        public void profileEditButtonEarnTarget(int i)
        {
                Thread.Sleep(500);
                earnTarget.Click();
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\EarnTarget.json");
                Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
                Profile profile = profiles.profileEarnTarget.ElementAt(i);
                SelectElement selET = new SelectElement(marsDriver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")));
                selET.SelectByText(profile.EarnTarget);
                //pa.profileET();
                if (pa.assertNotification().Trim() == "Availability updated")
                {
                    Console.WriteLine("Test Successful");
                }
                else
                {

                    Console.WriteLine("Test Not Successful and below message displayed");
                    Console.WriteLine(pa.assertNotification().Trim());
            }

        }
        
    }
}

