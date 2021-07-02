using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArshiaDev.Core.Interfaces;
using ArshiaDev.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ArshiaDev.DataAccessLayer.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace ArshiaDev.Controllers
{
    public class AccountController : Controller
    {

        private IUser userRepository;
        private IComment commentRepository;

        public AccountController(IUser _user,IComment _comment )
        {
            userRepository = _user;
            commentRepository = _comment;
        }


        #region Accounting

        [Route("/Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (await userRepository.CheckUserForLogin(viewModel.Email, viewModel.Password))
            {
                Users user = await userRepository.GetUserByEmail(viewModel.Email);

                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.Email)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, properties);
                return RedirectToAction("ShowAllPosts", "Admin");
            }
            else
            {
                ModelState.AddModelError("Email", "نام کاربری یا کلمه عبور نادرست است");
                return View();
            }
        }

        [Route("/Logout")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }


        #endregion
        [Authorize]
        public string Test()
        {
            return "Your Program is doing well!";
        }





    }
}
