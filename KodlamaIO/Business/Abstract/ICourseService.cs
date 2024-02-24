using KodlamaIO.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        List<Course> GetAll();
        Course Get(int id);
    }
}
