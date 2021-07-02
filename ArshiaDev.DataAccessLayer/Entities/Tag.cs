using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کارکتر باشد")]
        [Display(Name = "نام کلمه کلیدی")]
        public string TagName { get; set; }

        public int PostId { get; set; }

        //--------Relations---------
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }


    }
}
