using MarsAdvancedTask.Components.ManageListingsComponents;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Microsoft.Office.Interop.Excel;
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
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            manageListings.marsDeleteListing();
        }
    }
}
