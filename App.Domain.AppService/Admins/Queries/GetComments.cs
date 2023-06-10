using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Queries
{
    public class GetComments : IGetComments
    {
        private readonly ICommentRepository _commentRepository;

        public GetComments(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<CommentDto>> Execute(CancellationToken cancellationToken)
        {
            return await _commentRepository.GetAll(cancellationToken);
        }
    }
}
