using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.System.Exceptions
{
    public class DueExceptions : Exception
    {
        public DueExceptions()
        {

        }
        public DueExceptions(string message)
          : base(message)
        {
        }
        public DueExceptions(string message, Exception inner)
          : base(message, inner)
        {
        }
    }
}
