using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace nyanlearn.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        // public string Ip { get; set; }
        // public bool IsActive { get; set; } = true;
    }
}