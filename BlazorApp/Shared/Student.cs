using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class Student
    {
        [Key]
        public int std_Id { get; set; }
        public string std_name { get; set; }

    }
}
