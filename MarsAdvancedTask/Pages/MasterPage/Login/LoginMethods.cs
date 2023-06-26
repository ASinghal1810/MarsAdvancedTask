using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MarsAdvancedTask.Pages.MasterPage.Login
{
    public class LoginMethods
    {
        public string userUsername(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);

            return user.Username;
        }
        public string userPassword(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);

            return user.Password;
        }
    }
}
