using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام نقش")]
        [MaxLength(20, ErrorMessage = "حداکثر {1} کارکتر مجاز است")]
        public string RoleName { get; set; }

        //-------- Set Relations------------

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
