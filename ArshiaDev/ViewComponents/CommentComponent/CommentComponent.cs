using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArshiaDev.ViewComponents.CommentComponent
{
    public class CommentComponent:ViewComponent
    {
        private IComment commentRepository;
        public CommentComponent(IComment _comment)
        {
            commentRepository = _comment;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Comments> comments = await commentRepository.GetCommentsByPostId(id);
            return await Task.FromResult((IViewComponentResult)View("CommentComponent",comments));
        }
    }
}
