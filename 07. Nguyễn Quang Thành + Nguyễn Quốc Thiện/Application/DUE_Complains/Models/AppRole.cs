using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Models
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
