using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearnDotNet.Models
{

    public class CourseResultPercentageViewModel : BaseEntity
    {
        public string CourseId { get; set; }
        public int numOfLessons { get; set;}

    }
}