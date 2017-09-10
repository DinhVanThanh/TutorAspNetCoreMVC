using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class Customer : Person
    {
        [Key]
        public int Id { get; set; }

        public string Note { get; set; }
    }
}