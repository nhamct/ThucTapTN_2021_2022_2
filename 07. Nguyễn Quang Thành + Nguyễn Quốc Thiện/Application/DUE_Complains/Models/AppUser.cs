using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Models
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }
        public int IdDepartment  { get; set; }
        public string? IdStudent { get; set; }
        public int? idteacher { get; set; }

    }
}
