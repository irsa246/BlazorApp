using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class Course
    {
        [Key]
        public int course_Id { get; set; }
        public string course_Name { get; set; }
        public int marks { get; set; }
        public Student student { get; set; }
    }
}
