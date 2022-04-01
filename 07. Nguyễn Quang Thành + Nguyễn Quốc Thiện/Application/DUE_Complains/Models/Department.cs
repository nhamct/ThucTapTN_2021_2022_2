using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DUE_Complains.Models
{
    [Table("Departments")]
    public class Department
    {


        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int? Totalstudent { get; set; }
        public int? Totalemployee { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Complain> Complains { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
