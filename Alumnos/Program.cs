using System;

namespace Alumnos
{
    class Alumnos{
        protected string nombre;
        protected string no_control;
        
        public Alumnos(string n, string nocontrol){
            nombre=n;
            no_control=nocontrol;      

        }
        public virtual string datos_alumno(){
            return string.Format("Su Nombres es: {0}, su No.Control es : {1}",nombre,no_control);
        }
        
    }
    class Licenciatira:Alumnos{
            private string Li;
            public Licenciatira(string nombre, string no_control):base(nombre,no_control){
                this.Li=Li;
            }
            public override string datos_alumno(){
                return base.datos_alumno()+", hago servicio social y recidencia ";
            }    
    }
    class Posgrado:Alumnos{
        private string pos;
        public Posgrado(string nombre, string no_control):base(nombre,no_control){
                this.pos=pos;
            }
            public override string datos_alumno(){
                return base.datos_alumno()+", tengo un tema de investigacion ";
            }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Licenciatira p= new Licenciatira("Jose","12345");
            Posgrado l= new Posgrado ("Javier","01231");
            
            Console.WriteLine(p.datos_alumno());
            Console.WriteLine(l.datos_alumno());
        }
    }
}
