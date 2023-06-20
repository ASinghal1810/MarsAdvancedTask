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
        public List<SkillListing> skillListings { get; set; }
        
    }
    public class SkillListing
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<ShareSkillTag> tags { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public List<ShareSkillExchangeTag> skillExchangeTags { get; set; }
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

    public class ShareSkillTag
    {
        public string tag { get; set; }
    }

    public class ShareSkillExchangeTag
    {
        public string skillExchangeTag { get; set; }
    }
}
