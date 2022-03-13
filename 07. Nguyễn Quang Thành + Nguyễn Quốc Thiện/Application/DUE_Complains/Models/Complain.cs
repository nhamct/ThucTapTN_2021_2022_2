using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DUE_Complains.Models
{
    [Table("Complains")]
    public partial class Complain
    {
        public string IdStudent { get; set; }
        public int IdComplains { get; set; }
        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Status { get; set; }
        
        public Department Department { get; set; }
        public virtual Employee IdDepartmentNavigation { get; set; }
        public virtual Student IdStudentNavigation { get; set; }
        public virtual ICollection<ImageComplain> ImageComplain { get; set; }


    }
}
