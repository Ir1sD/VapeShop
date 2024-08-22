using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VapeShop.Core.Models;

namespace VapeShop.Web.Requests.Users
{
    public class LoginUserRequest
    {
        [Required(ErrorMessage = "Вы точно что то забыли")]
        [Remote(action: "CheckNumber", controller: "Account" , ErrorMessage = "Формат номера: 79xxxxxxxxx")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: User.LENGTH_CODE , MinimumLength = User.LENGTH_CODE , ErrorMessage = "Что то не так")]
        public string Code { get; set; } = string.Empty;
        public Guid Id {  get; set; }

    }
}
