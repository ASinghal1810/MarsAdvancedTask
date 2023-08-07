using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RazorEngine;
using static MarsAdvancedTask.Pages.User;

namespace MarsAdvancedTask.Pages
{
    
    public class Users
    {
        public List<User> users { get; set; }
    }
}
