using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class CategoryDal : ICategoryDal
    {
        private static List<Category> _categories = new List<Category>();
        public CategoryDal() 
        { 
            _categories = new List<Category> 
            {
                new Category { Id = 1, Name = "Programming" },
                new Category { Id = 2, Name = "Physical" },
                new Category { Id = 3, Name = "English" }
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryDelete = new Category();
            categoryDelete = _categories.FirstOrDefault(p => p.Id == category.Id);
            if (categoryDelete != null) 
            {
                _categories.Remove(categoryDelete);
            }
            
        }

        public Category Get(int categoryId)
        {
            Category category = new Category();
            category = _categories.FirstOrDefault(p => p.Id == categoryId);
            return category;
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryUpdate = new Category();
            categoryUpdate = _categories.FirstOrDefault(p => p.Id == category.Id);
            categoryUpdate.Id = category.Id;
            categoryUpdate.Name = category.Name;
        }
    }
}
