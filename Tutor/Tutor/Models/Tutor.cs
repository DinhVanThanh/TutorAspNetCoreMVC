using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class Tutor : Person
    {
        [Key]
        public int Id { get; set; }
        public string GraduationYear { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }
        public int Rating { get; set; }

        [ForeignKey("TutorType")]
        public int TypeId { get; set; }
        public TutorType Type { get; set; }

        [ForeignKey("Major")]
        public int MajorId { get; set; }
        public Major Major { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}