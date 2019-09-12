using System;
using System.Coleccion.Generic;
namespace peliculas
{
    class peliculas
    {
    public string titulo;
    public Int16 año;
    public string pais;
    public string director;       
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
