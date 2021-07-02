using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArshiaDev.DataAccessLayer.Entities
{
    public class PostCategory
    {
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }

        public int CategoryId { get; set; }

        //-----Set Relationals------
        [ForeignKey("PostId")]
        public virtual Post Posts { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
