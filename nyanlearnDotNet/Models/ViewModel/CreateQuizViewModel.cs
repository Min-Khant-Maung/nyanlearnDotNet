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
    public class CreateQuizViewModel
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public string LessonName { get; set; }
        public string LessonId { get; set; }

                public string Question { get; set; }

         public string Option1 { get; set; }

          public string Option2 { get; set; }

           public string Option3 { get; set; }

            public string Option4 { get; set; }


public string Answer { get; set; }

            

        

        
    }
}