using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas
{
    public class LimiteDeReservasException : Exception
    {
        public LimiteDeReservasException(string message) : base(message) { }

        public LimiteDeReservasException(string message, Exception exception) : base(message, exception) { }    
    }
}
