using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.NotificationComponents;
using MarsAdvancedTask.Components.ProfilePageComponents;
using MarsAdvancedTask.Components.ShareSkillComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarsAdvancedTask.Pages
{
    public class MarsProfilePage : MarsDriver
    {
        MarsProfileUserDetails userDetails = new MarsProfileUserDetails();
        MarsProfileLanguages languages = new MarsProfileLanguages();
        MarsProfileDescription profileDescription = new MarsProfileDescription();
        MarsProfileSkills skills = new MarsProfileSkills();
        MarsProfileEducation education = new MarsProfileEducation();
        MarsShareSkills shareSkills = new MarsShareSkills();

        private IWebElement userDropDownList => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement goToProfileOption => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[1]"));
        private IWebElement shareSkillButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));

        public void goToProfilePage()
        {
            userDropDownList.Click();
            goToProfileOption.Click();
        }

        public void createNewListing(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            SkillListing skillListing1 = user.skillListings.ElementAt(0);
            ShareSkillTag shareSkillTag1 = skillListing1.tags.ElementAt(0);
            ShareSkillTag shareSkillTag2 = skillListing1.tags.ElementAt(1);
            ShareSkillExchangeTag skillExchangeTag1 = skillListing1.skillExchangeTags.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            shareSkillButton.Click();
            shareSkills.ShareSkillAction(skillListing1.title, skillListing1.description, shareSkillTag1.tag, shareSkillTag2.tag, skillListing1.startDate, skillListing1.endDate, skillListing1.startTime, skillListing1.endTime, shareSkillTag1.tag);
        }

        public void addProfileUserDetail(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileLanguage language1 = user.languages.ElementAt(0);
            ProfileLanguage language2 = user.languages.ElementAt(1);
            ProfileDescription description = user.descriptions.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);

            userDetails.addUserDetails(user.userDetailsUpdateMessage);
            profileDescription.marsProfileDecriptionAdd(description.description);
            languages.marsProfileLanguageAdd(language1.language, language2.language);
        }
        public void editProfileUserDetail(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            ProfileLanguage language3 = user.languages.ElementAt(2);
            ProfileLanguage language4 = user.languages.ElementAt(3);
            ProfileDescription description = user.descriptions.ElementAt(1);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);

            userDetails.editUserDetails(user.userDetailsUpdateMessage);
            profileDescription.marsProfileDecriptionEdit(description.description);
            languages.marsProfileLanguageEdit(language3.language, language4.language);
        }
    }
}
