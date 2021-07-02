using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Context;
using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArshiaDev.Core.Services
{
    public class PermissionRepository:Repository<Persmissions>,IPermission
    {
        public PermissionRepository(ArshiaDevContext context):base(context)
        {

        }
    }
}
