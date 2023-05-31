using MarsAdvancedTask.ComponentsProfilePage;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsAdvancedTask.Testing
{

    public class Nunit:MarsDriver
    {
       
        MarsProfilePage marsProPgObj = new MarsProfilePage();
        MarsMasterPage marsMstrPgObj = new MarsMasterPage();    
      

        [Test, Order(1)]
        
        public void TestCaseOne()
        {
            marsProPgObj.MarsProfilePageAddNewCertification(1);
        }
    }
}


