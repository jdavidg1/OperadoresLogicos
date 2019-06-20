using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables e inicialización
            double energia = 0;
            bool propulsorIzq = false;
            bool propulsorDer = false;

            Console.WriteLine("Como está el propulsor izquierdo true/false");
            propulsorIzq = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Como está el propulsor derecho true/false");
            propulsorDer = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Como está la energía en porcentaje ");
            energia = Convert.ToDouble(Console.ReadLine());


            if ((propulsorDer && propulsorIzq)==true && energia >=75))

                
            {

                Console.WriteLine("El avión puede despegar ");

            }

            else

            {

                Console.WriteLine("El equipo no puede despegar");

            }

            Console.ReadKey();
        }
    }
}
