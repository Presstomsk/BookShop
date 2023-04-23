using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class LoginResult
    {
        public string? Message { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public bool Success { get; set; }
    }
}