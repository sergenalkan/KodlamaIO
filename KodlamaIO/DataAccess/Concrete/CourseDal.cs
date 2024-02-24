using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        //ctor - constructor
        public CourseDal()
        {
            courses = new List<Course>
            {
                new Course {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                    Description = "İleri düzey C# öğreneneceksiniz", 
                    Percentage = 0
                },new Course {
                    Id = 2,
                    CategoryId = 2,
                    InstructorId = 2,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                    Description = "İleri düzey C# ve Angular öğreneneceksiniz", 
                    Percentage = 0
                },new Course {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                    Description = "Java ve React ile sınırlarınızı aşın", 
                    Percentage = 0
                },new Course {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                    Description = "OOP temelli JS öğrenin", 
                    Percentage = 0
                }
            };
        }
        public List<Course> GetAll()
        {            
            return courses;
        }

        public void Add(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(int id)
        {
            var deletedCourse = courses.First(c => c.Id == id);
            if (deletedCourse != null)
            {
                courses.Remove(deletedCourse);
            }
            
        }

        public void Update(Course entity)
        {
            var updatedCourse = courses.First(c => c.Id == entity.Id);
            updatedCourse.Id = entity.Id;
            updatedCourse.CategoryId = entity.CategoryId;
            updatedCourse.InstructorId = entity.InstructorId;
            updatedCourse.Name = entity.Name;
            updatedCourse.Description = entity.Description;
            updatedCourse.Percentage = entity.Percentage;
        }

        public Course Get(int id)
        {
            return courses.First(c => c.Id == id);
        }
    }
}
