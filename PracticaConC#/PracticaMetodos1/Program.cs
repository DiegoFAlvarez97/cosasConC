using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Evaluarmos si tienes carnet de conducir");

            Console.WriteLine("¿Que edad tienes?");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes licencia de conducir?");

                string carnet = Console.ReadLine();
                
                if (edad >= 18 && carnet == "si")
                {
                    
                    Console.WriteLine("Usted puede conducir");
                
                }else if (edad >= 18 && carnet == "no")
                {

                    Console.WriteLine("Usted no puede conducir");
                
                }
            }else
            {
                
                Console.WriteLine("Usted no puede conducir");
            
            }

            
            
        }

        //Sobre carga de metodos 

    }
}
