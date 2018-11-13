using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mission.Models
{
    public class QA
    {
        [Key]
        public int QuestionID { get; set; }
        public string Mission { get; set; }
        [Required(ErrorMessage = "Please enter your question")]
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}