using firsthelloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace firsthelloworld
{


    class Calcular
    {
        double PrimerEntradaUsuario;
        double SegundaEntradaUsuario;



        //Descripción: Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.
        public void PositivePower()
        {
            double resultadoElevadoAlCuadrado;
            Console.WriteLine("Ingresa un numero : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());

            if (PrimerEntradaUsuario >= 0)
            {
                resultadoElevadoAlCuadrado = PrimerEntradaUsuario * PrimerEntradaUsuario;
                Console.WriteLine($"El numero {PrimerEntradaUsuario} elevado al cuadrado es : {resultadoElevadoAlCuadrado}");
            }
            else
            {
                Console.Write($"El numero {PrimerEntradaUsuario} no es valido");
            }

        }
        //Descripción: Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.
        public void DoubleOrTriple()
        {
            Console.WriteLine("Ingresa dos numeros");
            Console.WriteLine("Ingresa el primer numero");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            SegundaEntradaUsuario = double.Parse(Console.ReadLine());
            double resultDoubleOrTriple;

            if (PrimerEntradaUsuario > SegundaEntradaUsuario)
            {
                resultDoubleOrTriple = PrimerEntradaUsuario * 2;
                Console.WriteLine($"El resultado es {resultDoubleOrTriple}");

            }
            else if (SegundaEntradaUsuario > PrimerEntradaUsuario)
            {
                resultDoubleOrTriple = SegundaEntradaUsuario * 3;
                Console.WriteLine($"El restultado es {resultDoubleOrTriple}");
            }
            else
            {
                if (PrimerEntradaUsuario == SegundaEntradaUsuario)
                {
                    Console.WriteLine($"El resultado es {PrimerEntradaUsuario + SegundaEntradaUsuario}");
                }


            }
        }

        //Descripción: Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado.
        public void RootOrSquare()
        {

            Console.WriteLine("Ingresa un numero : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            if (PrimerEntradaUsuario >= 0)
            {
                Console.WriteLine($"La raiz cuadrada del {PrimerEntradaUsuario} es: {Math.Sqrt(PrimerEntradaUsuario)}");
            }
            else
            {
                Console.WriteLine($"El cuadrado del {PrimerEntradaUsuario} es: {(PrimerEntradaUsuario) * (PrimerEntradaUsuario)}");
            }
        }


        public void CirclePerimeter()
        {

            Console.WriteLine("Ingresa el radio de un circulo : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            double Perimetro = 2*Math.PI*PrimerEntradaUsuario;
            Console.WriteLine($"El perimetro del radio {PrimerEntradaUsuario} es : {Perimetro}");
        }

        //Descripción: Pide un número al usuario y devuelve el factorial de ese número;
        public void FactorialFinder()
        {

            double ResultFactorial = 1;
            Console.WriteLine("Ingresa un numero : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());

            if (PrimerEntradaUsuario < 0)
            {
                Console.WriteLine("El numero ingresado debe ser positivo");
            }
            else if (PrimerEntradaUsuario == 0)
            {
                Console.WriteLine($"El factorial de 0 siempres es : {ResultFactorial}");
            }
            else
            {
                for (int i = 1; i <= PrimerEntradaUsuario; i++)
                {
                    ResultFactorial *= i;
                }
                Console.WriteLine($"El factorial del número {PrimerEntradaUsuario} ingresado es : {ResultFactorial}");
            }


        }
    }

}







