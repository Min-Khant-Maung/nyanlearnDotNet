using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("InstructorCourse")]
    public class InstructorCourses : BaseEntity
    {
        public string InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public virtual Instructor Instructor { get; set; }
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}