using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models.ViewModel
{
    public class EmailTemplateViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime ApprovedDate { get;set; }
    }
}