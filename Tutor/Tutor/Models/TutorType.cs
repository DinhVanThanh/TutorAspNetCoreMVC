using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class TutorType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}