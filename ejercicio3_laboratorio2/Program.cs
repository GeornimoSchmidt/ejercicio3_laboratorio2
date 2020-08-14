using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random random = new Random();
            int aleatorio = random.Next(1, 7);
            Console.WriteLine("Indica el numero que creas: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == aleatorio)
            {
                Console.WriteLine("Correcto, has acertado el numero");
            }
                
            else
            {
                if (numero < aleatorio)
                {
                    Console.WriteLine("Prueba un numero mas alto");
                    Console.WriteLine("Indica el numero que creas: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < aleatorio)
                    {
                        Console.WriteLine("Intentalo una ultima vez");
                        Console.WriteLine("Indica el numero que creas: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                    }
                } 
                

                if (numero > aleatorio)
                {
                    Console.WriteLine("Prueba un numero mas bajo");
                    Console.WriteLine("Indica el numero que creas: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > aleatorio)
                    {
                        Console.WriteLine("Intentalo una ultima vez");
                        Console.WriteLine("Indica el numero que creas: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                    }
                }
                

                if (numero == aleatorio)
                {
                    Console.WriteLine("Correcto, has acertado el numero");
                }

                else
                {
                    Console.WriteLine("No has acertado, era {0}", aleatorio);
                }

                
            }

            Console.ReadKey();

        }
    }
}
