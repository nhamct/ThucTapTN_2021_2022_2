using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Commons
{
    public class PageResult<T>
    {
        public List<T> item { get; set; }
        public int TotalRecord { get; set; }
    }
}
