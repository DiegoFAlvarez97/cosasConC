using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Elige tu medio de transporte (coche, tren, avion)");
            //string medioTransporte = Console.ReadLine();

            //switch (medioTransporte)
            //{
            //    case "coche":
            //        Console.WriteLine("Velocidad media: 100km/h");
            //        break;

            //    case "tren":
            //        Console.WriteLine("Velocidad media: 250km/h");
            //        break;

            //    case "avion":
            //        Console.WriteLine("Velocidad media: 800km/h");
            //        break;

            //    default:
            //        Console.WriteLine("Transporte no contemplado");
            //        break;
            //}

            Console.WriteLine("Introduce un numero de Mes para el calculo de la comision");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes elegido: Enero");
                    break;

                case 2:
                    Console.WriteLine("Mes elegido: Febrero");
                    break;

                case 3:
                    Console.WriteLine("Mes elegido: Marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes elegido: Abril");
                    break;

                case 5:
                    Console.WriteLine("Mes elegido: Mayo");
                    break;

                case 6:
                    Console.WriteLine("Mes elegido: Junio");
                    break;

                case 7:
                    Console.WriteLine("Mes elegido: Julio");
                    break;

                case 8:
                    Console.WriteLine("Mes elegido: Agosto");
                    break;

                case 9:
                    Console.WriteLine("Mes elegido: Septiembre");
                    break;

                case 10:
                    Console.WriteLine("Mes elegido: Octubre");
                    break;

                case 11:
                    Console.WriteLine("Mes elegido: Noviembre");
                    break;

                case 12:
                    Console.WriteLine("Mes elegido: Diciembre");
                    break;

                default:
                    Console.WriteLine("Numero de mes no encontrado");
                    break;
            }


            Console.WriteLine("Ha finalizado el programa");
        }
    }
}
