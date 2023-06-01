using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegisterUser _registerUser;
        private readonly ILoginUser _loginUser;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(IRegisterUser registerUser, ILoginUser loginUser,
                            SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _registerUser = registerUser;
            _mapper = mapper;
            _signInManager = signInManager;
            _loginUser = loginUser;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var resultRegister = await _registerUser.Execute(_mapper.Map<UserDto>(model), cancellationToken);
                if (resultRegister.Succeeded)
                {
                    var resultLogin = await _loginUser.Execute(_mapper.Map<UserDto>(model), cancellationToken);
                    if (resultLogin.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(string.Empty, "خطا در ورود به سایت");
                }
                else
                {
                    foreach (var item in resultRegister.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }
            return View(model);
        }


        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var result = await _loginUser.Execute(_mapper.Map(model, new UserDto()), cancellationToken);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "خطا در ورود به سایت");
                }

            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
