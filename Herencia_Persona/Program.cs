using System;

namespace Herencia_Persona
{
    class Persona{
        private string _nombre;

        public string Nombre{
            get {
                //return _nombre <---- cuando es privada
                return _nombre;
            }
        }
        public Persona(string n){
            _nombre=n;
        }
        public void print(){
            Console.WriteLine("Mi nombre es {0}",_nombre);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persona tom = new Persona("Tom");
            Persona jim = new Persona("Jim");
            tom.print();
            jim.print();
        }
    }
}
