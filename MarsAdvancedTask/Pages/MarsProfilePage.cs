using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Pages
{
    public class MarsProfilePage:MarsDriver
    {
        marsProfilePageCertifications marsProPgCertObj = new marsProfilePageCertifications();
        MarsMasterPage marsMstrPgObj = new MarsMasterPage();
        private int i;

        public void MarsProfilePageAddNewCertification(int key)
        {
            MarsExcelLib.MarsExcelLibPopulateInCollection(testDataPath, "Certifications");
            marsProPgCertObj.marsProfilePageCertificationsAdd(MarsExcelLib.MarsExcelLibReadData(i, "Certificate"), MarsExcelLib.MarsExcelLibReadData(i, "From"), MarsExcelLib.MarsExcelLibReadData(i, "Year"));
                
        }

    }
       
    
}
