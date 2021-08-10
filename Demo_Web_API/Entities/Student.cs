using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Web_API.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
