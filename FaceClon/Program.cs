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
        public foto(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){

        }
        public override void imprime(){
            Console.WriteLine("La fecha es: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }
        
    }
    class Estado:Publicacion{
        public Estado(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){
            
        }
        public override void imprime(){
            Console.WriteLine("La fecha de publicacion: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }
    }
    class Link:Publicacion{
        public Link(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){
            
        }
        public override void imprime(){
            Console.WriteLine("La fecha de publicacion: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            foto f= new foto("12/10/14","Que bueno que esten bien","Me asombra");
            //f.imprime();
            //
            Estado e=new Estado("21/03/19","Que cool foto","Me divierte");
            //e.imprime();
            //
            Link l=new Link("31/10/19","Que buen disfraz de hallowin!!!!","Me encanta");
            //l.imprime();

           // Console.WriteLine("Hello World!");
            

            List<Publicacion> o = new List<Publicacion>();
            o.Add(f);
            o.Add(e);
            o.Add(l);
            foreach(Publicacion p in o)
            {
                p.imprime();
            }
        }
    }
}
