﻿using System;
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
            string NombreUsuario;
            var calcular = new Calcular();
            var CalcularFraction = new CalcularFraction();

            try {
                Console.WriteLine("\n");
                Console.WriteLine("Ingresa tu nombre : \n");
                NombreUsuario = Console.ReadLine();
                do
                {
                   
                    Console.WriteLine("\n");
                    Console.WriteLine($"{NombreUsuario} Bienvenido al menú, seleccione la opción que desea : \n");
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
                            calcular.positivePower();
                            break;
                        case 2:
                            calcular.doubleOrTriple();
                            break;
                        case 3:
                            calcular.rootOrSquare();
                            break;
                        case 4:
                            calcular.circlePerimeter();
                            break;
                        case 5:
                            calcular.midWeekDay();
                            break;
                        case 6:
                            calcular.taxCalculator();
                            break;
                        case 7:
                            calcular.remainderFinder();
                            break;
                        case 8:
                            calcular.sumOfEvens();
                            break;
                        case 9:
                            CalcularFraction.Difference();
                            break;
                        case 10:
                            calcular.stringLength();
                            break;
                        case 11:
                            calcular.averageOfFour();
                            break;
                        case 12:
                            calcular.smallestOfFive();
                            break;
                        case 13:
                            calcular.vowelCounter();
                            break;
                        case 14:
                            calcular.FactorialFinder();
                            break;
                        case 15:
                            calcular.InRangeValidator();
                            break;
                        case 16:
                            Console.WriteLine("Saliendo...");
                            break;


                    }

                    if (EntradaUsuarioOpcion > 16)
                    {
                        Console.WriteLine($"La opción {EntradaUsuarioOpcion} es errada , ingresa una opción valida ");


                    }

                } while (EntradaUsuarioOpcion != 16);

            }
            catch (FormatException f)
            {
                Console.WriteLine("Haz ingresado una opción incorrecta, intenta de nuevo. Selecciona una opción:");
                Main(args);
            }
            }
    }
}
