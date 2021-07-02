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
    public class RolePermissionRepository:Repository<RolePermission>,IRolePermission
    {
        public RolePermissionRepository(ArshiaDevContext context):base(context)
        {

        }

        public async Task<bool> ExsistRolePermission(int roleId, int permissionId)
        {
            return await TableNoTracking.AnyAsync(x => x.RoleId == roleId && x.PermissionId == permissionId);
        }

        public async Task<List<RolePermission>> GetAllRolePermissionsByRoleId(int roleId)
        {
            return await Table.Where(x => x.RoleId == roleId).ToListAsync();
        }
    }
}
