using System;
using System.IO;
namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("capturar el archivo a borrar");

            string archivo=Console.ReadLine();           
            File.SetAttributes(archivo,FileAttributes.Hidden);
            
           
        }
    }
}
