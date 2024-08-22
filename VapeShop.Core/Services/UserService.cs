using VapeShop.Core.Abstractions.Users;
using VapeShop.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace VapeShop.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository usersRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IUsersRepository repository , IHttpContextAccessor httpContextAccessor) 
        { 
            usersRepository = repository;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Возвращает пользователя по номеру телефона
        /// </summary>
        /// <param name="Phone">Номер телефона</param>
        public async Task<User> GetByPhone(string Phone)
        {
            return await usersRepository.GetByPhone(Phone);
        }

        /// <summary>
        /// Возвращает пользователя по индетификатору
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        public async Task<User> GetById(long Id)
        {
            return await usersRepository.GetById(Id);
        }

        /// <summary>
        /// Добавляет пользователя в базу
        /// </summary>
        /// <param name="user">Объект User</param>
        public async Task Add(User user)
        {
            await usersRepository.Add(user);
        }

        /// <summary>
        /// Авторизовывает пользователя в системе куки
        /// </summary>
        /// <param name="user">Объект User</param>
        public async Task Authorization(User user)
        {
            var claims = new List<Claim>
            {
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Custom");

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true, 
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(600)
            };

            await _httpContextAccessor.HttpContext.SignInAsync("CookieAuth", claimsPrincipal , authProperties);
        }

        /// <summary>
        /// Возвращает текущего авторизованого пользователя
        /// </summary>
        /// <returns></returns>
        public async Task<User> GetUser()
        {
            var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null)
            {
                var userId = long.Parse(userIdClaim.Value);
                var user = await usersRepository.GetById(userId);
                return user;
            }
            else
            {
                return null;
            }
        }

    }
}
