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
        
        static void Main(string[] args) {

            int EntradaUsuarioOpcion;
            var calcular = new Calcular();

            do {
                Console.WriteLine("\n");
                Console.WriteLine("Seleccione una opción : ");
                Console.WriteLine(
                    "1. Positive Power\n" +
                    "2. Double or Triple\n" +
                    "3. Root or Square\n" +
                    "4. Circle Perimeter\n" +
                    "5. Midweek Day\n"+
                    "6. Tax Calculator \n" +
                    "7. Remainder Finder\n"+
                    "8. Sum of Evens\n"+
                    "9. Fraction Difference\n"+
                    "10.String Length\n"+
                    "11.Average of Four\n"+
                    "12.Smallest of Five\n"+
                    "13.Vowel Counter\n"+
                    "14.Factorial Finder\n"+
                    "15.InRange Validator\n"+
                    "16.Salir"
                    );

                EntradaUsuarioOpcion = int.Parse(Console.ReadLine());

               

                switch (EntradaUsuarioOpcion) { 
                    case 1:
                        calcular.PositivePower();
                        break;
                    case 2:
                        calcular.DoubleOrTriple();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;


                }

            }while (EntradaUsuarioOpcion!=16);
        }
    }
}
