using Demo_Web_API.Context;
using Demo_Web_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Web_API.Services
{
    public class StudentService : IStudentService
    {
        public StudentContext _studentDbContext;
        public StudentService(StudentContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public Student AddStudent(Student student)
        {
            _studentDbContext.Student.Add(student);
            _studentDbContext.SaveChanges();
            return student;
        }
        public List<Student> GetStudents()
        {
            return _studentDbContext.Student.ToList();
        }

        public void UpdateStudent(Student student)
        {
            _studentDbContext.Student.Update(student);
            _studentDbContext.SaveChanges();
        }

        public void DeleteStudent(int Id)
        {
            var student = _studentDbContext.Student.FirstOrDefault(x => x.Id == Id);
            if (student != null)
            {
                _studentDbContext.Remove(student);
                _studentDbContext.SaveChanges();
            }
        }

        public Student GetStudent(int Id)
        {
            return _studentDbContext.Student.FirstOrDefault(x => x.Id == Id);
        }
    }
}
