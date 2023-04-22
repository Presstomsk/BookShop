﻿
using System.ComponentModel.DataAnnotations;

namespace BookShop.Shared
{
    public class LoginResult
    {
        public string? Message { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public bool Success { get; set; }
    }
    public class LoginModel
    {
        [Key]
        public string Email { get; set; } // email will be the username, too        
        public string Password { get; set; }       
    }
    public class RegModel : LoginModel
    {        
        public string ConfirmPwd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }       
        public string PostalCode { get; set; }     
        public string Country { get; set; }       
        public string Region { get; set; }        
        public string City { get; set; }        
        public string Street { get; set; }        
        public string House { get; set; }
        public string Room { get; set; }
        public Role Role { get; set; } = Role.Client;
    }

    public enum Role
    {
        Administrator,
        Client
    }
}
