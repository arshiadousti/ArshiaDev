using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Entities;
using ArshiaDev.Core.ViewModels;
using System.IO;
using ArshiaDev.Core.Classes;
using Post = ArshiaDev.DataAccessLayer.Entities.Post;
using System.Collections;
using Attribute = ArshiaDev.Core.Classes.Attribute;
using X.PagedList;

namespace ArshiaDev.Controllers
{
    [Attribute(2)]
    public class AdminController : Controller
    {
        //-------------------------------------------------------------------------------------------------
        private IRole roleRepository;
        private ICategory categoryRepository;
        private IPost postRepository;
        private IPostCategory postCategoryRepository;
        private ITag tagRepository;
        private IGallery galleryRepository;
        private IPermission permissionRepository;
        private IRolePermission rolePermissionReposiotry;
        private IComment commentRepository;

        public AdminController(IRole _role, ICategory _category, IPost _post, IPostCategory _postCategory,
            ITag _tag, IGallery _gallery, IPermission _permission,IRolePermission _rolePermission,IComment _comment)
        {
            roleRepository = _role;
            categoryRepository = _category;
            postRepository = _post;
            postCategoryRepository = _postCategory;
            tagRepository = _tag;
            galleryRepository = _gallery;
            permissionRepository = _permission;
            rolePermissionReposiotry = _rolePermission;
            commentRepository = _comment;
        }
        //-------------------------------------------------------------------------------------------------

