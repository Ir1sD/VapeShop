using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeShop.Core.Models
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User
    {
        public const int MAX_LENGTH_NAME = 40;
        public const int MIN_LENGTH_PASSWORD = 6;
        private User()
        {

        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string FirstName { get; private set; } = string.Empty;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; private set; } = string.Empty;

        /// <summary>
        /// Хеш пароля
        /// </summary>
        public string Password { get; private set; } = string.Empty;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBithDay { get; private set; }


        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="firstName">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="email">Почта</param>
        /// <param name="password"> Хеш пароля</param>
        /// <param name="dateBithDay">Дата рождения</param>
        /// <returns>Объект пользователя</returns>
        public static User New(Guid id , 
            string firstName , 
            string name , 
            string email, 
            string password, 
            DateTime dateBithDay)
        {
            var user = new User()
            {
                Id = id,
                FirstName = firstName,
                Name = name,
                Email = email,
                Password = password,
                DateBithDay = dateBithDay
            };

            return user;
        }
    }
}
