using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RazorEngine;

namespace MarsAdvancedTask.Pages
{
    // [JsonObject]
    //public class User
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public List<profileSkill> skills { get; set; }
    // //   public string Chooselevel { get; internal set; }
    //  //  public string Addskill { get; internal set; }
    //}
    //public class profileSkill
    //{
    //    public string Addskill { get; set; }
    //    public string Chooselevel { get; set; }
    //}
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Skill Skill { get; set; }
       
        public SkillUpdate SkillUpdate { get; set; }
        public SameSkillUpdate SameSkillUpdate { get; set; }
        public SearchSkill SearchSkill { get; set; }
    }
    public class Skill
    {
        public string Addskill { get; set; }
        public string Chooselevel { get; set; }
    }

    public class SkillUpdate
    {
        public string Addskill { get; set; }
        public string Chooselevel { get; set; }

    }
    public class SameSkillUpdate
    {
        public string Addskill { get; set; }
        public string Chooselevel { get; set; }

    }
    public class SearchSkill
    {
        public string EnterSkill { get; set; }
    }



}
