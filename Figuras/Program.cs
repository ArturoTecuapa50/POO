using System;
using System.collections.Generic;
namespace Figuras
{
    abstract class Figuras
    {
        protected int ancho, alto;
        protected int px, py;
        protected string color_relleno, color_borde;
        //constructor
        public Figuras(int ancho, int alto, int px, int py, string color_relleno, int color_borde)
        {
            this.ancho=ancho;
            this.alto=alto;
            this.px=px;
            this.py=py;
            this.color_relleno=color_relleno;
            this.color_borde=color_borde;
        }

        public abstract void dibuja();


    }

    class Rectangulo:Figuras
    {
        
        public Rectangulo(string ancho, string alto):base(){

        }
        public override void dibuja()
        {
            Console.WriteLine("se dibuja en rect color {0}, en x:{1}, y y:{2}", color_relleno,px,py);
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            list<Figuras> Figuras=new list<Figuras>();
            Figuras.add(new Rectangulo(10,10));



            Console.WriteLine("Hello World!");
        }
    }
}
