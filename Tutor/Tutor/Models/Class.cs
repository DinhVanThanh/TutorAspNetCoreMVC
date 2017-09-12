using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public short DayPerWeek { get; set; }
        public string Requirement { get; set; }
        public string Contact { get; set; }
        public short FromHour { get; set; }
        public short ToHour { get; set; }
        public string Status { get; set; }
    }
}