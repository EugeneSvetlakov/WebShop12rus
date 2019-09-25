using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.ViewModels
{
    public class CategoryViewModel : INamedEntity, IOrderedEntity
    {
        public CategoryViewModel()
        {
            ChildCategories = new List<CategoryViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        /// <summary>
        /// Список дочерних категорий
        /// </summary>
        public List<CategoryViewModel> ChildCategories { get; set; }

        /// <summary>
        /// Родительская категория
        /// </summary>
        public CategoryViewModel ParentCategory { get; set; }
    }
}
