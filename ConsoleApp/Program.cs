using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concretes;

namespace ConsoleApp
{
    class Program
    {
        private static ICategoryManager _categoryManager;
        static void Main(string[] args)
        {
            CategoryManagerTest();
        }
        private static void CategoryManagerTest()
        {
            ICategoryDal categoryDal = new CategoryDal();
            _categoryManager = new CategoryManager(categoryDal);

            AllCategory();
            ListCategoryById(1);
            AddCategory();
            DeleteCategory();
            AllCategory();
            UpdateCategory();
            AllCategory();
        }
        private static void AllCategory()
        {
            List<Category> categories = new List<Category>();
            categories = _categoryManager.GetAll();
            foreach (Category category in categories)
            {
                Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}");
            }
        }
        private static void ListCategoryById(int id)
        {
            Category categories = _categoryManager.Get(id);
            Console.WriteLine($"Category Name: {categories.Name}");
        }
        private static void AddCategory()
        {
            Category category1 = new Category { Id = 4, Name = "History"};
            _categoryManager.Add(category1);
            Console.WriteLine("Category added successfully.");
        }
        private static void DeleteCategory()
        {
            Category category1 = new Category { Id = 2, Name = "Physical" };
            _categoryManager.Delete(category1);
        }
        private static void UpdateCategory()
        {
            Category categories = new Category { Id = 4, Name = "Turkish" };
            _categoryManager.Update(categories);
        }
        
    }
}