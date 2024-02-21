using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class CourseDal : ICourseDal
    {
        private static List<Course> _courses;
        private static List<Category> _categories;
        private static List<Instructor> _instructor;
        public CourseDal() 
        {
            var _instructor = new Instructor() { Id = 1, Name = "Engin Demiroğ" };
            var _category = new Category() { Id = 1, Name = "Programming" };
            
            _courses = new List<Course>
            {
                new Course{Id=1,Instructor = _instructor,Category = _category,  Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=2,Instructor = _instructor,Category = _category,  Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=3,Instructor = _instructor,Category = _category,  Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python &amp; Selenium", Description = "Python &amp; Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=4,Instructor = _instructor,Category = _category,  Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA", Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=5,Instructor = _instructor,Category = _category,  Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=6,Instructor = _instructor,Category = _category,  Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=7,Instructor = _instructor,Category = _category,  Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız"},
                new Course{Id=8,Instructor = _instructor,Category = _category,  Name = "Programlamaya Giriş için Temel Kurs", Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin"}
            };
        }


        
        public void Add(Course course)
        {
             _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseDelete = new Course();
            courseDelete = _courses.FirstOrDefault(p => p.Id == course.Id);
            if (courseDelete != null)
            {
                _courses.Remove(courseDelete);
            }
        }

        public Course Get(int courseId)
        {
            Course course = new Course();
            course = _courses.FirstOrDefault(p => p.Id == courseId);
            return course;
        }
        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Course courseUpdate = new Course();
            courseUpdate = _courses.FirstOrDefault(p => p.Id == course.Id);
            courseUpdate.Id = course.Id;
            courseUpdate.Name = course.Name;
            courseUpdate.Description = course.Description;
            courseUpdate.Category = course.Category;
            courseUpdate.Instructor =course.Instructor;
        }
    }
}

   

