using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]//specifies the PK if the property name is different than ID or -classname-ID
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
