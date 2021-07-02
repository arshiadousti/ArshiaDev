using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public int RoleId { get; set; }

        [Display(Name = "نام کاربری")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Username { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [MaxLength(30, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        public string Name { get; set; }


        public string HashPassword { get; set; }

        //------------ Set Relationals-------------
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
