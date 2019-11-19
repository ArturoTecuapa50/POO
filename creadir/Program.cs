using System;
using System.IO;
namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("capturar el folder a crear");

            string directorio=Console.ReadLine();

            Directory.CreateDirectory(directorio);
            if (Directory.Exists(directorio)){
                Console.WriteLine("ya existe directorio");
            }else{
                Directory.CreateDirectory(directorio);
            }
           
        }
    }
}
