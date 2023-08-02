using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Education;
using MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium.DevTools.V111.Profiler;
using MarsAdvancedTask.Pages.MasterPage.Login;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile
{
    public class Profiles
    {
        public List<Profile> profileAvailability { get; set; }
        public List<Profile> profileHours { get; set; }
        public List<Profile> profileEarnTarget { get; set; }
    }
}
