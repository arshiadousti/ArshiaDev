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
    public class PostRepository:Repository<Post>,IPost
    {

        public PostRepository(ArshiaDevContext context):base(context)
        {

        }

        public async Task<List<Post>> GetPostBySearch(string name)
        {
            List<Post> posts = await Table.Include(x=>x.Tags).Where(x => x.Title.Contains(name)
            || x.Description.Contains(name)).ToListAsync();
            return posts;
        }
    }
}
