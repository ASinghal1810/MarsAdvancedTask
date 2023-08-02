using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;

namespace MarsAdvancedTask.Pages.MasterPage.Login
{
    public class ProfileAssertion : MarsDriver
    {
        private static IWebElement logoutText => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        private static string notificationXPath => "/html/body/div[1]";
        private static IWebElement notificationText => marsDriver.FindElement(By.XPath("/html/body/div[1]"));
        private static IWebElement closeHower => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]"));
        private static IWebElement logout => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));


        public void assertLogin(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);
            Thread.Sleep(5000);
            try
            {


                if (logoutText.Text == "Sign Out")
                {

                    if (user.ExpectedResult == "Success")
                    {
                        i = i + 1;
                        Console.WriteLine("Test 1." + i + " is Successfull");
                        logout.Click();
                    }
                    else
                    {
                        i = i + 1;
                        Console.WriteLine("Test 1.", i, " is Unsuccessfull");
                        logout.Click();
                    }

                }
            }
            catch (NoSuchElementException)
            {
                if (user.ExpectedResult == "Success")
                {
                    i = i + 1;
                    Console.WriteLine("Test 1." + i + " is Unsuccessfull");
                    marsDriver.Navigate().Refresh();
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine("Test 1." + i + " is Successfull");
                    marsDriver.Navigate().Refresh();
                }


            }

        }
    }
}
