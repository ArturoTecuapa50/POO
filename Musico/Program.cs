using System;
using System.Collections.Generic;
namespace Musico
{

    
    class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
        public virtual string saluda()
        {
        return string.Format("Hola,soy {0}",nombre);
        }

        public virtual void Afina()
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

       public override void Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }

       public override string saluda(){
           return base.saluda()+"y soy bajista";
       }
    }
    ///
    class Guitarrista:Musico{
        private string guitarra;
        public Guitarrista((string nombre,string guitarra):base(nombre){
            this.guitarra=guitarra;
        }
        public override void Afina(){
            Console.WriteLine("{0} esta afinando su guitarra {1}",nombre,guitarra);
        }
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            Guitarrista jose=new Guitarrista("Jose","Gibson");
            
            Console.WriteLine(tom.saluda());
            Console.WriteLine(flea.saluda());
            Console.WriteLine(jose.saluda());

            tom.Afina();
            flea.Afina();
            jose.Afina();

            list <Musico> grupo = new list<Musico>();
            grupo.add(tom);
            grupo.add(flea);
            grupo.add(jose);
            foreach(Musico m in grupo){
                m.saluda();
                m.Afina();
            }

        }
    }
}