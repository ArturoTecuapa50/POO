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
        public virtual void toca()
        {
            Console.WriteLine("{0},toca su instrumento ",nombre);
        }

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
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
       public override void toca(){
           Console.WriteLine("{0} toco el bajo {1}",nombre);
       }
    }
    ///
    class Guitarrista:Musico{
        private string guitarra;
        public Guitarrista(string no,string guitarra):base(no){
            this.guitarra=guitarra;
        }
        public override void Afina(){
            Console.WriteLine("{0} esta afinando su guitarra {1}",nombre,guitarra);
        }

        public override void toca(){
           Console.WriteLine("{0} toco el bajo {1}",nombre);
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
            
            

            List<Musico> grupo = new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            grupo.Add(jose);
            //grupo.sort(); <----- los ordena alfabeticamente 
            foreach(Musico m in grupo){
                m.saluda();
                m.Afina();
                m.toca();

            }

        }
    }
}