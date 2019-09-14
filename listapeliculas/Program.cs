using System;
using System.Collections.Generic;
namespace listapeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Hercules");
            lista.Add("Los increibles");
            lista.Add("Los aristogatos");
            lista.Add("El libro de la selva");
            lista.Add("Oliver y su pandilla");

            foreach(string peliculas in lista)
            Console.WriteLine(peliculas);
            
        }
    }
}
