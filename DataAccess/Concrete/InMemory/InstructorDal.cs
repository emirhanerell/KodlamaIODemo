using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InstructorDal : IInstructorDal
    {
        private static List<Instructor> _instructors = new List<Instructor>();
        public InstructorDal() 
        {
            var _instructors = new List<Instructor>()
            {
                new Instructor {Id = 1, Name ="Engin Demiroğ"}
            };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorDelete = new Instructor();
            instructorDelete = _instructors.FirstOrDefault(p => p.Id == instructor.Id);
            if (instructorDelete != null)
            { 
                _instructors.Remove(instructorDelete);
            }
        }

        public Instructor Get(int instructorId)
        {
            Instructor instructor = new Instructor();
            instructor = _instructors.FirstOrDefault(p =>p.Id == instructorId);
            return instructor;
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorUpdate = new Instructor();
            instructorUpdate = _instructors.FirstOrDefault(p => p.Id == instructor.Id);
            instructorUpdate.Id = instructor.Id;
            instructorUpdate.Name = instructor.Name;
            
        }
    }
}
