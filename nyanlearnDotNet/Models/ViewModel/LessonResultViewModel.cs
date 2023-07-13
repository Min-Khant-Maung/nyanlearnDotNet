using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    public class LessonResultViewModel : BaseEntity
    {
        
        public string Name { get; set; }
        public string StudentId { get; set; }

        public string LessonId { get; set; }

        public double ResultPercentage { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}