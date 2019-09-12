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
            peliculas = peli1 new peliculas();
            peli1.titulo = "El Renacido" ;
            peli1.año = 2016 ;
            peli1.pais = "Estados Unidos";
            peli1.director = "Alejandro González Iñárritu";
            
            peliculas = peli2 new peliculas();
            peli2.titulo = "Black Panther" ;
            peli2.año = 2018 ;
            peli2.pais = "Estados Unidos";
            peli2.director = "Ryan Coogler";
            
            Console.WriteLine("Peliculas ganadora a un Oscar: titulo: {0}, año: {1}",peli1.titulo, peli1.año);
            Console.WriteLine("Peliculas ganadora a un Oscar: titulo: {0}, año: {1}",peli2.titulo, peli2.año);
        }
    }
}
