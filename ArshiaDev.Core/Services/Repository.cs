using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ArshiaDev.Core.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ArshiaDev.DataAccessLayer.Context;
namespace ArshiaDev.Core.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //------------------------
        public ArshiaDevContext context;
        public DbSet<TEntity> Entities { get; }
        public virtual IQueryable<TEntity> Table => Entities;
        public virtual IQueryable<TEntity> TableNoTracking => Table.AsNoTracking();
        //-------------------------

        //-------------------------

        public Repository(ArshiaDevContext _context)
        {
            context = _context;
            Entities = context.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity entity, bool saveNow = true)
        {
            if(entity != null)
            {
                await Entities.AddAsync(entity);
                if (saveNow)
                    await context.SaveChangesAsync();
                    
            }
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entity, bool saveNow = true)
        {
            if(entity != null)
            {
                await Entities.AddRangeAsync(entity);

                if (saveNow)
                    await context.SaveChangesAsync();
            }
        }

        public virtual async Task DeleteAsync(TEntity entity, bool saveNow = true)
        {
            if(entity != null)
            {
                 Entities.Remove(entity);

                if (saveNow)
                    await context.SaveChangesAsync();
            }
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, bool saveNow = true)
        {
            if (entities != null)
            {
                Entities.RemoveRange(entities);

                if (saveNow)
                    await context.SaveChangesAsync();
            }
        }




        public virtual async Task UpdateAsync(TEntity entity, bool saveNow = true)
        {
            if(entity != null)
            {
                Entities.Update(entity);

                if (saveNow)
                   await context.SaveChangesAsync();
            }
        }

         public virtual async Task<IEnumerable<TEntity>> ShowAll()
        {
            return await Entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await Entities.FindAsync(id);
        }

        public TEntity Get(int id)
        {
            return Entities.Find(id);
        }
    }
}
