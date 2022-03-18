using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Complains
{
    public class ComplainsViewModel
    {
        public int IdComplains { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Status { get; set; }

    }
}
