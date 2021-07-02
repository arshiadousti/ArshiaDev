using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshiaDev.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {
        DbSet<TEntity> Entities { get; }
        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> TableNoTracking { get; }

        //-------------

        Task AddAsync(TEntity entity, bool saveNow = true);
        Task AddRangeAsync(IEnumerable<TEntity> entity, bool saveNow = true);
        Task DeleteAsync(TEntity entity, bool saveNow = true);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities , bool saveNow = true);
        Task UpdateAsync(TEntity entity, bool saveNow = true);
        Task<TEntity> GetById(int id);
        TEntity Get(int id);
        Task<IEnumerable<TEntity>> ShowAll();
    }
}
