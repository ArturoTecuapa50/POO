using System;
using System.Collections.Generic;
namespace FaceClon
{
    abstract class Publicacion{
        protected string fecha;
        protected string comentarios;
        protected string reacciones;

        public Publicacion(string fecha, string comentarios, string reacciones){
            this.fecha=fecha;
            this.comentarios=comentarios;
            this.reacciones=reacciones;
        }
        public abstract void imprime();
    }
    class foto:Publicacion{
        public foto(string fecha, string comentarios, string reacciones):base(fecha, comentarios, reacciones){

        }
        public override void imprime(){
            Console.WriteLine("la foto se imprimira {0}, la fecha es {1}, los cometarios son {2}, la reaccion es {3}",fecha,  comentarios, reacciones);
        }
        
    }
    


    class Program
    {
        static void Main(string[] args)
        {
           



            List<Publicacion> Publicacion= new List<Publicacion>();
            Publicacion.Add(new foto(10,10));

           // Console.WriteLine("Hello World!");
        }
    }
}
