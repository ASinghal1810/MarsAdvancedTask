using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Education;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium.DevTools.V111.Profiler;

namespace MarsAdvancedTask.Pages.MasterPage.Login
{
    public class Users
    {
        public List<User> users { get; set; }
        public List<Profile> profile { get; set; }   
    }
}
