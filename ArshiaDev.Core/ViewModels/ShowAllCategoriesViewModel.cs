using ArshiaDev.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArshiaDev.Core.ViewModels
{
    public class ShowAllCategoriesViewModel
    {
        public List<Category> GetAllMainCategories { set; get; }

        public List<Category> GetAllSubCategories { set; get; }
    }
}
