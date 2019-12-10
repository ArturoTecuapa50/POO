using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace proyecto_final
{
	class Producto
	{
		public string codigo;
		public string descripcion;
		public Decimal precio;
		public int departamento;
		public int likes;
		public Producto(string c,string desc,decimal p, int dep, int l)
		{
			codigo=c;
			descripcion=desc;
			precio=p;
			departamento=dep;
			likes=l;
		}
	}
	class ProductoArchivo
	{
		public List<Producto> productos = new List<Producto>();

		public void EscribeProductosTXT(string archivo){
			try
			{
				FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);	//crea archivo
				using(StreamWriter txtOut=new StreamWriter(fs)){//transcribe
					foreach(Producto p in productos){
						txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
					}
				}			
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("");
            }	
		}
		public void LeerProductosTXT(string archivo){
			try
			{			
				FileStream fs1=new FileStream(archivo,FileMode.Open,FileAccess.Read);
				using(StreamReader txtOut=new StreamReader(fs1)){
					string line;				
					while((line = txtOut.ReadLine()) != null){//para que valla checando renglon x renglon
						string[] columnas = line.Split("|");//para dividir el constructor
						productos.Add(new Producto(columnas[0], columnas[1], decimal.Parse(columnas[2]), int.Parse(columnas[3]), int.Parse(columnas[4])));
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("");
            }	
		}
		public void EscribeProductosBIN(string archivo){
			try
			{
				FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
				using(BinaryWriter binOut=new BinaryWriter(fs)){//Crea un escritor para el archivo
					foreach(Producto p in productos){
						binOut.Write(p.codigo);
						binOut.Write(p.descripcion);
						binOut.Write(p.precio);
						binOut.Write(p.departamento);
						binOut.Write(p.likes);
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("");
            }	
		}
		public void LeerProductosBIN(string archivo){
			try
			{
				FileStream fs1=new FileStream(archivo,FileMode.Open,FileAccess.Read);
				using(BinaryReader binIn=new BinaryReader(fs1)) {
					while(binIn.PeekChar() != -1){
						productos.Add(new Producto(binIn.ReadString(), binIn.ReadString(), binIn.ReadDecimal(), binIn.ReadInt32(), binIn.ReadInt32()));
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("");
            }	
		}
		public void GetDepartment(int Depto){
			IEnumerable<Producto> q =
			from p in productos
			where p.departamento == Depto
			select p;
			Console.WriteLine("departamento: "+Depto);
			foreach(Producto p in q) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ProductoArchivo o=new ProductoArchivo();
			o.productos.Add(new Producto("werdfd","jabon",10,2,50));
			o.productos.Add(new Producto("dfsdgs","sabritas",15,3,38));
			o.productos.Add(new Producto("jgfxmd","pantalon",200,4,12));
			o.productos.Add(new Producto("sdnjey","shampoo",40,2,60));
			o.EscribeProductosTXT("productos.txt");
			o.EscribeProductosBIN("productos.bin");
            o.GetDepartment(2);
			
		}
	}
}