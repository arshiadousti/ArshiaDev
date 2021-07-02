using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class PermissionViewModel
    {
        [Display(Name = "نام سطح دسترسی")]
        [MaxLength(20, ErrorMessage = "حداکثر {1} کارکتر مجاز است")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string PermissionName { get; set; }
    }
}
