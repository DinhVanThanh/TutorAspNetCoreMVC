using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class Policy
    {
        [Key]
        public int Id { get; set; }
        public string Contents { get; set; }
    }
}