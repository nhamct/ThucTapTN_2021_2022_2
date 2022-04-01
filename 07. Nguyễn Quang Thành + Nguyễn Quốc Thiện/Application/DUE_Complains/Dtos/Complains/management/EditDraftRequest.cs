using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Complains.management
{
    public class EditDraftRequest
    {
        public int IdComplain { get; set; }
        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile ThumbnailImage { get; set; }

    }
}
