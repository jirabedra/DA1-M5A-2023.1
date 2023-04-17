using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ClienteExceptions : Exception
    {
        public ClienteExceptions() { }

        public ClienteExceptions(string message)
            : base(message) { }

        public ClienteExceptions(string message, Exception inner)
            : base(message, inner) { }
    }
}
