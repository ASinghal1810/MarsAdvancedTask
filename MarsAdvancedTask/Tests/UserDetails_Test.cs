using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.ProfilePageComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarsAdvancedTask.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UserDetails_Test : MarsDriver
    {
        Login_Test login = new Login_Test();
        MarsProfileUserDetails userDetails = new MarsProfileUserDetails();
        MarsProfileLanguages languages = new MarsProfileLanguages();
        MarsProfileDescription profileDescription = new MarsProfileDescription();

        [Test, Order(1)]
        public void addUserDetails()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            ProfileLanguage language1 = user.languages.ElementAt(0);
            ProfileLanguage language2 = user.languages.ElementAt(1);
            ProfileDescription description = user.descriptions.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("User details has been added!!");

            login.loginSuccessfully();
            userDetails.addUserDetails(user.userDetailsUpdateMessage);
            profileDescription.marsProfileDecriptionAdd(description.description);
            languages.marsProfileLanguageAdd(language1.language, language2.language);
        }

        [Test, Order(2)]
        public void editUserDetails()
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            ProfileLanguage language3 = user.languages.ElementAt(2);
            ProfileLanguage language4 = user.languages.ElementAt(3);
            ProfileDescription description = user.descriptions.ElementAt(1);

            MarsExtentReporting.MarsExtentReportingLogInfo("User details has been edited!!");

            login.loginSuccessfully();
            userDetails.editUserDetails(user.userDetailsUpdateMessage);
            profileDescription.marsProfileDecriptionEdit(description.description);
            languages.marsProfileLanguageEdit(language3.language, language4.language);
        }
    }
}
