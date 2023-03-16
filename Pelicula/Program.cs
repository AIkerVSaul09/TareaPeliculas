using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
           Pelicula p1 = new Pelicula();
           Actor
           p1.SetTitulo("La La Land");
           p1.SetAño(2016);
           p1.SetPais ("Estados Unidos Hong Kong")
           p1.SetDirector("Damien Chazelle")
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño(),p1.GetPais(),GetDirector());
        }
    }
}
