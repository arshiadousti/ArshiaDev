using ArshiaDev.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Classes
{
    public class Injection
    {
        private ICategory categoryRepository;
        private IUser userRepository;
        private IPostCategory postCategory;
        private IRolePermission rolePermission;
        private IComment commentRepository;

        public Injection(ICategory _category , IUser _user ,IPostCategory _postCategory,IRolePermission _rolePermission,IComment _comment)
        {
            categoryRepository = _category;
            userRepository = _user;
            postCategory = _postCategory;
            rolePermission = _rolePermission;
            commentRepository = _comment;
        }

        public bool ExistChild(int id)
        {
            return categoryRepository.ExistChild(id);
        }


        public string Writer(int id)
        {
            return userRepository.Writer(id);
        }

        public async Task<bool> SelectedCategory(int categoryId , int postId)
        {
            return await postCategory.SelectedCategory(postId,categoryId);
        }

        public async Task<bool> ExsistRolePermission(int roleId , int permissionId)
        {
            return await rolePermission.ExsistRolePermission(roleId, permissionId);
        }

        public async Task<bool> ExsistsReply( int commentId)
        {
            return await commentRepository.ExsistReply(commentId);
        }
    }
}
