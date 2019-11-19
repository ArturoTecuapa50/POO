using System;
using System.IO;
namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("capturar el folder a crear");

            String directorio=Console.ReadLine();

            Directory.CreateDirectory(directorio);
           
        }
    }
}
