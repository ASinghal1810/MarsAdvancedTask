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
    public class manageRequest_Test:MarsDriver
    {
        manageRequestReceived manageReqObj = new manageRequestReceived();

        [Test, Order(1)]
        public void acceptReq()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and accept request");
            manageReqObj.receiveReqAccept();


        }
        [Test, Order(2)]
        public void declineReq()
        {
            MarsExtentReporting.MarsExtentReportingLogInfo("Login with valid credentials and decline request");
            manageReqObj.reqDecline();


        }
    }
}
