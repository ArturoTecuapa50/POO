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
        static void Main(string[] args)
        {
         Persona p = new Persona();
         Console.WriteLine(p.nombre);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Console.WriteLine(p.nombre);
         

        }
    }
}