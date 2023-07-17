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

        public void marsProfileDecriptionAdd(string profileDescription)
        {
            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(profileDescription);
            descriptionSaveButton.Click();
        }

        public void marsProfileDecriptionEdit(string profileDescription)
        {
            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(profileDescription);
            descriptionSaveButton.Click();
        }

    }
}
