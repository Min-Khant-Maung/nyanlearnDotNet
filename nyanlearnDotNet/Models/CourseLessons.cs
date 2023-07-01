using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("CourseLessons")]
    public class CourseLessons:BaseEntity
    {
        public string CourseId { get; set; }
        public string LessonId { get; set; }
        public string InstructorId { get; set; }
    }
}