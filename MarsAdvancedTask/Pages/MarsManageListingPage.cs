using MarsAdvancedTask.Components.LoginPageComponents;
using MarsAdvancedTask.Components.ManageListingsComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{
    public class MarsManageListingPage : MarsDriver
    {
        MarsManageListings manageListings = new MarsManageListings();

        public void deleteListing(string name)
        {
            string dataPath = File.ReadAllText(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData\TestUser1.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            manageListings.marsDeleteListing(user.listingTitleName);
        }
    }
}
