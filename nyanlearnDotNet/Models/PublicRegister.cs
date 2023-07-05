using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    [Table("PublicRegister")]
    public class PublicRegister : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string NRC { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }

        public string ImagePath { get; set; }
    }
}