using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models.ViewModel
{
    public class CourseLessonViewModel: BaseEntity
    {
        public string CourseId { get; set; }
        public string LessonId { get; set; }
    }
}

