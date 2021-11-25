using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public class Class1
    {

        public class Persona
        {
            public string? Nombre { get; set; }

            public string devuelveNombre()
            {
                return "Hola " + Nombre;
            }

            public static void Calcular()
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir");
                }
            }
            public static void Main(String[] args)
            {
                Calcular();

                Persona p = new Persona();
                Console.WriteLine("Introduzca su nombre:");
                p.Nombre = Console.ReadLine();
                Console.WriteLine(p.devuelveNombre());
            }
        }

    }
}
