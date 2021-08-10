using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Web_API.Entities;
using Demo_Web_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Web_API.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        //[Route("[action]")]
        //[Route("Students/GetStudents")]
        public IEnumerable<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        [HttpPost]
        //[Route("[action]")]
        //[Route("Students/AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return Ok();
        }

        [HttpPost]
        //[Route("[action]")]
        //[Route("Students/UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student);
            return Ok();
        }

        [HttpDelete]
        //[Route("[action]")]
        //[Route("Students/DeleteStudent")]
        public IActionResult DeleteStudent(int id)
        {
            var existingStudent = _studentService.GetStudent(id);
            if (existingStudent != null)
            {
                _studentService.DeleteStudent(existingStudent.Id);
                return Ok();
            }
            return NotFound($"Student Not Found with ID : {existingStudent.Id}");
        }

        //[HttpGet]
        //[Route("GetStudent")]
        //public Student GetStudent(int id)
        //{
        //    return _studentService.GetStudent(id);
        //}
    }
}
