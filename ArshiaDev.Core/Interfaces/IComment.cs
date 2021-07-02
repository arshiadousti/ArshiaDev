using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IComment:IRepository<Comments>
    {
        Task<List<Comments>> GetCommentsByPostId(int postId);
        Task<bool> ExsistReply(int commentId);
        Task ManageComment(int id , string type);
    }
}
