using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Exception2 : System.Exception
    {
        public Exception2() : base() { }
        public Exception2(string message) : base(message) { }
        public Exception2(string message, System.Exception inner) :
        base(message, inner)
        { }
    }
}
