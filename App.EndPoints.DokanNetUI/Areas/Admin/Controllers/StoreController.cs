using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "AdminRole")]
    public class StoreController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetStores _getStores;
        private readonly IGetStoreById _getStoreById;
        private readonly IUpdateStore _updateStore;
        private readonly ICloseStore _closeStore;

        public StoreController(IMapper mapper, IGetStores getStores, IGetStoreById getStoreById,
                               IUpdateStore updateStore, ICloseStore closeStore)
        {
            _mapper = mapper;
            _getStores = getStores;
            _getStoreById = getStoreById;
            _updateStore = updateStore;
            _closeStore = closeStore;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var stores = _mapper.Map<List<AdminStoreVM>>(await _getStores.Execute(cancellationToken));
            return View(stores);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<AdminStoreVM>(await _getStoreById.Execute(id, cancellationToken));
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AdminStoreVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateStore.Execute(_mapper.Map<StoreDto>(model), cancellationToken);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _closeStore.Execute(id, cancellationToken);
            return RedirectToAction("Index");
        }

    }
}
