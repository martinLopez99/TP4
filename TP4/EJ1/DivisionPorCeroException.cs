using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class DivisionPorCeroException : Exception
    {

        public DivisionPorCeroException() { }

        public DivisionPorCeroException(string pMensaje) : base("Se intenta divir por 0") {}




    }
}
