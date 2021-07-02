using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Context;
using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Services
{
    public class PostCategoryRepository:Repository<PostCategory>,IPostCategory
    {
        public PostCategoryRepository(ArshiaDevContext context):base(context)
        {

        }

        //public async Task<PostCategory> GetByPostAndCategoryId(int postId, int categoryId)
        //{
        //    return await Table.SingleOrDefaultAsync(x => x.PostId == postId && x.CategoryId == categoryId);
        //}

        public async Task<IEnumerable<PostCategory>> GetPostCategoriesByPostId(int id)
        {
            return await Table.Where(x => x.PostId == id).ToListAsync();
        }

        public async Task<bool> SelectedCategory(int postId,int categoryId)
        {
            return await TableNoTracking.AnyAsync(x => x.CategoryId == categoryId && x.PostId == postId);
        }
    }
}
