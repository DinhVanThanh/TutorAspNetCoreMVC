using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class Tuition
    {
        [Key]
        public int Id { get; set; }
        public short Hour { get; set; }
        public UInt64 Fee { get; set; }
        public short Grade { get; set; }
    }
}