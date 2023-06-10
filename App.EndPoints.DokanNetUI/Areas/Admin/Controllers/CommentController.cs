using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.Services.Admins.Queries;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="AdminRole")]
    public class CommentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetComments _getComments;
        private readonly IConfirmComment _confirmComment;

        public CommentController(IMapper mapper, IGetComments getComments, IConfirmComment confirmComment)
        {
            _mapper = mapper;
            _getComments = getComments;
            _confirmComment = confirmComment;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var comments = _mapper.Map<List<CommentVM>>(await _getComments.Execute(cancellationToken));
            return View(comments);
        }

        public async Task<IActionResult> Confirm(int id, CancellationToken cancellationToken)
        {
            await _confirmComment.Execute(id, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
