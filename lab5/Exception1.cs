using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Exception1 : System.Exception
    {
        public Exception1() : base() { }
        public Exception1(string message) : base(message) { }
        public Exception1(string message, System.Exception inner) :
        base(message, inner)
        { }
    }
}
