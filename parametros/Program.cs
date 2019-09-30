using System;

namespace parametros
{
    class Tarjeta_credito{
        public string num ;
        public string NIP;
        public Tarjeta_credito(){
            num="1238124018340273";
            NIP="1232";
        }
    }
    class oculto{
        public static void ocultos( Tarjeta_credito tc)
    {
            tc.num = "xxxxxxxxxxxxxxxx";
            tc.NIP = "xxxx";       
    }
    public static void cambiar(ref Tarjeta_credito tc )
      {
          tc = new Tarjeta_credito();
          tc.num = "new";
      }      
    }  

    class Program
    {        
        static int suma(int saldo,int iva){
            return saldo+iva;
        } 
         static void suma(int saldo,int iva, out int resultado){
            resultado = saldo+iva;
        }
        static void Main(string[] args)
        {
        Console.WriteLine("No. de tarjeta:");
        Tarjeta_credito tc = new Tarjeta_credito();
         Console.WriteLine(tc.num);
         oculto.ocultos( tc);
         Console.WriteLine(tc.NIP);
         oculto.ocultos( tc);
        int saldo=500;
        int deposito=400;
        int resultado;
        Console.WriteLine("saldo total:");
        suma(saldo, deposito, out resultado);
		Console.WriteLine(resultado);

		
        }
    }
}
