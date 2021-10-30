using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Fachada
    {
        Matematica operaciones = new();

        public double Divide(int pDividendo, int pDivisor)
        {

            try
            {
                if (pDividendo == 0)
                {
                    throw new DivisionPorCeroException();
                }
                return operaciones.Dividir(pDividendo, pDivisor);
            }
            catch (DivisionPorCeroException d)
            {
                Console.WriteLine(d.Message);
                Console.ReadKey();
                return pDividendo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return pDividendo;

            }

        }

    }
}
