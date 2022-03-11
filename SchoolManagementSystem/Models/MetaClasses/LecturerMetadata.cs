using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models
{
    public class LecturerMetadata
    {
        [StringLength(50)]
        [Display(Name = "Lecturer First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }    
    }

    [MetadataType(typeof(LecturerMetadata))]
    public partial class Lecturer
    {
            
    }
}