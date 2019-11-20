using System;

namespace Stack
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
        {
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
           
            cosas.Push("uno");
            cosas.Push("dos");
            cosas.Push("tres");

            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            
        }
    }
}
