using firsthelloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
    }
}







