using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    [Table("City")]
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }


    }
}