using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\Diego\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null) 
                {
                    Console.WriteLine(linea);

                    contador++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally 
            { 
                if (archivo != null) 
                    {  
                        archivo.Close(); 
                    }
                Console.WriteLine("Conexion finalizada");
            }
            
        }
    }
}
