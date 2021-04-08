using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaClaseLibrary.exceptions
{
    [Serializable]
    public class BotonYaExistenteException : Exception
    {
        public BotonYaExistenteException(){}
        public BotonYaExistenteException(string message) 
            : base(message);
        {
        }
    }
}
