using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models
{
    public class NRCViewModel
    {
        public string name_en { get; set; }
        public int nrc_code { get; set; }
    }
}