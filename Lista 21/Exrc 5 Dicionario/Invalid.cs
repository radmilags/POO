using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Dicionario
{
    class Invalid : InvalidOperationException
    {
        public Invalid(string message) : base(message) { }
    }
}
