using System;
using System.IO;
using System.Collections.Generic;


namespace creadir
{   
    public class Producto
    {
        public string codigo { get; set; }
        public string descripcion{ get; set; }
        public double precio{ get; set; }

        public Producto(string c, string d, double p){
            codigo = c; descripcion = d; precio = p; 
        }

        public Producto()
        {}
    }

    class ProductoArchivo
    {

        public static void EscribeProductosBIN(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            foreach(Producto p in productos)
            {
            
             binOut.Write(p.codigo);
             binOut.Write(p.descripcion);
             binOut.Write(p.precio);
             }

             binOut.Close();
        }


        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {

         FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter txtOut = new StreamWriter(fs);

         foreach(Producto p in productos)
         {
            
             txtOut.WriteLine("{0}|{1}|{2}", p.codigo,p.descripcion,p.precio);
        }
        txtOut.Close();
        }
    
       public static List<Producto> LeeProductosBIN(string archivo)
        {
        List<Producto> productos = new List<Producto>();  
        FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);
         
        using( BinaryReader binIn = new BinaryReader(fs))
        {
            
            while( binIn.PeekChar() != -1 ) // No lleguemos al final del archivo
            {
                Producto producto = new Producto();
                producto.codigo = binIn.ReadString();
                producto.descripcion = binIn.ReadString();
                producto.precio = binIn.ReadDouble();
                      
                productos.Add( producto);

            }

        }
        return productos;
        }

        public static List<Producto> LeeProductosTXT(string archivo)
        {
        List<Producto> productos = new List<Producto>();        
        using( StreamReader sr = new StreamReader(archivo))
        {
            string line = "";
            while(  (line =  sr.ReadLine()) != null ) // No lleguemos al final del archivo
            {
                string[] columnas = line.Split('|');
            
                productos.Add( new Producto(columnas[0],columnas[1], Double.Parse( columnas[2])) );

            }

        }
        return productos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        List<Producto> productos = new List<Producto>();
        productos.Add(new Producto("AQW","Lapiz Azul w2", 12.23d));            
        productos.Add(new Producto("AQW","Lapiz Verde w2", 12.23d));            
        productos.Add(new Producto("AQW","Pluma Azul w2", 12.23d));            
        productos.Add(new Producto("AQW","Borrador ww2", 12.23d));            

        ProductoArchivo.EscribeProductosBIN(@"productos.bin", productos);

        Console.WriteLine("Archivo Grabado");
        Console.ReadKey();

        List<Producto> productos_leidos = ProductoArchivo.LeeProductosBIN("producto.bin");

        foreach(Producto p in productos_leidos)
             {    
             Console.WriteLine("{0} {1} {2}", p.codigo,p.descripcion,p.precio);
           }
    
      //  var jsonString = JsonSerializer.Serialize(productos_leidos);
      //  File.WriteAllText("fileName.json", jsonString);
      //  Console.WriteLine(jsonString);


        }
    }
}