using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class ShowPostViewModel
    {
        public Post FillPost { get; set; }
        public List<Tag> FillTags { get; set; }
    }
}
