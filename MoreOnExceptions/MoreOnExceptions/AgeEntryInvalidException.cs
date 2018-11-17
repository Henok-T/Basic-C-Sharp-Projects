using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnExceptions
{
    public class AgeEntryInvalidException : Exception
    {
        public AgeEntryInvalidException()
                : base() { }

        public AgeEntryInvalidException(String message)
            : base(message) { }
        
    }
}
