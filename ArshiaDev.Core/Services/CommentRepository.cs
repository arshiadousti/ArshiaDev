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
    public class CommentRepository:Repository<Comments>,IComment
    {
        public CommentRepository(ArshiaDevContext context):base(context)
        {

        }

        public async Task<bool> ExsistReply(int commentId)
        {
            return await TableNoTracking.AnyAsync(x => x.ParentId == commentId && x.IsAccepted);
        }

        public async Task<List<Comments>> GetCommentsByPostId(int postId)
        {
            return await Table.Where(x => x.PostId == postId && x.IsAccepted).ToListAsync();
        }

        public async Task ManageComment(int id , string type)
        {
            Comments comment = await Table.FirstOrDefaultAsync(x => x.Id == id);

            if (type == "Accept")
            {
                comment.IsAccepted = true;
            }
            else
            {
                comment.IsAccepted = false;
            }

            await context.SaveChangesAsync();
        }
       

    }
}
