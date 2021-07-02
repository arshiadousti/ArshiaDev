using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام دسته بندی")]
        [MaxLength(30, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }

        //------- Set Relationals-------
        public virtual Category Parent { get; set; }

        public virtual ICollection<PostCategory> PostCategories { get; set; }

    }
}
