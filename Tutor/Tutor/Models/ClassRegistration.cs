using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class ClassRegistration
    {
        [Key]
        public int Id { get; set; }
        public short StartDate { get; set; }
        public short StartHour { get; set; }
        public short Rating { get; set; }
        public string Note { get; set; }
        [ForeignKey("Tutor")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}