using firsthelloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace firsthelloworld
{


    class Calcular
    {
        private double primerEntradaUsuario;
        private double segundaEntradaUsuario;
        private double terceraEntradaUsuario;
        private double cuartaEntradaUsuario;
        private double quintaEntradaUsuario;
        private double impuesto = 15;
        private string entradaUsuario;



        enum DiasSemana
        {

            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes

        }



        //Descripción: Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.
        public void positivePower()
        {
            double resultadoElevadoAlCuadrado;
            Console.WriteLine("Ingresa un numero : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());

            if (primerEntradaUsuario >= 0)
            {
                resultadoElevadoAlCuadrado = primerEntradaUsuario * primerEntradaUsuario;
                Console.WriteLine($"El numero {primerEntradaUsuario} elevado al cuadrado es : {resultadoElevadoAlCuadrado}");
            }
            else
            {
                Console.Write($"El numero {primerEntradaUsuario} no es valido");
            }

        }
        //Descripción: Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.
        public void doubleOrTriple()
        {
            Console.WriteLine("Ingresa dos numeros");
            Console.WriteLine("Ingresa el primer numero");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            segundaEntradaUsuario = double.Parse(Console.ReadLine());
            double resultDoubleOrTriple;

            if (primerEntradaUsuario > segundaEntradaUsuario)
            {
                resultDoubleOrTriple = primerEntradaUsuario * 2;
                Console.WriteLine($"El resultado es {resultDoubleOrTriple}");

            }
            else if (segundaEntradaUsuario > primerEntradaUsuario)
            {
                resultDoubleOrTriple = segundaEntradaUsuario * 3;
                Console.WriteLine($"El restultado es {resultDoubleOrTriple}");
            }
            else
            {
                if (primerEntradaUsuario == segundaEntradaUsuario)
                {
                    Console.WriteLine($"El resultado es {primerEntradaUsuario + segundaEntradaUsuario}");
                }


            }
        }

        //Descripción: Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado.
        public void rootOrSquare()
        {

            Console.WriteLine("Ingresa un numero : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            if (primerEntradaUsuario >= 0)
            {
                Console.WriteLine($"La raiz cuadrada del {primerEntradaUsuario} es: {Math.Sqrt(primerEntradaUsuario)}");
            }
            else
            {
                Console.WriteLine($"El cuadrado del {primerEntradaUsuario} es: {(primerEntradaUsuario) * (primerEntradaUsuario)}");
            }
        }


        public void circlePerimeter()
        {

            Console.WriteLine("Ingresa el radio de un circulo : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            double Perimetro = 2 * Math.PI * primerEntradaUsuario;
            Console.WriteLine($"El perimetro del radio {primerEntradaUsuario} es : {Perimetro}");
        }

        // Solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables.

        public void midWeekDay()
        {
            Console.WriteLine("Ingresa un número del 1 al 7 : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            switch (primerEntradaUsuario)
            {
                case 1:
                    Console.WriteLine($"El día de la semana es : {DiasSemana.Lunes}");
                    break;
                case 2:
                    Console.WriteLine($"El día de la semana es : {DiasSemana.Martes}");
                    break;
                case 3:
                    Console.WriteLine($"El día de la semana es : {DiasSemana.Miercoles}");
                    break;
                case 4:
                    Console.WriteLine($"El día de la semana es : {DiasSemana.Jueves}");
                    break;
                case 5:
                    Console.WriteLine($"El día de la semana es : {DiasSemana.Viernes}");
                    break;

                default:
                    Console.WriteLine("Número fuera del rango laboral.");
                    break;
            }


        }



        //Descripción: Solicita al usuario su salario anual y, si este excede los 12000,muestra el impuesto a pagar que es el 15% del excedente.
        public void taxCalculator()
        {
            double Excedente;
            Console.WriteLine("Por favor digite su salario anual:");
            primerEntradaUsuario = double.Parse(Console.ReadLine());

            if (primerEntradaUsuario > 12000)
            {
                Excedente = primerEntradaUsuario - 12000;
                Console.WriteLine($"El impuesto a pagar es : {Excedente * impuesto / 100}");
            }
            else
            {
                Console.WriteLine("No debe impuestos");
            }







        }


        //Descripción: Solicita dos números y muestra el residuo de la división del primero entre el segundo.
        public void remainderFinder()
        {
            Console.WriteLine("Por favor ingresa el primer numero:");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            segundaEntradaUsuario = double.Parse(Console.ReadLine());
            if (primerEntradaUsuario == 0 || segundaEntradaUsuario == 0)
            {
                Console.WriteLine("Por favor ingresar un numero mayor a 0");
            }
            else
            {
                double Residuo = primerEntradaUsuario % segundaEntradaUsuario;
                Console.WriteLine($"El residuo es : {Residuo}");
            }
        }

        //Descripción: Calcula y muestra la suma de los números pares entre 1 y 50. 

        public void sumOfEvens()
        {
            int SumaPares = 0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    SumaPares += i;

                }
            }
            Console.WriteLine($"La suma de pares es: {SumaPares}");
        }

        //Descripción: Pide una palabra al usuario y muestra la longitud de esa palabra.
        public void stringLength()
        {

            Console.WriteLine("Por favor ingresa una palabra:");
            entradaUsuario = Console.ReadLine();
            string CorrectString = entradaUsuario.Replace(",", "").Replace(".", "").Replace(" ", "");
            Console.WriteLine($"El tamaño de la palabra es : {CorrectString.Length}");



        }

        //Descripción: Pide al usuario cuatro números y muestra el promedio. 

        public void averageOfFour()
        {
            Console.WriteLine("Por favor ingresa cuatro numeros");
            Console.WriteLine("Por favor ingresa el primer numero:");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            segundaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el tercer numero:");
            terceraEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el cuarto numero:");
            cuartaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<double> NumerosList = new List<double>();
            NumerosList.Add(primerEntradaUsuario);
            NumerosList.Add(segundaEntradaUsuario);
            NumerosList.Add(terceraEntradaUsuario);
            NumerosList.Add(cuartaEntradaUsuario);

            int CantidadDeValores = NumerosList.Count;
            double SumaDeValores = 0;
            foreach (double numeros in NumerosList)
            {
                SumaDeValores += numeros;

            }
            Console.WriteLine($"El promedio de los números ingresados es de: {SumaDeValores / CantidadDeValores}");

        }

        //Descripción: Pide al usuario cinco números y muestra el más pequeño
        public void smallestOfFive()
        {
            Console.WriteLine("Por favor ingresa cinco numeros");
            Console.WriteLine("Por favor ingresa el primer numero:");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            segundaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el tercer numero:");
            terceraEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el cuarto numero:");
            cuartaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el quinto numero:");
            quintaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<double> ListOfNumbers = new List<double>();
            ListOfNumbers.Add(primerEntradaUsuario);
            ListOfNumbers.Add(segundaEntradaUsuario);
            ListOfNumbers.Add(terceraEntradaUsuario);
            ListOfNumbers.Add(cuartaEntradaUsuario);
            ListOfNumbers.Add(quintaEntradaUsuario);

            Console.WriteLine($"El número mas pequeño es: {ListOfNumbers.Min()}");

        }

        //Descripción: Pide una palabra al usuario y devuelve el número de vocales enesa palabra.
        public void vowelCounter()
        {

            Console.WriteLine("Por favor ingrese una palabra:");

            entradaUsuario = Console.ReadLine().ToLower();

            int cantidadVocal=0;

            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letras in entradaUsuario) {
                if (Vowels.Contains(letras))
                {

                    cantidadVocal++;
                    
                }
            }

             
            Console.WriteLine($"La cantidad de vocales que tiene la palabra {entradaUsuario} es de: {cantidadVocal}");




        }


        //Descripción: Pide un número al usuario y devuelve el factorial de ese número;
        public void FactorialFinder()
        {

            double ResultFactorial = 1;
            Console.WriteLine("Ingresa un numero : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());

            if (primerEntradaUsuario < 0)
            {
                Console.WriteLine("El numero ingresado debe ser positivo");
            }
            else if (primerEntradaUsuario == 0)
            {
                Console.WriteLine($"El factorial de 0 siempres es : {ResultFactorial}");
            }
            else
            {
                for (int i = 1; i <= primerEntradaUsuario; i++)
                {
                    ResultFactorial *= i;
                }
                Console.WriteLine($"El factorial del número {primerEntradaUsuario} ingresado es : {ResultFactorial}");
            }


        }


        //Descripción: Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos).
        public void InRangeValidator()
        {
            Console.WriteLine("Ingresa un numero : ");
            primerEntradaUsuario = double.Parse(Console.ReadLine());
            if (primerEntradaUsuario >= 10 && primerEntradaUsuario <= 20)
            {
                Console.WriteLine($"El numero {primerEntradaUsuario} esta en el rango");
            }
            else
            {
                Console.WriteLine($"El numero {primerEntradaUsuario} esta fuera del rango");

            }

        }
    }




}







