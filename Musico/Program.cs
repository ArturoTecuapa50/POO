using System;

namespace Musico
{

    
    class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
        public void Saludo()
        {
        Console.WriteLine("Hola,soy {0}",nombre);
        }

        public void Afina()
        {
            Console.WriteLine("{0},Afina su instrumento ",nombre);
        }

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string nombre,string bajo):base(nombre)
       {
       this.bajo=bajo;
       } 

       public void Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            
            tom.Saludo();
            flea.Saludo();

            tom.Afina();
            flea.Afina();

        }
    }
}