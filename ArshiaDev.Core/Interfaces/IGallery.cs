using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IGallery:IRepository<Gallery>
    {
        Task<List<Gallery>> GetGalleriesByPostId(int postId);
    }
}
