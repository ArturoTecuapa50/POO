using System;

namespace Herencia_Persona
{
    class Persona{
        //campo
        protected string _nombre;
        //propiedad
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
    class Alumno : Persona{
        protected string num_control;
        public Alumno(string _nombre, string num_control):base(_nombre){//para utilizar el constructor de la clase base"referencia a la clase base " pareciso al this, nomas se puede utilizar una vez
            this. num_control = num_control;
            
        }
        //public void print(){}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persona tom = new Persona("Tom");
            Persona jim = new Persona("Jim");
            tom.print();
            jim.print();
            Alumno luis = new Alumno("Luis", "1921534");
            luis.print();
        }
    }
}
