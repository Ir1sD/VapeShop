using Microsoft.AspNetCore.Mvc;
using System;
using VapeShop.Core.Abstractions.Users;
using VapeShop.Core.Models;
using VapeShop.Web.Requests.Users;
using VapeShop.Web.Responses.Users;

namespace VapeShop.Web.Controllers
{
	public class AccountController : Controller
	{
        private IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

		public IActionResult LoginView()
		{
            return View("..\\Account\\Login");
        }

        public async Task<IActionResult> LoginIn(LoginUserResponse response)
        {
            var user = await userService.Get(response.Phone);

            if (user == null)
            {
                var req = new RegisterUserRequest
                {
                    Phone = response.Phone,
                    DateBithDay = new DateTime(DateTime.Today.Year - 18 , DateTime.Today.Month , DateTime.Today.Day)
                };

                return View("..\\Account\\Register" , req);
            }
            var req1 = new LoginUserRequest
            {
                Phone = response.Phone,
                Id = user.Id
            };

            return View("..\\Account\\LoginStep2" , req1);
        }

        public IActionResult LoginStep2(LoginUserResponse response)
        {
            return View("..\\Home\\Index");
        }

        public async Task<IActionResult> RegisterStep2(RegisterUserResponse response)
        {
            var user = VapeShop.Core.Models.User.New(
                Guid.NewGuid(),
                response.FirstName,
                response.Name,
                response.LastName,
                response.Phone,
                response.DateBithDay,
                DateTime.Now);

            await userService.Register(user);

            return View("..\\Home\\Index");
        }

        public IActionResult Register(RegisterUserResponse response)
        {
            var req = new RegisterUserRequest
            { 
                FirstName = response.FirstName,
                Name = response.Name,
                LastName = response.LastName,
                Phone = response.Phone,
                DateBithDay = response.DateBithDay
            };

            return View("..\\Account\\RegisterStep2" , req);
        }

        public bool CheckNumber(string phone)
        {
            if(string.IsNullOrEmpty(phone) || phone.Length != 11)
            {
                return false;
            }

            if (phone[0] != '7' || phone[1] != '9')
            {
                return false;
            }

            if(!long.TryParse(phone , out long n))
            {
                return false;
            }

            return true;
        }

    }
}
