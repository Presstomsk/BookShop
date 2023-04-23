using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class LoginModel
    {
        [Key]
        public string Email { get; set; } // email will be the username, too        
        public string Password { get; set; }
    }
}