using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaClaseLibrary.exceptions
{
    class BotonNoExistenteException : Exception
    {
        public BotonNoExistenteException() { }
        public BotonNoExistenteException(string message)
            : base(message);
        {
        }
}
}
