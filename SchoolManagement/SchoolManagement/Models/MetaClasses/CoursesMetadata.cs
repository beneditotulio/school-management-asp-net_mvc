using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SchoolManagement.Models
{
    public class CoursesMetadata
    {
        [StringLength(50), Required]
        public string Title { get; set; }
        [Range(1,8)]
        public Nullable<int> Credits { get; set; }
    }

    
    [MetadataType(typeof(CoursesMetadata))]
    public partial class Course
    {
    }
}