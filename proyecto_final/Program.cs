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
        public producto(){}
    }
    class ProductoArchivo{
        public static void EscribeProductosBIN(string archivo, List<producto> productos){
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            foreach(producto p in productos)
            {            
             binOut.Write(p.codigo);
             binOut.Write(p.descripcion);
             binOut.Write(p.precio);
             binOut.Write(p.descripcion);
             binOut.Write(p.likes);
            }
            binOut.Close();
        }
        public static void EscribeProductosTXT(string archivo, List<producto> productos){
        FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter txtOut = new StreamWriter(fs);
        foreach(producto p in productos){            
            txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
        }
        txtOut.Close();
        }
        
       public static List<producto> LeeProductosBIN(string archivo)
        {
        List<producto> productos = new List<producto>();  
        FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);         
        using( BinaryReader binIn = new BinaryReader(fs))
        {            
            while( binIn.PeekChar() != -1 ) 
            {
                producto producto = new producto();
                producto.codigo = binIn.ReadString();
                producto.descripcion = binIn.ReadString();
                producto.precio = binIn.ReadDouble();
                producto.departamento = binIn.ReadInt16();
                producto.likes = binIn.ReadInt16();
                      
                productos.Add( producto);
            }
        }
        return productos;
        }

        public static List<producto> LeeProductosTXT(string archivo)
        {
        List<producto> productos = new List<producto>();        
        using( StreamReader sr = new StreamReader(archivo))
        {
            string line = "";
            while(  (line =  sr.ReadLine()) != null ) // No lleguemos al final del archivo
            {
                string[] columnas = line.Split('|');            
                productos.Add( new producto(columnas[0],columnas[1], Double.Parse( columnas[2]), int.Parse(columnas[3]),int.Parse(columnas[4])) );
            }
        }
        return productos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<producto> productos=new List<producto>();
            productos.Add(new producto("aqw","lapiz azul W2",12.23d,2,20));
            productos.Add(new producto("aqw","lapiz verde W2",12.23d,2,20));
            productos.Add(new producto("aqw","pluma azul",12.23d,2,20));
            productos.Add(new producto("aqw","borrador",12.23d,2,20));
            FileStream fs=new FileStream("productos.txt",FileMode.Append, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);
            foreach(producto p in productos){
                txtOut.WriteLine("{0},|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
            }
            txtOut.Close();
            Console.ReadKey();
           ///
            ProductoArchivo.EscribeProductosBIN(@"productos.bin", productos);
            List<producto> productos_leidos = ProductoArchivo.LeeProductosBIN("producto.bin");
            foreach(producto p in productos_leidos){    
                Console.WriteLine("{0} {1} {2} {3} {4}", p.codigo,p.descripcion,p.precio,p.descripcion,p.likes);
            }
        }
    }
}
/*1. Debes guardar los datos en un archivo tipo TEXTO.+

2. También en un archivo tipo BINARIO.+

3. Haz un método llamado GetDepartment(int Depto) que lea los productos del archivo, pero muestre en pantalla solo los 

productos de un departamento. Digamos filtra los productos por departamento.

Extra:

4. Haz un método que lea los Productos de un archivo y los ordene por Likes, después los muestre en la consola.

5. Haz un programa que agregue los productos de un archivo en otro archivo ya existente.*/