namespace BookShop.Shared
{
    public interface ILoginModel
    {
       string Email { get; set; } // email will be the username, too        
       string Password { get; set; }
    }
}
