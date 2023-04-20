using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(); // Crear un objeto/instancia de tipo Auto.
            //Dar un estado inicial a nuestro auto

            Auto auto2 = new Auto();

            Console.WriteLine(auto1.getInfoAuto());
            Console.WriteLine(auto2.getInfoAuto());

            Auto auto3 = new Auto(4500.25, 1200.35);
            Console.WriteLine(auto3.getInfoAuto());

            auto3.setExtras(true, "Cuero");

            Console.WriteLine(auto3.getExtras());
        }
    }

    class Auto
    {
        //Constructor
        public Auto() 
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            climatizador = true;

            tapiceria = "Tela";

        }

        public Auto(double largoAuto, double anchoAuto)
        {
            ruedas = 4;

            largo = largoAuto;

            ancho = anchoAuto;

            tapiceria = "Tela";
        }

        public String getInfoAuto()
        {
            return "Informacion del Auto:\n Ruedas: "+ruedas+" Largo: "+largo+" Ancho:"+ancho+"";
        }

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {

            return "Extras del auto: \n "+" Tapizeria: "+tapiceria+" Climatizador: "+climatizador;

        }
        
        //Propiedades
        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;

        

    }

}
