using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VapeShop.Core.Models;

namespace VapeShop.Web.Requests.Users
{
    public class RegisterUserRequest
    {
        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: User.MAX_LENGTH_NAME, ErrorMessage = "Ваша Фамилия довольно длинное. Мы ее не запомним")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: User.MAX_LENGTH_NAME, ErrorMessage = "Ваше Имя довольно длинное. Мы его не запомним")]
        public string Name {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: User.MAX_LENGTH_NAME , ErrorMessage = "Ваше Отчество довольно длинное. Мы его не запомним")]
        public string LastName {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Вы точно что то забыли")]
        public DateTime DateBithDay {  get; set; }

        public string Phone {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Вы точно что то забыли")]
        [StringLength(maximumLength: User.LENGTH_CODE, MinimumLength = User.LENGTH_CODE, ErrorMessage = "Что то не так")]
        public string Code {  get; set; } = string.Empty;

    }
}
