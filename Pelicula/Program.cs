using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private short year;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        //public Pelicula (string t,short a)
        //{
            //this.titulo=t; this.año=a;
        //}
        //Métodos
        public void Imprime()
        {
        //Console.WriteLine($"{titulo} ({año})");
        }

        public void setTitulo(string t)
        {
            titulo=t;
        }
        public string getTitulo()
        {
            return titulo;
        }

        public void setAño(short a)
        {
            year=a;
        }
        public short getAño()
        {
            return year;
        }
    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        //public void Imprime()
        //{
            //Console.WriteLine($"{Titulo} ({ano})");
        //}
        
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {        
            Pelicula p1 = new Pelicula();           
            p1.setTitulo("Interestelar");
            p1.setAño(2014);
            Pelicula p2 = new Pelicula();
            p2.setTitulo("Top Gun");
            p2.setAño(2022);
            Console.WriteLine($"{p1.getTitulo()} - {p1.getAño()}");
            Console.WriteLine($"{p2.getTitulo()} - {p2.getAño()}"); 
        }
    }
}