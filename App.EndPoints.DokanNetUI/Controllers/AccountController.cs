using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegisterUser _registerUser;
        private readonly ILoginUser _loginUser;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IGetUserRolesByUserName _getUserRolesByUserName;


        private readonly IMapper _mapper;

        public AccountController(IRegisterUser registerUser, ILoginUser loginUser,
                                 SignInManager<AppUser> signInManager, IMapper mapper,
                                 IGetUserRolesByUserName getUserRolesByUserName)
        {
            _registerUser = registerUser;
            _mapper = mapper;
            _signInManager = signInManager;
            _loginUser = loginUser;
            _getUserRolesByUserName = getUserRolesByUserName;
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
                    return RedirectToAction("Login", "Account");
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
                    //check this user role is Admin or not?!
                    if ((await _getUserRolesByUserName.Execute(model.UserName, cancellationToken)).Contains("AdminRole"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
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
