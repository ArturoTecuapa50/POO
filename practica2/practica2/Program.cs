using System;
using System.Collections.Generic;
namespace practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("hola");
            lista.Add("hey");
            lista.Add("yes");
            foreach(string s in lista)
            Console.WriteLine(s);
            
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
