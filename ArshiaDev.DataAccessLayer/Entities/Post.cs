using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "موضوع")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name = "توضیح کوتاه درباره مقاله")]
        [MaxLength(200, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را بنویسید حتما! ")]
        public string Text { get; set; }

        [Display(Name = "بچسبد به بالای صفحه")]
        public bool StickToTheTop { get; set; }

        [Display(Name = "انتشار در وبلاگ")]
        public bool IsShared { get; set; }

        [Display(Name = "تاریخ انتشار")]
        public DateTime CreateDate { get; set; }

        //------Set Relationals----------
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }

        public virtual ICollection<PostCategory> PostCategories { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
