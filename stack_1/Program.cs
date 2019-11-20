using System;

namespace stack_1
{
  class Stack<T>
    {
  
     T[] elementos;
     readonly int tamaño;
     int apuntador=0;
    
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
        if(apuntador>0)
        {      
        T elemento=elementos[0];
        for (int i = 1; i < apuntador; i++){
            elementos[i-1]=elementos[i];
        }   
        apuntador--;
        return elemento;
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
            Stack<int> cosas= new Stack<int>(4); 
           
            cosas.Push(1);
            cosas.Push(2);
            cosas.Push(3);

            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());   
            
 
        }
    }
}
