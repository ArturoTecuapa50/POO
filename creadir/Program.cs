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
        public producto(){}
    }

    class productoarchivo{

        public static void escribeProductostxt(string archivo, List<producto> productos){
            BinaryReader fs= new BinaryReader(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut= new BinaryWriter(fs);
            foreach(producto p in productos){
                binOut.Write(p.codigo);
                binOut.Write(p.descripcion);
                binOut.Write(p.precio);
            }
            binOut.Close();
        }
        public static void escribeProductostxt(string archivo, List<producto> productos){
            FileStream fs=new FileStream("productos.txt",FileMode.Append, FileAccess.Write);//append 
            StreamWriter txtOut = new StreamWriter(fs);
            foreach(producto p in productos){
               txtOut.WriteLine("{0},|{1}|{2}",p.codigo,p.descripcion,p.precio);
               //txtOut.WriteLine(p.precio);
            }
            txtOut.Close();            
        }
        public static leeproductostxt(string archivo){
            List<producto> productos =new List<producto>(); 

            using(StreamReader sr=new StreamReader(@"productos.txt"))
            {
              string line ="";
              while((line= sr.ReadLine()) != null )
              {
                  
                  string[] columnas=line.Split("|");
                  //Console.WriteLine(columnas[0]);
                  producto.Add(new producto(columnas[0],columnas[1],Double.Parse(columnas[2])));
              }
            }
        }
        public static List<producto> leeproductostxt();
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
            productoarchivo.escribeProductostxt(@"productos.txt");
            Console.WriteLine
            List<producto> productos_leidos = new List<producto>();
           

           
            foreach(producto p in productos_leidos)
            {
                Console.WriteLine("{0}|{1}|{2}",p.codigo,p.descripcion,p.precio);
            } 
        }
    }
}
