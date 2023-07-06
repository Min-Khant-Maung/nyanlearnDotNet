using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    [Table("Lesson")]
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string CourseName { get; set; }

        public string FilePath { get;set; }

        public string CourseId { get;set; }

        public virtual IList<Course> Courses { get; set; }
    }
}