using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ArshiaDev.DataAccessLayer.Entities;
using System.Threading.Tasks;
using System.Threading;

namespace ArshiaDev.DataAccessLayer.Context
{
    public class ArshiaDevContext:DbContext
    {
        public ArshiaDevContext(DbContextOptions<ArshiaDevContext> options):base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Persmissions> Persmissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Gallery> Galleries { get; set; }

        //--------------------------
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
