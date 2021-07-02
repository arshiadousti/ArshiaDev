using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Persmissions
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام سطح دسترسی")]
        [MaxLength(20, ErrorMessage = "حداکثر {1} کارکتر مجاز است")]
        public string PermissionName { get; set; }

        //-------- Set Relations------------

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
