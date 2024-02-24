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
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>
            {
                new Instructor {Id=1,FirstName="Engin", LastName="Demiroğ"},
                new Instructor {Id=2,FirstName="Sergen", LastName="Alkan"},
                new Instructor {Id=3,FirstName="Osman", LastName="Baş"},
                new Instructor {Id=4,FirstName="Sercan", LastName="Alkan"}
            };
        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(int id)
        {
            var deletedInstructor=instructors.First(i=>i.Id==id);
            if (deletedInstructor != null)
            {
                instructors.Remove(deletedInstructor);
            }
        }

        public Instructor Get(int id)
        {
            return instructors.First(i => i.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor=instructors.First(i=>i.Id==entity.Id);
            if (updatedInstructor != null)
            {
                updatedInstructor.Id = entity.Id;
                updatedInstructor.FirstName = entity.FirstName;
                updatedInstructor.LastName = entity.LastName;
            }
        }
    }
}
