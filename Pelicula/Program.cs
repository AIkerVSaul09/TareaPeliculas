using System;
using System.Collections.Generic;

namespace Pelicula
{
    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        private short year{ get; set; }
        private string? país{ get; set; }
        private string? director{ get; set; }
        private string? titulo{ get; set; }

        public Pelicula()
        {
        }
        public Pelicula(string titulo, short año)
            : this()
        {
            this.titulo = titulo;
            this.year = año;
        }
        //Métodos
        public void SetTitulo(string titulo){this.titulo = titulo;}
        public void SetAño(short year){this.year = year;}
        public string? GetTitulo(){return this.titulo;}
        public short GetAño(){return this.year;}
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({year})");
        }
        public void ImprimeActores()
        {
            foreach (Actor actor in actores)
            {
                actor.Imprime();
            }
        }
    }
    public class Actor
    {
        //Propiedades
        private string? nombre{ get; set; }
        private short year{ get; set; }
        public Actor(string nombre, short year)
        {
            this.nombre = nombre;
            this.year = year;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{nombre} ({year})");
        }
        
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Titanic");
            p1.SetAño(1988);
            Pelicula p2 = new Pelicula();
            p2.SetAño(2001);
            p2.SetTitulo("El señor de los anillos");
            p1.Imprime();
            p2.Imprime();
        }
    }
}