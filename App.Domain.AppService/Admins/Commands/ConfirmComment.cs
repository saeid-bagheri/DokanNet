using App.Domain.Core.AppServices.Admins.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class ConfirmComment : IConfirmComment
    {
        private readonly ICommentRepository _commentRepository;

        public ConfirmComment(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Execute(int commentId, CancellationToken cancellationToken)
        {
            await _commentRepository.ConfirmByAdmin(commentId, cancellationToken);
        }
    }
}
