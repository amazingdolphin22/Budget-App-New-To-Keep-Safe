using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginModel()
        {

        }

        public LoginModel(string u, string p)
        {
            UserName = u;
            Password = p;
        }

        public static List<LoginModel> GetCredentials()
        {
            return new List<LoginModel>()
            {
                new LoginModel("User1", "Password1"),
                new LoginModel("User2", "Password2"),
                new LoginModel("User3", "Password3")
            };
        }
    }
}
