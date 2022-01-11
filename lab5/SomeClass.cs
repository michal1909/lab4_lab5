using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class SomeClass
    {
        public void CanThrowException()
        {
            if (new Random().Next(5) == 0)
                throw new Exception();
        }
    }
}
