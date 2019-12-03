using System;
using System.Collections.Generic;
using System.IO;

namespace proyecto_final
{
    class producto{
        public string codigo;
        public string descripcion;
        public double precio;
        public int departamento;
        public int likes;
        public producto(string c, string des, double p, int dep, int l){
            codigo=c;
            descripcion=des;
            precio=p;
            departamento=dep;
            likes=l;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
