using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public static class Pantalla
    {
        public static void Menu()
        {
            Fachada fachada = new();
            int dividendo, divisor;
            int op = -1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA MATEMÁTICA");
                Console.WriteLine($"1 - División \n" +
                                               $"0 - Salir\n");
                Console.Write("Ingrese opción: ");
                op = Int32.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese Divisor: ");
                        divisor = Int32.Parse(Console.ReadLine());
                        Console.Write($"\n Ingrese Dividendo: ");
                        dividendo = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(fachada.Divide(dividendo, divisor));
                        Console.ReadKey();
                        break;
                    case 0: break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción valida");
                        Console.WriteLine("Presione cualquier tecla para continuar");break;

                }
            }
        }
    }
}
