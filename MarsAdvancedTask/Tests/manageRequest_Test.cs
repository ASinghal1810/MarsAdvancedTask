using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using MarsAdvancedTask.Pages.ManageRequest;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Tests
{
    public class manageRequest_Test:MarsDriver
    {
        manageRequestReceived manageReqObj = new manageRequestReceived();

        [Test, Order(1)]
        public void acceptReq()
        {

            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and accept request");
            manageReqObj.receiveReqAccept(user.Username,user.Password);


        }
        [Test, Order(2)]
        public void declineReq()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\manageRequest_Data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);
            
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and decline request");
            manageReqObj.reqDecline(user.Username, user.Password);


        }
    }
}
