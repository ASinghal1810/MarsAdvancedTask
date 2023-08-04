using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.ProfilePage
{
    public class SkillDelete:MarsDriver
    {
        private IWebElement tableSkill => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
        IReadOnlyCollection<IWebElement> rows => tableSkill.FindElements(By.TagName("tr")).ToList();
        public void marsProfilePageSkillDelete()
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(marsDriver, TimeSpan.FromSeconds(20));


                var rowsList = rows.ToList();
                Console.WriteLine(rowsList.Count);
                while (rowsList.Count > 1)
                {
                    IWebElement deleteButton = wait.Until(ExpectedConditions.ElementToBeClickable(rowsList[1].FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/span[2]"))));
                    deleteButton.Click();
                    Thread.Sleep(1000);
                    rowsList = tableSkill.FindElements(By.TagName("tr")).ToList();
                    Thread.Sleep(1000);

                    Console.WriteLine(rowsList.Count);

                }


                int finalRowCount = rowsList.Count;
                int expectedRowCount = 1;
                if (finalRowCount == expectedRowCount)
                {
                    Console.WriteLine("All rows were successfully deleted!");
                }
                else
                {
                    Console.WriteLine("Rows were not deleted properly.");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}

