using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class GalleryViewModel
    {
        [Display(Name ="تصویر")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public IFormFile Image { set; get; }

        public string ImageName { get; set; }
    }
}
