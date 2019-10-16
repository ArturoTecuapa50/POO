﻿using System;
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
        public void saluda()
        {
        Console.WriteLine("Hola,soy {0}",nombre);
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
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            
            tom.saluda();
            flea.saluda();

            tom.Afina();
            flea.Afina();

            list <Musico> grupo = new list<Musico>();
            grupo.add(tom);
            grupo.add(flea);
            foreach(Musico m in grupo){
                m.saluda();
                m.Afina();
            }

        }
    }
}