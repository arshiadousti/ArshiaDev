using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class PostViewModel
    {
        [Display(Name = "تصویر")]
        public IFormFile Image { get; set; }

        [MaxLength(60)]
        public string ImageName { set; get; }

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

        public IEnumerable<Category> Categories { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }
    }
}
