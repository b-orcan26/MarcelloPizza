using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NicePageRestaurant.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IUrunService urunService;
        private readonly IMapper mapper;
        private readonly IUserService userService;
        public AdminController(IUrunService _urunService , IMapper _mapper , IUserService _userService)
        {
            urunService = _urunService;
            mapper = _mapper;
            userService = _userService;

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = userService.LoginUser(model.Username, model.Password);
                if (user != null)
                {
                    var userClaims = new List<Claim>() { new Claim(ClaimTypes.Name, model.Username) };                 
                    var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    HttpContext.SignInAsync(userPrincipal);
                    return RedirectToAction("Index","Urun",null);
                }
            }
            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            return View(model);
        }





    }
}
