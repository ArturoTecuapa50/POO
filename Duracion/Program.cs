using System;

namespace Duracion
{
    class Duracion{
        public int h;
        public int m;
        public int s;

    public Duracion(int h, int m, int s){
        this.h=h;
        this.m=m;
        this.s=s;
    }
    public Duracion(){

    }
    
    public void imprime(){
        Console.WriteLine("{0}: {1}: {2}", h, m, s);

    }

    public void conversion(){
        int hora=h*360;
        Console.WriteLine("horas a minutos");
        Console.WriteLine("{0}", hora);
        Console.WriteLine("minutos totales");
        int suma=hora+m;
        Console.WriteLine("{0}", suma);
        Console.WriteLine("horas a segundos");
        int segundos=h*3600;
        Console.WriteLine("{0}", segundos);
        int minutos=m*60;
        Console.WriteLine("minutos a segundos");
        Console.WriteLine("{0}", minutos);
        Console.WriteLine("segundos totales");
        int sumas=segundos+minutos+s;
         Console.WriteLine("{0}", sumas);

    }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Duracion T= new Duracion(2, 15, 12);
            T.imprime();
            T.conversion();
            //
            T.imprime();
            
        }
    }
}
