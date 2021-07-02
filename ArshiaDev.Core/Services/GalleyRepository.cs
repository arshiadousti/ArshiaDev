using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Context;
using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace ArshiaDev.Core.Services
{
    public class GalleyRepository:Repository<Gallery>,IGallery
    {
        public GalleyRepository(ArshiaDevContext context):base(context)
        {
              
        }

        public async Task<List<Gallery>> GetGalleriesByPostId(int postId)
        {
            return await Table.Where(x => x.PostId == postId).ToListAsync();
        }

    }
}
