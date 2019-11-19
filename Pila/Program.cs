using System;

namespace Stack
{
    public class Pila <T>{
        readonly int tamaño;
        int apuntador =0;
        T[] elementos;
        public Pila(int size){
            tamaño=size;
            elementos=new T[tamaño];
        }
    public void Push(T elementos){
    if (apuntador<tamaño){
        elementos[apuntador]=elementos;
        apuntador++;
    }
    else
    {
        //error
    }
    }
    public T Pop(){
        if (apuntador<tamaño){
        apuntador --;
        return elementos[apuntador];
        }
    }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Pila<string>cosas=new Pila<string>(4);
            cosas.Push("pluma roja");
            cosas.Push("pluma azul");
            cosas.Push("pluma negra");

            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());
            Console.Write(cosas.Pop());

        }
    }
}
