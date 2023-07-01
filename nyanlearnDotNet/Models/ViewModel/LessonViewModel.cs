using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    public class LessonViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseId { get; set; }
    }
}