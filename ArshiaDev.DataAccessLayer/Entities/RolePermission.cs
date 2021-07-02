using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class RolePermission
    {
        [Key]
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        //----------------- Set Relationals----------------
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("PermissionId")]
        public virtual Persmissions Persmissions { get; set; }

    }
}
