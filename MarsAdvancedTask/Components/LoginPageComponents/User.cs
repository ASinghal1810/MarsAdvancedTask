using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Components.LoginPageComponents
{
    public class User
    {
        public string emailAddress { get; set; }
        public string password { get; set; }
        public List<ProfileDescription> descriptions { get; set; }
        public List<ProfileLanguage> languages { get; set; }
        public List<ProfileSearchSkills> searchSkills { get; set; }
    }

    public class ProfileDescription
    {
        public string description { get; set; }
    }

    public class ProfileLanguage
    {
        public string language { get; set; }
    }

    public class ProfileSearchSkills
    {
        public string skill { get; set; }

    }
}
