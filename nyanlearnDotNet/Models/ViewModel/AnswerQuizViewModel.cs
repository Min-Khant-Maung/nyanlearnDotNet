using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearnDotNet.Models.ViewModel
{
    public class AnswerQuizViewModel: BaseEntity
    {
        public string Question { get; set; }

        public string Option1 { get; set;}

        public string Option2 { get; set;}

        public string Option3 { get; set;}

        public string Option4 { get; set;}

        public string SelectedOption { get; set;}
        public string Answer { get; set; }
    }
}

