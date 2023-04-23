using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class RegModel : LoginModel
    {
        public string ConfirmPwd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; } = Role.Client;
    }
}