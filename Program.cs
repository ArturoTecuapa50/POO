 using System;
 using System.Collections.Generic;
namespace Bici2
{
    class Bici1    
    {
        //campos 
        private string marca;
        private int current_velocity;
        private int velocities;
        private Persona dueño;
        //private int sube;
 
        //metodos
        public void print(){
            Console.WriteLine("Marca:{0},Velocity:{1}",marca,current_velocity);
        }

        public void init(string marca,int cv , int vs){
         this.marca=marca;
         if(cv >vs){
             current_velocity=vs;
              }
         else{
             current_velocity=cv;
             }
             velocities=vs;
        }
     
    }
            class Persona {
            private string nombre;
            private string correos;
            private List<Bici1>bicis;

            public void init(string n,string c){
                nombre=n;
                correos=c;
            }
                public void print()
                {
                    Console.WriteLine("(0) (1)",nombre,correos);
                }
            }
    class Program
    {
        static void Main(string[] args)
        {
         Bici1 bici1 = new Bici1();
        bici1.init("Huffy",3,12);
        //bici.sube(),
        //bici1.print();

         Bici1 bici2 = new Bici1();
        bici2.init("PineStar",0,0);
        //bici.sube(),
        //bici2.print();

         Bici1 bici3 = new Bici1();
        bici3.init("Apache",1,8);
        //bici.sube(),
        //bici3.print();        

        List<Bici1>bicis = new List<Bici1>();
        bicis.Add(bici1);
        bicis.Add(bici2);
        bicis.Add(bici3);

        foreach (Bici1 b in bicis){
            b.print();
        }


        Persona tom =new Persona();
        tom.init("tom","tom@gmail.com");
        tom.print();
        
            //Console.WriteLine("Hello World!");
        }        
    }
}
