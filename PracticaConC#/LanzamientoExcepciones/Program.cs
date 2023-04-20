using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero de Mes");

            int NumeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Mensaje de la excepcion: "+ ex.Message);
            }

            Console.WriteLine("Aqui continuara el resto de la ejecucion");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                
                case 2:
                    return "Febrero";
                
                case 3:
                    return "Marzo";
                
                case 4:
                    return "Abril";
                
                case 5:
                    return "Mayo";
                
                case 6:
                    return "Junio";
                
                case 7:
                    return "Julio";
                
                case 8:
                    return "Agosto";
                
                case 9:
                    return "Septiembre";
                
                case 10:
                    return "Octubre";
                
                case 11:
                    return "Noviembre";
                
                case 12:
                    return "Diembre";


                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
