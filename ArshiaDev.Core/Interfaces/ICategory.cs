using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface ICategory:IRepository<Category>
    {
        bool ExistChild(int id);
        Task<List<Category>> GetAllMainCategories();
        Task<List<Category>> GetAllSubCategories();
    }
}
