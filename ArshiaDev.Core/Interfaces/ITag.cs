using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface ITag:IRepository<Tag>
    {
        Task<List<Tag>> ShowAllTagsByPostId(int id);
        Task<IEnumerable<Tag>> GetTagsByPostId(int postId);
    }
}
