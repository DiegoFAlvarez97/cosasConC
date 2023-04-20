using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // Creacion de objeto de tipo Circulo. Variable/objeto de tipo circulo
        
            miCirculo = new Circulo(); //Iniciacion de variable objeto de tipo Circulo. Instanciar una Clase
            // Instanciacion. Ejemplarizacion. Creacion de ejemplar de clase 

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));

            miCirculo.pi = 50.45;

            Console.WriteLine(miCirculo.calculoArea(5));
        }
    }

    class Circulo
    {
        double pi = 3.1416; //Propiedad de la clase Circulo. //Campo de clase.

        public double calculoArea(int radio) //Metodo de clase. ¿Que pueden hacer los objetos de tipo ciculo?
        {

            return pi * radio * radio;

        }

    }
}
