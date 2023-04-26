
namespace BookShop.Shared
{
    public interface IRegModel
    {
        public string Email { get; set; }       
        public string Password { get; set; }
        string ConfirmPwd { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        Role Role { get; set; }
    }
}
