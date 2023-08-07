using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MarsAdvancedTask.Tests
{

    [TestFixture]
    [Parallelizable]
    public class Chat_Test : MarsDriver
    {
        ChatHistory chatObj = new ChatHistory();
        MarsLoginPage loginPage = new MarsLoginPage();
        [Test, Order(1)]
        public void newUserChatRoom()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials");
            loginPage.SignInAction(user.Username, user.Password);
           
            chatObj.createChatRoom();
        }
        [Test, Order(2)]
        public void selectUserFromChatRoom()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select user from chat room for chat");
            loginPage.SignInAction(user.Username, user.Password);
            chatObj.openConversationSelectedUser();
        }

    }
}
