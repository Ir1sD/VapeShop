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
        /// <summary>
        /// Максимально допустимое значение для фамилии, имени и отчеству
        /// </summary>
        public const int MAX_LENGTH_NAME = 30;

        /// <summary>
        /// Длинна проверочного кода
        /// </summary>
        public const int LENGTH_CODE = 6;

        private User()
        {

        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string FirstName { get; private set; } = string.Empty;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; private set; } = string.Empty;

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; private set; } = string.Empty;

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime DateReg { get; private set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBithDay { get; private set; }


        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="firstName">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="email">Почта</param>
        /// <param name="password"> Хеш пароля</param>
        /// <param name="dateBithDay">Дата рождения</param>
        /// <param name="Id">Идентификатор</param>
        /// <returns>Объект пользователя</returns>
        public static User New(
            string firstName , 
            string name , 
            string lastName,
            string phone,
            DateTime dateBithDay,
            DateTime dateReg,
            long Id = 0)
        {
            var user = new User()
            {
                FirstName = firstName,
                Name = name,
                LastName = lastName,
                Phone = phone,
                DateBithDay = dateBithDay,
                DateReg = dateReg,
                Id = Id
            };

            return user;
        }
    }
}
