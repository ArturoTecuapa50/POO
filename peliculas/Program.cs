using System;
using System.Collections.Generic;
namespace peliculas
{
    class Actor
	{
		public string nombre;
		public Int16 año;
		public Actor(string nombre, Int16 año) {
			this.nombre = nombre;
			this.año = año;
		}
	}
    
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
    public peliculas(String titulo, Int16 año){
        this.titulo=titulo;
        this.año=año;
    }
    public peliculas(){
        
    }
    public void imprime(){
        Console.WriteLine("{0}, {1}", this.getTitulo(), this.getAño());
    }
        
    private List<Actor> actores = new List<Actor>();
    public void AgregarActor(Actor actor) {
			actores.Add(actor);
	}
	public void ImprimeActores() {
			foreach(Actor actor in actores)
				Console.WriteLine("{0} ({1})", actor.nombre, actor.año);
	}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
             peliculas pelis1 = new peliculas("Black Panther",2018);
            pelis1.imprime();
            
            peliculas pelis2 = new peliculas("La La Land", 2016);
			pelis2.AgregarActor(new Actor("Ryan Gosling", 1980));
			pelis2.AgregarActor(new Actor("Emma Stone", 1988));

			pelis2.ImprimeActores();
        
        }
    }
}
