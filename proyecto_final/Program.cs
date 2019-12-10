using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proyecto_final
{
    class producto{
        public string codigo;
        public string descripcion;
        public decimal precio;
        public int departamento;
        public int likes;
        public producto(string c, string des, double p, int dep, int l){
            codigo=c;
            descripcion=des;
            precio=p;
            departamento=dep;
            likes=l;
        }
        //public producto(){}
    }
    class ProductoArchivo{
        public List<producto> productos = new List<producto>();
        
        public void EscribeProductosTXT(string archivo){
        FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            using(StreamWriter txtOut = new StreamWriter(fs)){
                foreach(producto p in productos){            
                    txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
                }
            }            
        }

        public void EscribeProductosBIN(string archivo){
            FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            using(BinaryWriter binOut = new BinaryWriter(fs)){
                foreach(producto p in productos){            
                    binOut.Write(p.codigo);
                    binOut.Write(p.descripcion);
                    binOut.Write(p.precio);
                    binOut.Write(p.departamento);
                    binOut.Write(p.likes);
                }
            }
        }
               
       public void LeeProductosBIN(string archivo)
        { 
        FileStream fs1 = new FileStream(archivo,FileMode.Open,FileAccess.Read);         
        using( BinaryReader binIn = new BinaryReader(fs1))
        {            
            while( binIn.PeekChar() != -1 ) 
            {
                producto producto = new producto();
                producto.codigo = binIn.ReadString();
                producto.descripcion = binIn.ReadString();
                producto.precio = binIn.ReadDecimal();
                producto.departamento = binIn.ReadInt16();
                producto.likes = binIn.ReadInt16();
                      
                productos.Add( producto);
            }
        }
        
        }
        public void LeeProductosTXT(string archivo)
        {
        FileStream fs1 = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Read);       
        using( StreamReader txtOut = new StreamReader(fs1))
        {
            string line;
            while(  (line =  txtOut.ReadLine()) != null ) 
            {
                string[] columnas = line.Split('|');            
                productos.Add( new producto(columnas[0],columnas[1], Double.Parse( columnas[2]), int.Parse(columnas[3]),int.Parse(columnas[4])) );
            }                        
        }
        
        }   
        public void GetDepartment(int Depto){
            IEnumerable<producto> pds =
            from p in productos
            where p.departamento == Depto
            select p;
            Console.WriteLine("productos del departamento: "+Depto);
            foreach(producto p in pds){
                Console.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
            }
        }     
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductoArchivo o=new ProductoArchivo();
            o.productos.Add(new producto("werdfd","jabon",29.99d,2,50));
            o.productos.Add(new producto("dfsdgs","sabritas",14.99d,3,38));
            o.productos.Add(new producto("jgfxmd","pantalon",199.99d,4,12));
            o.productos.Add(new producto("sdnjey","shampoo",39.99d,2,60));
            o.EscribeProductosTXT("productos.txt");
            o.EscribeProductosBIN("productos.bin");
            o.LeerProductosTXT("productos.txt");
            o.GetDepartment(2);
            
           
           

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