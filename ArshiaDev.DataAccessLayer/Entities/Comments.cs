using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Comments
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        [ForeignKey("Comment")]
        public int? ParentId { get; set; }

        [Display(Name = "نام مستعار")]
        [MaxLength(20 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Sender { get; set; }

        [Display(Name = "متن نظر")]
        [MaxLength(800, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }

        [Display(Name = "تایید/عدم تایید")]
        public bool IsAccepted { get; set; }

        public DateTime CreateDate { get; set; }

        //------Set Relationals-------
        public virtual Comments Comment { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

    }
}
