using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IRolePermission:IRepository<RolePermission>
    {
        Task<bool> ExsistRolePermission(int roleId, int permissionId);
        Task<List<RolePermission>> GetAllRolePermissionsByRoleId(int roleId);
    }
}
