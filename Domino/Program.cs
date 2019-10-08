using System;

namespace Domino
{
    class Domino{
        public int a;
        public int b;


        public domino(int a, int b){
            this.a=a;
            this.b=b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            domino a= new domino(2,0);
            domino b= new domino(4,1);
            Console.WriteLine(a+b);
        }
    }
}
