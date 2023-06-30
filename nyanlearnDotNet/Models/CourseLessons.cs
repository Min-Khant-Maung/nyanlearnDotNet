using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("CourseLessons")]
    public class CourseLessons : BaseEntity
    {
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        public string LessonId { get; set; }
        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }
    }
}