        #region Role
        public async Task<IActionResult> ShowAllRoles()
        {
            return View(await roleRepository.ShowAll());
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Role role = new Role()
                {
                    RoleName = viewModel.RoleName
                };

                await roleRepository.AddAsync(role);
                return RedirectToAction(nameof(ShowAllRoles));
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(int id)
        {
            Role role = await roleRepository.GetById(id);


            RoleViewModel viewModel = new RoleViewModel()
            {
                RoleName = role.RoleName
            };

            return View(viewModel);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(RoleViewModel viewModel, int id)
        {
            if (ModelState.IsValid)
            {
                Role role = await roleRepository.GetById(id);

                role.RoleName = viewModel.RoleName;

                await roleRepository.UpdateAsync(role);

                return RedirectToAction(nameof(ShowAllRoles));
            }

            return View(viewModel);
        }

        public async Task DeleteRole(int id)
        {
            Role role = await roleRepository.GetById(id);

            await roleRepository.DeleteAsync(role);
        }

        #endregion

        #region Permission
        public async Task<IActionResult> ShowAllPermissions()
        {
            return View(await permissionRepository.ShowAll());
        }

        [HttpGet]
        public IActionResult AddPermission()
        {
            ViewBag.PermissionError = false;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(PermissionViewModel viewModel)
        {
            ViewBag.PermissionError = false;
            if (ModelState.IsValid)
            {
                Persmissions persmissions = new Persmissions()
                {
                    PermissionName = viewModel.PermissionName
                };
                await permissionRepository.AddAsync(persmissions);
                return RedirectToAction(nameof(ShowAllPermissions));
            }

            ViewBag.PermissionError = true;
            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> EditPermission(int id)
        {
            ViewBag.PermissionError = false;
            Persmissions persmissions = await permissionRepository.GetById(id);

            PermissionViewModel viewModel = new PermissionViewModel()
            {
                PermissionName = persmissions.PermissionName
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditPermission(PermissionViewModel viewModel,int id)
        {
            ViewBag.PermissionError = false;
            if (ModelState.IsValid)
            {
                Persmissions persmissions = await permissionRepository.GetById(id);
                persmissions.PermissionName = viewModel.PermissionName;
                await permissionRepository.UpdateAsync(persmissions);
                return RedirectToAction(nameof(ShowAllPermissions));
            }

            ViewBag.PermissionError = true;
            return RedirectToAction(nameof(ShowAllPermissions));
        }

        public async Task DeletePermission(int id)
        {
            Persmissions persmission = await permissionRepository.GetById(id);

            await permissionRepository.DeleteAsync(persmission);
        }

        #endregion

        #region RolePermission
        [HttpGet]
        public async Task<IActionResult> RolePermissions(int id)
        {
            // id = role id

            ViewBag.RolePermissionError = false;
            ViewBag.roleId = id;
            return View(await permissionRepository.ShowAll());
        }

        [HttpPost]
        public async Task<IActionResult> RolePermissions(int id , List<int> permissionsId)
        {
            // id = role id

            ViewBag.RolePermissionError = false;
            if (permissionsId.Count > 0)
            {
                // First, We have to Delete the older one.
                List<RolePermission> oldRolePermissions = await rolePermissionReposiotry.GetAllRolePermissionsByRoleId(id);
                await rolePermissionReposiotry.DeleteRangeAsync(oldRolePermissions);
                //----------------------------------

                List<RolePermission> TemporaryRolePermission = new List<RolePermission>();
                foreach (int permissionId in permissionsId)
                {
                    RolePermission rolePermission = new RolePermission()
                    {
                        RoleId = id,
                        PermissionId = permissionId
                    };
                    TemporaryRolePermission.Add(rolePermission);
                }

                await rolePermissionReposiotry.AddRangeAsync(TemporaryRolePermission);
                return RedirectToAction(nameof(ShowAllRoles));
            }

            ViewBag.RolePermissionError = true;
            ViewBag.roleId = id;
            return View(await permissionRepository.ShowAll());
        }
        #endregion

        #region Category
        public async Task<IActionResult> ShowAllCategory()
        {
            ShowAllCategoriesViewModel viewModel = new ShowAllCategoriesViewModel
            {
                GetAllSubCategories = await categoryRepository.GetAllSubCategories(),
                GetAllMainCategories = await categoryRepository.GetAllMainCategories()
            };

            return View(viewModel);
        }


        public async Task<IActionResult> ShowCategory(int id)
        {
            return View(await categoryRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult AddMainCategory(int? id)
        {
            ViewBag.parentCategoryId = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMainCategory(CategoryViewModel viewModel, int? id)
        {
            if (ModelState.IsValid && viewModel.Name != null)
            {
                Category category = new Category()
                {
                    Name = viewModel.Name,
                    ParentId = id
                };
                await categoryRepository.AddAsync(category);
                ViewBag.CategoryError = false;
                return RedirectToAction(nameof(ShowAllCategory));
            }
            ViewBag.CategoryError = true;
            return RedirectToAction(nameof(ShowAllCategory));
        }


        [HttpGet]
        public IActionResult EditMainCategory(int id)
        {
            Category category = categoryRepository.Get(id);

            CategoryViewModel viewModel = new CategoryViewModel()
            {
                Name = category.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMainCategory(CategoryViewModel viewModel, int id)
        {
            if (ModelState.IsValid && viewModel.Name != null)
            {
                Category category = categoryRepository.Get(id);
                category.Name = viewModel.Name;

                await categoryRepository.UpdateAsync(category);
                ViewBag.CategoryError = false;
                return RedirectToAction(nameof(ShowAllCategory));
            }
            ViewBag.CategoryError = true;
            return RedirectToAction(nameof(ShowAllCategory));
        }


        public async Task DeleteCategory(int id)
        {
            Category category = categoryRepository.Get(id);

            await categoryRepository.DeleteAsync(category);
        }

        #endregion

        #region Post

        public async Task<IActionResult> ShowAllPosts()
        {
            return View(await postRepository.ShowAll());
        }

        [HttpGet]
        public async Task<IActionResult> AddPost()
        {
            IEnumerable<Category> categories = await categoryRepository.ShowAll();
            PostViewModel viewModel = new PostViewModel()
            {
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(PostViewModel viewModel, List<int> postCat)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Image != null)
                {
                    if (postCat.Count > 0)
                    {

                        viewModel.ImageName = CodeGenerator.FileCode() + Path.GetExtension(viewModel.Image.FileName);
                        string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                            "wwwroot/Images/Posts/",
                            viewModel.ImageName);


                        Post post = new Post()
                        {
                            StickToTheTop = viewModel.StickToTheTop,
                            Text = viewModel.Text,
                            UserId = 1,
                            Title = viewModel.Title,
                            Description = viewModel.Description,
                            ImageName = viewModel.ImageName,
                            IsShared = viewModel.IsShared,
                            CreateDate = DateTime.Now
                        };
                        await postRepository.AddAsync(post);


                        foreach (int item in postCat)
                        {
                            Category category = await categoryRepository.GetById(item);


                            PostCategory postCategory = new PostCategory()
                            {
                                CategoryId = item,
                                PostId = post.Id
                            };

                            await postCategoryRepository.AddAsync(postCategory);

                            if (category.ParentId != null)
                            {

                                PostCategory postCategory2 = new PostCategory()
                                {
                                    CategoryId = Convert.ToInt32(category.ParentId),
                                    PostId = post.Id
                                };

                                await postCategoryRepository.AddAsync(postCategory2);
                            }

                        }
                        ViewBag.SelectedCategoryIsNull = false;


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await viewModel.Image.CopyToAsync(stream);
                        }


                        if (viewModel.Tags != null)
                        {
                            string[] tags = viewModel.Tags.Split('،');

                            foreach (var item in tags)
                            {
                                Tag tag = new Tag()
                                {
                                    PostId = post.Id,
                                    TagName = item
                                };
                                await tagRepository.AddAsync(tag);
                            }
                        }

                        return RedirectToAction(nameof(ShowAllPosts));


                    }
                    else
                    {
                        ViewBag.SelectedCategoryIsNull = true;
                        viewModel.Categories = await categoryRepository.ShowAll();
                        return View(viewModel);
                    }
                }
                else
                {
                   // ViewBag.SelectedCategoryIsNull = true;
                    viewModel.Categories = await categoryRepository.ShowAll();
                    ModelState.AddModelError("Image", "لطفا تصویر را وارد کنید");
                    return View(viewModel);
                }
            }

            //ViewBag.SelectedCategoryIsNull = true;
            viewModel.Categories = await categoryRepository.ShowAll();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditPost(int id)
        {
            Post post = await postRepository.GetById(id);
            List<Tag> tags = await tagRepository.ShowAllTagsByPostId(id);
            IEnumerable<Category> categories = await categoryRepository.ShowAll();
            string postTags = string.Join('،', tags.Select(x=>x.TagName));
            ViewBag.PostId = id;

            PostViewModel viewModel = new PostViewModel()
             {
                 Title = post.Title,
                 StickToTheTop = post.StickToTheTop,
                 IsShared = post.IsShared,
                 Description = post.Description,
                 ImageName = post.ImageName,
                 Text = post.Text,
                 Categories = categories,
                 Tags = postTags
             };


            return View(viewModel);
        }

        // postCat = the chekclist ids of categories.
        [HttpPost]
        public async Task<IActionResult> EditPost(PostViewModel viewModel , int id , List<int> postCat)
        {
            ViewBag.SelectedCategoryIsNull = false;
            List<Tag> postTags = await tagRepository.ShowAllTagsByPostId(id);
            //Get Current Post To Find It's Image Name.
            Post curentPost = await postRepository.GetById(id);
            
            if (ModelState.IsValid)
            {

                if (postCat.Count() > 0)
                {
                    Post post = await postRepository.GetById(id);
                    if (viewModel.Image != null)
                    {
                        //------Post-------
                        viewModel.ImageName = CodeGenerator.FileCode() + Path.GetExtension(viewModel.Image.FileName);
                        string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                            "wwwroot/Images/Posts",
                            viewModel.ImageName);

                        

                        post.Description = viewModel.Description;
                        post.IsShared = viewModel.IsShared;
                        post.Text = viewModel.Text;
                        post.Title = viewModel.Title;
                        post.StickToTheTop = viewModel.StickToTheTop;
                        post.ImageName = viewModel.ImageName;

                        await postRepository.UpdateAsync(post);

                        using (var stream = new FileStream(filePath,FileMode.Create))
                        {
                            await viewModel.Image.CopyToAsync(stream);
                        }

                        //-------Post------

                      

                    }
                    else
                    {

                        post.Description = viewModel.Description;
                        post.IsShared = viewModel.IsShared;
                        post.Text = viewModel.Text;
                        post.Title = viewModel.Title;
                        post.StickToTheTop = viewModel.StickToTheTop;

                        await postRepository.UpdateAsync(post);
                    }


                    //---------Category---------
                    IEnumerable<PostCategory> postCategories = await postCategoryRepository.GetPostCategoriesByPostId(post.Id);
                    await postCategoryRepository.DeleteRangeAsync(postCategories);

                    List<PostCategory> newPostCategories = new List<PostCategory>();
                    // For Parent Category
                    List<PostCategory> newParentPostCategories = new List<PostCategory>();
                    Category category;

                    foreach (var item in postCat)
                    {
                        category = await categoryRepository.GetById(item);

                        PostCategory postCategory = new PostCategory()
                        {
                            PostId = post.Id,
                            CategoryId = item
                        };
                        newPostCategories.Add(postCategory);

                        if (category.ParentId != null)
                        {
                            PostCategory postParentCategory = new PostCategory()
                            {
                                PostId = post.Id,
                                CategoryId = Convert.ToInt32(category.ParentId)
                            };
                            newParentPostCategories.Add(postParentCategory);
                        }

                    }
                    await postCategoryRepository.AddRangeAsync(newPostCategories);
                    await postCategoryRepository.AddRangeAsync(newParentPostCategories);

                    //---------Category---------

                    //-----------Tag-----------

                    //First, We have to delete old tags 
                    if (viewModel.Tags != null)
                    {
                        IEnumerable<Tag> oldTags = await tagRepository.GetTagsByPostId(id);
                        List<Tag> newTags = new List<Tag>();
                        await tagRepository.DeleteRangeAsync(oldTags);

                        string[] tags = viewModel.Tags.Split('،');
                        foreach (var item in tags)
                        {
                            Tag tag = new Tag()
                            {
                                PostId = post.Id,
                                TagName = item
                            };
                            newTags.Add(tag);
                        }
                        await tagRepository.AddRangeAsync(newTags);

                    }
                    //-----------Tag-----------

                    return RedirectToAction(nameof(ShowAllPosts));
                }
                else
                {
                 
                    ViewBag.SelectedCategoryIsNull = true;
                    viewModel.Categories = await categoryRepository.ShowAll();
                    viewModel.Tags = string.Join('،', postTags.Select(x => x.TagName));
                    viewModel.ImageName = curentPost.ImageName;
                    ViewBag.PostId = id;
                    return View(viewModel);
                }
            }


            viewModel.Categories = await categoryRepository.ShowAll();
            viewModel.Tags = string.Join('،',postTags.Select(x=>x.TagName));
            viewModel.ImageName = curentPost.ImageName;
            ViewBag.PostId = id;
            return View(viewModel);
        }

        #endregion

        #region Gallery


        public async Task<IActionResult> ShowAllPostGallery(int id)
        {
            IEnumerable<Gallery> galleries = await galleryRepository.GetGalleriesByPostId(id);
            return View(galleries);
        }

        [HttpGet]
        public IActionResult AddGallery(int id)
        {
            ViewBag.PostId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGallery(GalleryViewModel viewModel , int id)
        {
            if (ModelState.IsValid)
            {
                viewModel.ImageName = CodeGenerator.FileCode() + Path.GetExtension(viewModel.Image.FileName);

                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/Images/Galleries/",
                    viewModel.ImageName);

                Gallery gallery = new Gallery()
                {
                    ImageName = viewModel.ImageName,
                    PostId = id,
                };
                await galleryRepository.AddAsync(gallery);

                using (var stream = new FileStream(filePath,FileMode.Create))
                {
                    await viewModel.Image.CopyToAsync(stream);
                }


            }
            ModelState.AddModelError("Image", "لطفا تصویر را آپلود کنید");
            ViewBag.PostId = id;
            return View();
        }

        //id == GalleryId
        public async Task<IActionResult> DeleteGallery(int id)
        {
            Gallery gallery = await galleryRepository.GetById(id);
            int postId = gallery.PostId;
            await galleryRepository.DeleteAsync(gallery);

            return Redirect("/Admin/AddGallery/" + postId);
        }

        #endregion

        #region Comment

        public async Task<IActionResult> ShowAllComments()
        {
            return View(await commentRepository.ShowAll());
        }

        public async Task AcceptComment(int id)
        {
            await commentRepository.ManageComment(id,"Accept");
        }

        public async Task DeclineComment(int id)
        {
            await commentRepository.ManageComment(id, "Decline");
        }

        #endregion

    }
}
