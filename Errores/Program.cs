using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valor;
            Console.WriteLine("ingresa tu edad: ");
            //string captura=Console.ReadLine();
            //valor =int.Parse(captura);
            //Console.WriteLine("En diez años tendras {0}", 100/valor);
            //Console.ReadKey();
            try
            {
                string captura=Console.ReadLine();
                valor =int.Parse(captura);
                Console.WriteLine(valor);
            }
            catch(FormatException)
            {
                Console.WriteLine("formato incorrecto");
            }
            try
            {
                string captura=Console.ReadLine();
                valor =int.Parse(captura);
                Console.WriteLine(valor);
            }
            catch(OverflowException)
            {
                Console.WriteLine("formato incorrecto");
            }
            Console.ReadKey();*/
            Console.WriteLine("captura un entero:  ");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("el valor es: {0}", valor);
        }
    }
}
