using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ArshiaDev.DataAccessLayer.Context;
using ArshiaDev.Core.Services;
using ArshiaDev.Core.Interfaces;
using ArshiaDev.Core.Classes;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ArshiaDev
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();


            #region DB Context

            services.AddDbContext<ArshiaDevContext>(options =>
            {

                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            #endregion

            #region IoC
            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<Injection>();
            services.AddTransient<IRole, RoleRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddTransient<IPost, PostRepository>();
            services.AddTransient<IPostCategory, PostCategoryRepository>();
            services.AddTransient<ITag, TagRepository>();
            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<IGallery, GalleyRepository>();
            services.AddTransient<IPermission, PermissionRepository>();
            services.AddTransient<IRolePermission, RolePermissionRepository>();
            services.AddTransient<IComment, CommentRepository>();
            services.AddTransient<ArshiaDevContext>();

            #endregion


            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan = TimeSpan.FromDays(30); 
            });

            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }

    }
}
