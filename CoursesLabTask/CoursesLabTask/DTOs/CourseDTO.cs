using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursesLabTask.DTOs
{
    public class CourseDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Provide Course Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Provide Course CreditHr")]
        [Range(1, 3, ErrorMessage = "Credit hours must be between 1 and 3")]
        public int CreditHr { get; set; }
        [Required(ErrorMessage = "Please Provide Course Type")]
        public string Type { get; set; }
    }
}