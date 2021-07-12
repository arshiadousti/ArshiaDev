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
    public class TagRepository:Repository<Tag>,ITag
    {
        public TagRepository(ArshiaDevContext context):base(context)
        {
              
        }

        public async Task<List<Post>> GetPostByTagSearch(string name)
        {
            List<Post> posts = await Table.Where(x => x.TagName.Contains(name)).Select(x=>x.Post).ToListAsync();

            return posts;
        }

        public async Task<IEnumerable<Tag>> GetTagsByPostId(int postId)
        {
            return await Table.Where(x => x.PostId == postId).ToListAsync();
        }

        public async Task<List<Tag>> ShowAllTagsByPostId(int id)
        {
            return await Table.Where(x=>x.PostId == id).ToListAsync();
        }
    }
}
