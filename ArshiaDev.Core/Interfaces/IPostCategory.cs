using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IPostCategory:IRepository<PostCategory>
    {
        Task<IEnumerable<PostCategory>> GetPostCategoriesByPostId(int id);
        Task<bool> SelectedCategory(int postId , int categoryId);
    }
}
