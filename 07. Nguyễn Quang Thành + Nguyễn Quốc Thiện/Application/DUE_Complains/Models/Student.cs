using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DUE_Complains.Models
{
    [Table("Students")]

    public partial class Student
    {

        public string Studentcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Sclass { get; set; }
        public Guid Username { get; set; }
        public int? DepartmentId { get; set; }

        public virtual ICollection<Complain> Complains { get; set; }
        public virtual Department DepartmentNavi { get; set; }
        public AppUser AppUser { get; set; }
        
    }
}
