using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class CommentViewModel
    {

        public int? ParentId { get; set; }

        [Display(Name = "نام مستعار")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Sender { get; set; }

        [Display(Name = "متن نظر")]
        [MaxLength(800, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }
    }
}
