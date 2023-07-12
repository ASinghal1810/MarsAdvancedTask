using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Tests
{

    [TestFixture]
    [Parallelizable]
    public class Chat_Test:MarsDriver
    {
        ChatHistory chatObj = new ChatHistory();
        [Test, Order(1)]
        public void newUserChatRoom()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and chatroom created for new user to chat");
            chatObj.createChatRoom();
        }
        [Test, Order(2)]
        public void selectUserFromChatRoom()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and select user from chat room for chat");
            chatObj.openConversationSelectedUser();
        }

    }
}
