using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("¿Deseas entrar en el bucle While?");

            //string respuesta = Console.ReadLine();

            //while (respuesta != "no")
            //{
            //    Console.WriteLine("Estas dentro del bucle While");

            //    Console.WriteLine("Introduce tu nombre: ");

            //    string nombre = Console.ReadLine();

            //    Console.WriteLine($"Saldras del bucle {nombre} cuando respondas 'no' a la pregunta");

            //    Console.WriteLine("¿Desear repetir otra vez?");

            //    respuesta = Console.ReadLine();

            //}
            //Console.WriteLine("Has salido del bucle While");




            //Ejercicio numero al azar

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int intentos = 0;

            int miNumero = 101;

            //while (aleatorio != miNumero)
            //{
            //    intentos++;

            //    Console.WriteLine("Digite un numero: ");

            //    try 
            //    {
            //        miNumero = int.Parse(Console.ReadLine());
            //    }catch(FormatException ex)
            //    {
            //        Console.WriteLine("No ha introducido un valor numerico valido");
            //    }



            //    if (miNumero > aleatorio)
            //    {
            //        Console.WriteLine("El numemro es menor ");
            //    }else if (miNumero < aleatorio)
            //    {
            //        Console.WriteLine("El numero digitado es mayor ");
            //    }
            //    else if (miNumero == aleatorio)
            //    {
            //        Console.WriteLine($"Adivinaste el numero en {intentos} intentos");
            //    }



            do
            {
                intentos++;

                Console.WriteLine("Digite un numero: ");

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                
                catch (Exception e) when (e.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un erro. Se toma como numero introducido el numero 0 ");
                    //Console.WriteLine(e.Message);
                    miNumero = 0;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Has introducido texto");

                    miNumero = 0;
                }
                


                if (miNumero > aleatorio)
                {
                    Console.WriteLine("El numero es mas mas bajo");
                }
                if (miNumero < aleatorio)
                {
                    Console.WriteLine("El numemro es mas alto");
                }
            } while (aleatorio != miNumero);

            Console.WriteLine($"Haz conseguido el numero en {intentos} intentos");


            Console.WriteLine("Apartir de esta linea el programa continuaria");

        }





    }
}
