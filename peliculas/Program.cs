using System;
using System.Coleccion.Generic;
namespace peliculas
{
    class peliculas
    {
    private string titulo;
    private Int16 año;
    private string pais;
    private
     string director; 

     public void setTitulo(string titulo){
        this.titulo=titulo;
    }
    public string getTitulo(){
        return this.titulo;
    }
    public void setAño(Int16 año){
        this.año = año;
    }
    public Int16 getAño(){
        return this.año;
    }
    public void setPais(string pais){
        this.pais=pais;
    }
    public string getPais(){
        return this.pais;
    }
    public void setDirector(string director){
        this.director=director;
    }
    public string getDirector(){
        return this.director;
    }      
    }
    class Program
    {
        static void Main(string[] args)
        {
            peliculas peli1 = new peliculas();
            peli1.setTitulo("Black Panther");
            peli1.setAño(2018);
            Console.WriteLine("{0}, ({1})" , peli1.getTitulo(), peli1.getAño());
        
        }
    }
}
