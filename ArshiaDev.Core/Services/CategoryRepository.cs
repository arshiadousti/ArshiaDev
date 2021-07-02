using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Context;
using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArshiaDev.Core.Services
{
    public class CategoryRepository:Repository<Category>,ICategory
    {

        public CategoryRepository(ArshiaDevContext context):base(context)
        {

        }

        public bool ExistChild(int id)
        {
            return TableNoTracking.Any(x => x.ParentId == id);
        }


        public async Task<List<Category>> GetAllMainCategories()
        {
            return await TableNoTracking.Where(x => x.ParentId == null).ToListAsync();
        }

        public async Task<List<Category>> GetAllSubCategories()
        {
            return await TableNoTracking.Where(x => x.ParentId != null).ToListAsync();
        }
    }
}
