using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("CourseInstructor")]
    public class CourseInstructor : BaseEntity
    {
        public string InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public virtual Instructor Instructor { get; set; }

        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}