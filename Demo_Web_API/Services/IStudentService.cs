﻿using Demo_Web_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Web_API.Services
{
    public interface IStudentService
    {
        Student AddStudent(Student student);
        List<Student> GetStudents();
        void UpdateStudent(Student student);
        void DeleteStudent(int Id);
        Student GetStudent(int Id);
    }
}
