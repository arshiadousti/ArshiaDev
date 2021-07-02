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
    public class RoleRepository: Repository<Role>,IRole
    {
        public RoleRepository(ArshiaDevContext context):base(context)
        {
              
        }

        //public async Task<List<Role>> GetAllRoles()
        //{
        //    return await Table.ToListAsync();
        //}

        
    }
}
