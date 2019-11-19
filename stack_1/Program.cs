using System;

namespace stack_1
{
  class Stack<T>
    {
  
     private T[] elementos;
     readonly int tamaño;
     private int apuntador=0;
    
     public Stack():this(100)
     {
     }
     public Stack(int size)
     {
         tamaño=size;
         elementos=new T[tamaño];
     }

     public void Push(T elemento)
     {         
        if(apuntador>=tamaño)
        {
           throw new StackOverflowException();
        }
        else{
        elementos[apuntador]=elemento;
        apuntador++;
        }
     }  

    public T Pop()
    {
        apuntador--;
        if(apuntador>=0)
        {         
        return elementos[apuntador];
        }
        else{
            apuntador=0;
            throw new InvalidOperationException("stack vacio");
        }
    }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> cosas= new Stack<string>(4); 
           
            cosas.Push("pluma roja");
            cosas.Push("pluma azul");
            cosas.Push("pluma negra");

            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            
          
          
    
        }
    }
}
