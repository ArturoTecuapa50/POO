﻿using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("ingresa tu edad: ");
            string captura=Console.ReadLine();
            valor =int.Parse(captura);
            Console.WriteLine("En diez años tendras {0}", valor+10);
            Console.ReadKey();
        }
    }
}
