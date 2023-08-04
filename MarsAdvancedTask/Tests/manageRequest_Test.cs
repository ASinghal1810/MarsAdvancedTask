using MarsAdvancedTask.ComponentsProfilePage.ManageRequests;
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

namespace MarsAdvancedTask.Tests
{
    public class manageRequest_Test:MarsDriver
    {
        manageRequestReceivedAccept manageReqObj = new manageRequestReceivedAccept();
        MarsLoginPage loginPage = new MarsLoginPage();
        ManageRequestButton manageObj = new ManageRequestButton();
        ManageRequestDecline declineObj = new ManageRequestDecline();
        [Test, Order(1)]
        public void acceptReq()
        {

            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and accept request");
            loginPage.SignInAction(user.Username, user.Password);
            manageObj.manageRequestTab();
            manageReqObj.receiveReqAccept();


        }
        [Test, Order(2)]
        public void declineReq()
        {
            string dataPath = File.ReadAllText(@"C:\Users\jeelp\OneDrive\Desktop\AdvanceTask\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Logindata.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);

            User user = users.ElementAt(0);
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and decline request");
            loginPage.SignInAction(user.Username, user.Password);
            manageObj.manageRequestTab();
            declineObj.reqDecline();




        }
    }
}
