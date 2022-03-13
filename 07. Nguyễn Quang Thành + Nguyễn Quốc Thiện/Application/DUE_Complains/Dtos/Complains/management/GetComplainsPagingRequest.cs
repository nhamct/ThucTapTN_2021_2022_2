using DUE_Complains.Dtos.Commons;
using DUE_Complains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Complains
{
    public class GetComplainsPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int>? idDepartment { get; set; }
        public string idStudent { get; set; }
    }
}
