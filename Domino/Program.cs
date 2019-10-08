using System;

namespace Domino
{
    class Domino{
        public int a;
        public int b;


        public Domino(int a, int b){
            this.a=a;
            this.b=b;
        }
        public static int operator +(Domino a, Domino b){
            return (a.a+a.b+b.a+b.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino a= new Domino(2,0);
            Domino b= new Domino(4,1);
            Console.WriteLine(a+b);
        }
    }
}
