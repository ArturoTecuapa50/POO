using System;

namespace Errores
{
    class NegativeIntergerExcepiton:Exception{
        public NegativeIntergerExcepiton():base("No debes capturar enteros negativos")
        {}
    }
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
            Console.WriteLine("captura un entero positivo:  ");
            int valor=0;
            try {
                valor = int.Parse(Console.ReadLine());
                if(valor<0){
                    throw new NegativeIntergerExcepiton();
                }
                Console.WriteLine("el valor es: {0}", valor);
            }
            catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Finally");
            }
            
        }
    }
}
