using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{
    [Table("Enrollment")]
    public class Enrollment : BaseEntity
    {

        public string StudentId { get; set; }

        public string CourseId { get; set; }


        public int numOfLessons { get; set;}


        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }



        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }


    }
}