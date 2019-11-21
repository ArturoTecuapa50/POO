using System;
using System.Collections.Generic;
using System.IO;
namespace creadir
{
    class producto{
        public string codigo, descripcion;
        public double precio;
        public producto(string c, string d, double p){
            codigo=c;
            descripcion=d;
            precio=p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("capturar el archivo a borrar");
            string archivo=Console.ReadLine();           
            File.SetAttributes(archivo,FileAttributes.Hidden);*/
            List<producto> productos=new List<producto>();
            productos.Add(new producto("aqw","lapiz azul W2",12.23d));
            productos.Add(new producto("aqw","lapiz verde W2",12.23d));
            productos.Add(new producto("aqw","pluma azul",12.23d));
            productos.Add(new producto("aqw","borrador",12.23d));
            FileStream fs=new FileStream("productos.txt",FileMode.Append, FileAccess.Write);//append 
            StreamWriter txtOut = new StreamWriter(fs);
           foreach(producto p in productos){
               txtOut.WriteLine("{0},|{1}|{2}",p.codigo,p.descripcion,p.precio);
               //txtOut.WriteLine(p.precio);
           }
           txtOut.Close();
           Console.ReadKey();
           
        }
    }
}
