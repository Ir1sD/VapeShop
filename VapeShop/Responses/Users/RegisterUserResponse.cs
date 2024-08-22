using System.ComponentModel.DataAnnotations;

namespace VapeShop.Web.Responses.Users
{
    public class RegisterUserResponse
    {
        public string FirstName { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateBithDay { get; set; }

        public string Phone { get; set; } = string.Empty;
        public string Code {  get; set; } = string.Empty;
    }
}
