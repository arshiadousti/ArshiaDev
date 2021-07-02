using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }

        [Display(Name = "تصویر")]
        [MaxLength(200 , ErrorMessage ="بیشتر از حد مجاز!")]
        public string ImageName { get; set; }

        //-------Set Relationals------
        [ForeignKey("PostId")]
        public virtual Post Posts { get; set; }
    }
}
