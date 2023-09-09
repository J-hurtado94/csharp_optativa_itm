using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace firsthelloworld
{
    class Ejecucion
    {

        static void Main(string[] args)
        {

            int EntradaUsuarioOpcion;
            var calcular = new Calcular();
            var CalcularFraction= new CalcularFraction();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Seleccione una opción : ");
                Console.WriteLine(
                    "1. Positive Power\n" +
                    "2. Double or Triple\n" +
                    "3. Root or Square\n" +
                    "4. Circle Perimeter\n" +
                    "5. Midweek Day\n" +
                    "6. Tax Calculator \n" +
                    "7. Remainder Finder\n" +
                    "8. Sum of Evens\n" +
                    "9. Fraction Difference\n" +
                    "10.String Length\n" +
                    "11.Average of Four\n" +
                    "12.Smallest of Five\n" +
                    "13.Vowel Counter\n" +
                    "14.Factorial Finder\n" +
                    "15.InRange Validator\n" +
                    "16.Salir\n"
                    );

                EntradaUsuarioOpcion = int.Parse(Console.ReadLine());


                switch (EntradaUsuarioOpcion)
                {
                    case 1:
                        calcular.PositivePower();
                        break;
                    case 2:
                        calcular.DoubleOrTriple();
                        break;
                    case 3:
                        calcular.RootOrSquare();
                        break;
                    case 4:
                        calcular.CirclePerimeter();
                        break;
                    case 5:
                        calcular.MidweekDay();
                        break;
                    case 6:
                        calcular.TaxCalculator();
                        break;
                    case 7:
                        calcular.RemainderFinder();
                        break;
                    case 8:
                        calcular.SumOfEvens();
                        break;
                    case 9:
                        CalcularFraction.Difference();
                        break;
                    case 10:
                        calcular.StringLength();
                        break;
                    case 11:
                        calcular.AverageofFour();
                        break;
                    case 12:
                        calcular.SmallestOfFive();
                        break;
                    case 13:
                        calcular.VowelCounter();
                        break;
                    case 14:
                        calcular.FactorialFinder();
                        break;
                    case 15:
                        break;
                    case 16:
                        Console.WriteLine("Saliendo...");
                        break;


                }

              if (EntradaUsuarioOpcion > 16)
                {
                    Console.WriteLine($"La opción {EntradaUsuarioOpcion} es errada , ingresa una opción valida ");
                   

                }

                } while (EntradaUsuarioOpcion != 16) ;
            
        }
    }
}
