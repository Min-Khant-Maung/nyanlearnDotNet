using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models.ViewModel
{
    public class CourseViewModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
