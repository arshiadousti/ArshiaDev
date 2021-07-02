using ArshiaDev.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArshiaDev.Core.Classes
{
    public class Attribute : AuthorizeAttribute, IAuthorizationFilter
    {
        int permissionId = 0;
        IUser userRepository;
        IRolePermission rolePermissionRepository;

        public Attribute(int permissionID)
        {
            permissionId = permissionID;
        }

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                userRepository = (IUser)context.HttpContext.RequestServices.GetService(typeof(IUser));
                rolePermissionRepository = (IRolePermission)context.HttpContext.RequestServices.GetService(typeof(IRolePermission));

                string email = context.HttpContext.User.Identity.Name;

                int roleId = await userRepository.GetUserRoleId(email);
                if (!await rolePermissionRepository.ExsistRolePermission(roleId, permissionId))
                {
                    context.Result = new RedirectResult("/Login");
                    
                }

            }
            else
            {
                 context.Result = new RedirectResult("/Login");
            }
        }

    }
}
