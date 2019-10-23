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
        int hora=h*60;
        Console.WriteLine("horas a minutos");
        Console.WriteLine("{0}", hora);
        Console.WriteLine("horas a segundos");
        int segundos=h*360;
        Console.WriteLine("{0}", segundos);
        int minutos=m*60;
    }
    public static int operator +(Duracion T2 ,Duracion T3){
     return  ((T2.h+T3.h)*3600)+((T2.m+T3.m)*60)+((T2.s+T3.s));
  
    }
    
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primera pelicula");
            Duracion T= new Duracion(2, 15, 12);
            T.imprime();
            T.conversion();
            //
            Console.WriteLine("segunda pelicula");
            Duracion T1=new Duracion(2,15,12);
            T1.imprime();
            T1.conversion();
            //
            T.imprime();
            Console.WriteLine("la duracion de las dos peliculas son : (en segundos)");
            Console.WriteLine(T+T1);
            
        }
    }
}
