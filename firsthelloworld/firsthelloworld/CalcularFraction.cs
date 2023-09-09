using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosoptativa
{
    //Descripción: Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones.
    internal class CalcularFraction
    {
        string PrimerEntradaUsuario;
        string SegundaEntradaUsuario;
        public void Difference()
        {
            try
            {
                Console.WriteLine("Por favor ingresa la primer fraccion, de la siguiente manera 1/2:");
                PrimerEntradaUsuario = Console.ReadLine();
                Console.WriteLine("Por favor ingresa la Segunda fraccion, de la siguiente manera 1/2 :");
                SegundaEntradaUsuario = Console.ReadLine();
                string[] FraccionUnoWithOutSlash = PrimerEntradaUsuario.Split('/');
                string[] FraccionDosWithOutSlash = SegundaEntradaUsuario.Split('/');
                int[] DivisionUno = new int[FraccionUnoWithOutSlash.Length];
                int[] DivisionDos = new int[FraccionDosWithOutSlash.Length];


                for (int i = 0; i < FraccionUnoWithOutSlash.Length; i++)
                {
                    int Parseo = int.Parse(FraccionUnoWithOutSlash[i]);
                    DivisionUno[i] = Parseo;


                }
                for (int i = 0; i < FraccionDosWithOutSlash.Length; i++)
                {
                    int Parseo = int.Parse(FraccionDosWithOutSlash[i]);
                    DivisionDos[i] = Parseo;


                }
                if (DivisionUno[0] == DivisionDos[0] && DivisionUno[1] == DivisionDos[1])
                {
                    Console.WriteLine($"La Diferencia es : {(DivisionUno[0] / DivisionUno[1]) - (DivisionDos[0] / DivisionDos[1])}");
                }else if (DivisionUno[0]==0 && DivisionDos[0]==0)
                {
                    Console.WriteLine("El Diferencia es: 0 ");
                }
                else
                {
                    Console.WriteLine($"La Diferencia es: {(DivisionUno[0] * DivisionDos[1]) - (DivisionDos[0] * DivisionUno[1])}/{DivisionUno[1] * DivisionDos[1]}");
                }
            }
            catch (DivideByZeroException ex) { Console.WriteLine("Ingresaste un cero en el denominador, vuelve a intentarlo"); }


        }

    }
}
