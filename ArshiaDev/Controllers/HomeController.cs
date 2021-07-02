using ArshiaDev.Core.Interfaces;
using ArshiaDev.Core.ViewModels;
using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArshiaDev.Controllers
{
    public class HomeController : Controller
    {
        private IComment commentRepository;
        private IPost postRepository;
        private ITag tagRepository;

        public HomeController(IComment _comment, IPost _post, ITag _tag)
        {
            commentRepository = _comment;
            postRepository = _post;
            tagRepository = _tag;
        }
        //----------------------------------------------------

        public IActionResult Index()
        {
            return View();
        }



        #region Post
        public async Task<IActionResult> AllPosts()
        {
            return View(await postRepository.ShowAll());
        }

        public async Task<IActionResult> Posts(int id)
        {
            Post post = await postRepository.GetById(id);
            List<Tag> tags = await tagRepository.ShowAllTagsByPostId(id);
            ViewBag.PostId = id;

            ShowPostViewModel viewModel = new ShowPostViewModel()
            {
                FillPost = post,
                FillTags = tags
            };

            return View(viewModel);
        }

        #endregion

        #region Comment

        public async Task<IActionResult> ShowAllPostsComment(int id)
        {
            IEnumerable<Comments> comments = await commentRepository.GetCommentsByPostId(id);

            return View(comments);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment(int id,int? ParentId,string sender,string message )
        {
            if (sender != null && message != null)
            {

                Comments comments = new Comments()
                {
                    PostId = id,
                    ParentId = ParentId,
                    Text = message,
                    Sender = sender,
                    CreateDate = DateTime.Now,
                    IsAccepted = false
                };

                await commentRepository.AddAsync(comments);
                return Redirect("/Home/Posts/" + id);
            }

            return View();
        }


        #endregion


    }
}
