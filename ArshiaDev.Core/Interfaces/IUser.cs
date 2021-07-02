using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ArshiaDev.DataAccessLayer.Entities;

namespace ArshiaDev.Core.Interfaces
{
    public interface IUser:IRepository<Users>
    {
        string Writer(int id);
        Task<bool> CheckUserForLogin(string email, string password);
        Task<Users> GetUserByEmail(string email);
        Task<int> GetUserRoleId(string email);
    }
}
