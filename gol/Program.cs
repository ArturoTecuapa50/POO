﻿using System;
using System.Collections.Generic;

namespace gol
{
    enum Estado { viva, vacia}
    class Celula {
        public Estado estado_actual;
        public Estado estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        
        public Celula(Estado inicial, Tablero tablero ,   short renglon, short columna)
        {
            estado_actual = inicial;
            this.tablero = tablero;
            this.renglon = renglon;
            this.columna = columna;
            estado_siguiente=inicial;
        }

        public void actualiza_estado(){
            estado_actual = estado_siguiente;
        }

        public void actualiza_estado_siguiente(){
            //actualizar estado_siguiente
            //siguiendo las reglas del juego
            short vecinas = num_vecinas();
            if(estado_actual == Estado.viva && (vecinas < 2 || vecinas > 3)) {
				estado_siguiente = Estado.vacia;
			}
			if(estado_actual == Estado.vacia && vecinas == 3) {
				estado_siguiente = Estado.viva;
			}

        }

       public short num_vecinas()
        {   short cuenta = 0;
            // 1 
            
            if(  tablero.verificacion(renglon -1, columna-1) && tablero.celula_estado_final(renglon -1, columna -1) == Estado.viva){
              cuenta++;
            }
            if( tablero.verificacion(renglon -1, columna) && tablero.celula_estado_final(renglon -1, columna ) == Estado.viva){
                cuenta++;
            }
            if(  tablero.verificacion(renglon -1, columna +1) && tablero.celula_estado_final(renglon -1, columna +1) == Estado.viva){
                cuenta++;
            }
            //falta hacer lo mismo para las otras vecinas            
            if(  tablero.verificacion(renglon, columna-1) && tablero.celula_estado_final(renglon -1, columna -1) == Estado.viva){
                cuenta++;
            }
            
            if(  tablero.verificacion(renglon, columna +1) && tablero.celula_estado_final(renglon -1, columna +1) == Estado.viva){
                cuenta++;
            }        
            //falta hacer lo mismo para las otras vecinas            
            if(  tablero.verificacion(renglon +1, columna-1) && tablero.celula_estado_final(renglon +1, columna -1) == Estado.viva){
                cuenta++;
            }
            if(  tablero.verificacion(renglon +1, columna ) && tablero.celula_estado_final(renglon +1, columna ) == Estado.viva){
                cuenta++;
            }
            if(  tablero.verificacion(renglon +1, columna +1) && tablero.celula_estado_final(renglon +1, columna +1) == Estado.viva){
                cuenta++;
            }
            //falta hacer lo mismo para las otras vecinas            
            return cuenta;
        } 

         public void print(){
           if (this.estado_actual == Estado.vacia){
                Console.Write("▒");
           } 
           else 
           {
                Console.Write("█");
           }
            
        }
    }
    

    class Tablero {
        public List<List<Celula >> grid; 
        public short num_renglones;
        public short num_columnas;      
        public Tablero(short num_renglones, short num_columnas){
              grid = new List<List<Celula>>(); 
              this.num_renglones = num_renglones;
              this.num_columnas = num_columnas;
              for (short i=0; i<= num_renglones-1; i++)
              {
                 grid.Add(new List<Celula>()); 
                 for (short j = 0; j <= num_columnas-1; j++)
                 {
                    grid[i].Add(new Celula(Estado.vacia, this, i,j));
                 }
              }

        }      

        public void actualiza_estado_todas(){
            foreach(List<Celula> renglon in grid)
            {
               foreach(Celula c in renglon)
               {
                    c.actualiza_estado();
                }                     
            }
        }
        //verificar si cumple la condicion dentro del tablero
        public bool verificacion(int renglon, int columna){
           if((renglon < 0 || renglon >= num_renglones) || (columna < 0 || columna >= num_columnas)) {
                return false;
            } else {
                return true;
            }  
        }

        //registra el estado si vive esta vacia
        public Estado celula_estado_final(int renglon, int columna){
            return grid[renglon][columna].estado_actual;

        }


        //cambia el estado de todas las celdas

        public void inserta(Celula c){
                grid[c.renglon][c.columna] = c;
        }

        public void print(){
            string tablero_de_juego ="";
            foreach(List<Celula> renglon in grid)
            {
               foreach(Celula c in renglon)
               {
                    tablero_de_juego += c.print();
                } 
                tablero_de_juego +="\n";        
            }     
            Console.WriteLine(tablero_de_juego);             
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
             Tablero GoL = new Tablero(10,5);
             GoL.inserta( new Celula(Estado.viva,GoL, 3,3  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 3,2  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 3,1  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 0,0  ) );
             
             GoL.print(); 
             //actualizar el estado_siguiente de todas las celulas
             //actualizar el estado_actual con el siguiente
             //volver a imprimir
             //repetir haciendo una pausa
             Console.WriteLine(GoL.grid[1][1].num_vecinas()); 
             GoL.actualiza_estado_todas();
			 GoL.print(); 
        }
    }
}