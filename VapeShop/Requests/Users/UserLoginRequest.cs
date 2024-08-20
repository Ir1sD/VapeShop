using System.ComponentModel.DataAnnotations;
using VapeShop.Core.Models;

namespace VapeShop.Web.Requests.Users
{
    public class UserLoginRequest
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(User.MAX_LENGTH_NAME, ErrorMessage = "У вас очень длинная фамилия, мы не сможем ее запомнить")]
        public string FirstName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(User.MAX_LENGTH_NAME, ErrorMessage = "У вас очень длинное имя, мы не сможем ее запомнить")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Вы точно что то забыли")]
        [EmailAddress(ErrorMessage = "Нашу систему не так просто обмануть")]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: 60 , MinimumLength = User.MIN_LENGTH_PASSWORD, ErrorMessage = "Что то не так")]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = "Вы точно что то забыли")]
        public DateTime DateBithDay { get; set; }
    }
}
