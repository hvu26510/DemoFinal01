using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal01
{
    internal class SoChanException : Exception
    {
        public SoChanException(string msg): base(msg) { }
    }
}
