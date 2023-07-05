using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("Course")]
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImagePath { get; set; }
        
        public string InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public virtual Instructor Instructor { get; set; }
        public virtual IList<Lesson> Lessons { get; set; }
    }
}