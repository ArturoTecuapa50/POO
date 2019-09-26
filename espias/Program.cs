using System;

namespace espias
{

    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            nombre = "jose";
            apellido = "pavon";
        }
    }

class Anonymous {
   public static void anonimiza( Persona p)
    {
            p.nombre = "xxxxxxxxxxx";
            p.apellido = "xxxxxxxxxxx";       
    }

    public static void cambia(ref Persona p )
      {
          p = new Persona();
          p.nombre = "new";
      }
}

    class Program
    {
        static void duplicar(ref int x){
            x=x*2;
        }
        static int suma(int x,int y){
            return x+y;
        } 
         static void suma(int x,int y, out int resultado){
            resultado = x+y;
        } 
        static void Main(string[] args)
        {
            int a=2;
            int b =3;
            int r= suma(a,b);
            int r2;
            suma(a,b,out r2);
            Console.WriteLine(r2);
         /* Persona p = new Persona();
         Console.WriteLine(p.nombre);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Console.WriteLine(p.nombre);*/
         

        }
    }
}