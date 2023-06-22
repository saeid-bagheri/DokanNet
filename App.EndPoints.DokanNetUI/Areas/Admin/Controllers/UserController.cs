using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminRole")]
    public class UserController : Controller
    {
        private readonly IGetUsers _getUsers;
        private readonly IGetUserById _getUserById;
        private readonly IUpdateUser _updateUser;
        private readonly IDeleteUser _deleteUser;
        private readonly IMapper _mapper;

        public UserController(IGetUsers getUsers, IGetUserById getUserById,
                              IUpdateUser updateUser, IDeleteUser deleteUser,
                              IMapper mapper)
        {
            _getUsers = getUsers;
            _getUserById = getUserById;
            _updateUser = updateUser;
            _mapper = mapper;
            _deleteUser = deleteUser;
        }


        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var users = _mapper.Map<List<AdminUserVM>>(await _getUsers.Execute(cancellationToken));
            return View(users);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<AdminUserVM>(await _getUserById.Execute(id, cancellationToken));
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AdminUserVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateUser.Execute(_mapper.Map<UserDto>(model), cancellationToken);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _deleteUser.Execute(id, cancellationToken);
            return RedirectToAction("Index");
        }



    }
}
