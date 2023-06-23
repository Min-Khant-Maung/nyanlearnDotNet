using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace nyanlearn.Models
{
    [Table("Course")]
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpeningDate { get; set; }
        public int DurationInHour { get; set; }
        public int Fees { get; set; }
        public Boolean IsPromotion { get; set; }
        public float Percentance { get; set; }
        public int Fixed { get; set; }

    }
}