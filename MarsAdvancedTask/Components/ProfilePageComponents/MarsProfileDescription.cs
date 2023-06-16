using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Driver;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.ProfilePageComponents
{
    public class MarsProfileDescription : MarsDriver
    {
        private IWebElement descriptionPenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private IWebElement descriptionTextArea => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement descriptionSaveButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

        public void marsProfileDecriptionAdd()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            ProfileDescription description = user.descriptions.ElementAt(0);

            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(description.description);
            descriptionSaveButton.Click();
        }

        public void marsProfileDecriptionEdit()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            ProfileDescription description = user.descriptions.ElementAt(1);

            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(description.description);
            descriptionSaveButton.Click();
        }

    }
}
