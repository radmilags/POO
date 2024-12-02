using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Jogo
{
    class EmailExistenteException : Exception
    {
        public EmailExistenteException() { }
        public EmailExistenteException(string message) : base(message) { }
    }
}
