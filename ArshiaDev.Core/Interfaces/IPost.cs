using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IPost : IRepository<Post>
    {
        Task<List<Post>> GetPostBySearch(string name);
    }
}
