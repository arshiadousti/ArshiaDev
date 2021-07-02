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
    public class UserRepository:Repository<Users>,IUser
    {
        public UserRepository(ArshiaDevContext context) : base(context)
        {

        }



        public async Task<bool> CheckUserForLogin(string email, string password)
        {
            return await TableNoTracking.AnyAsync(x => x.Email == email && x.HashPassword == password);
        }

        public async Task<Users> GetUserByEmail(string email)
        {
            return await Table.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<int> GetUserRoleId(string email)
        {
            int roleId = await Table.Where(x => x.Email == email).Select(x => x.RoleId).FirstOrDefaultAsync();

            return roleId;
        }

        public string Writer(int id)
        {
            return TableNoTracking.FirstOrDefault(x => x.Id == id).Name;
        }
    }
}
