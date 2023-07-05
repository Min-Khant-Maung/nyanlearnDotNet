using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace nyanlearnDotNet.Models
{
    public class LessonViewModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseName { get; set; }
        public string CourseId { get; set; }

        public string FilePath { get; set; }

        public IFormFile File { get; set; }

        
    }
}