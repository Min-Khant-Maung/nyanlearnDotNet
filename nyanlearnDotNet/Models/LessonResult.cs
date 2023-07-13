using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("LessonResult")]
    public class LessonResult : BaseEntity
    {

        public string StudentId { get; set; }

        public string LessonId { get; set; }

        public double ResultPercentage { get; set; }


        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }



        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }


    }
}