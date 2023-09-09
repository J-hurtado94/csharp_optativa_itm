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
        private double PrimerEntradaUsuario;
        private double SegundaEntradaUsuario;
        private double TerceraEntradaUsuario;
        private double CuartaEntradaUsuario;
        private double QuintaEntradaUsuario;
        private double impuesto = 15;
        private string EntradaUsuario;



        enum DiasSemana
        {

            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes

        }



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
            double Perimetro = 2 * Math.PI * PrimerEntradaUsuario;
            Console.WriteLine($"El perimetro del radio {PrimerEntradaUsuario} es : {Perimetro}");
        }

        // Solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables.

        public void MidweekDay()
        {
            Console.WriteLine("Ingresa un número del 1 al 7 : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            switch (PrimerEntradaUsuario)
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
        public void TaxCalculator()
        {
            double Excedente;
            Console.WriteLine("Por favor digite su salario anual:");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());

            if (PrimerEntradaUsuario > 12000)
            {
                Excedente = PrimerEntradaUsuario - 12000;
                Console.WriteLine($"El impuesto a pagar es : {Excedente * impuesto / 100}");
            }
            else
            {
                Console.WriteLine("No debe impuestos");
            }







        }


        //Descripción: Solicita dos números y muestra el residuo de la división del primero entre el segundo.
        public void RemainderFinder()
        {
            Console.WriteLine("Por favor ingresa el primer numero:");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            SegundaEntradaUsuario = double.Parse(Console.ReadLine());
            if (PrimerEntradaUsuario == 0 || SegundaEntradaUsuario == 0)
            {
                Console.WriteLine("Por favor ingresar un numero mayor a 0");
            }
            else
            {
                double Residuo = PrimerEntradaUsuario % SegundaEntradaUsuario;
                Console.WriteLine($"El residuo es : {Residuo}");
            }
        }

        //Descripción: Calcula y muestra la suma de los números pares entre 1 y 50. 

        public void SumOfEvens()
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
        public void StringLength()
        {

            Console.WriteLine("Por favor ingresa una palabra:");
            EntradaUsuario = Console.ReadLine();
            string CorrectString = EntradaUsuario.Replace(",", "").Replace(".", "").Replace(" ", "");
            Console.WriteLine($"El tamaño de la palabra es : {CorrectString.Length}");



        }

        //Descripción: Pide al usuario cuatro números y muestra el promedio. 

        public void AverageofFour()
        {
            Console.WriteLine("Por favor ingresa cuatro numeros");
            Console.WriteLine("Por favor ingresa el primer numero:");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            SegundaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el tercer numero:");
            TerceraEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el cuarto numero:");
            CuartaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<double> NumerosList = new List<double>();
            NumerosList.Add(PrimerEntradaUsuario);
            NumerosList.Add(SegundaEntradaUsuario);
            NumerosList.Add(TerceraEntradaUsuario);
            NumerosList.Add(CuartaEntradaUsuario);

            int CantidadDeValores = NumerosList.Count;
            double SumaDeValores = 0;
            foreach (double numeros in NumerosList)
            {
                SumaDeValores += numeros;

            }
            Console.WriteLine($"El promedio de los números ingresados es de: {SumaDeValores / CantidadDeValores}");

        }

        //Descripción: Pide al usuario cinco números y muestra el más pequeño
        public void SmallestOfFive()
        {
            Console.WriteLine("Por favor ingresa cinco numeros");
            Console.WriteLine("Por favor ingresa el primer numero:");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el segundo numero:");
            SegundaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el tercer numero:");
            TerceraEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el cuarto numero:");
            CuartaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresa el quinto numero:");
            QuintaEntradaUsuario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<double> ListOfNumbers = new List<double>();
            ListOfNumbers.Add(PrimerEntradaUsuario);
            ListOfNumbers.Add(SegundaEntradaUsuario);
            ListOfNumbers.Add(TerceraEntradaUsuario);
            ListOfNumbers.Add(CuartaEntradaUsuario);
            ListOfNumbers.Add(QuintaEntradaUsuario);

            Console.WriteLine($"El número mas pequeño es: {ListOfNumbers.Min()}");

        }

        //Descripción: Pide una palabra al usuario y devuelve el número de vocales enesa palabra.
        public void VowelCounter()
        {

            Console.WriteLine("Por favor ingrese una palabra:");

            EntradaUsuario = Console.ReadLine().ToLower();

            List<char> EntradaList = EntradaUsuario.ToList();


            List<char> VowelList = new List<char>();

            VowelList.Add('a');
            VowelList.Add('e');
            VowelList.Add('i');
            VowelList.Add('o');
            VowelList.Add('u');

            string CantidadVocal="";

            for (int i = 0; i < EntradaUsuario.Length; i++)
            {
                for (int j = 0;  j <=EntradaUsuario.Length;  j++)
                {
                    if (EntradaList[i] == VowelList[j])
                    {
                        CantidadVocal += EntradaList[i];
                        
                    }


                }
            }
            Console.WriteLine(CantidadVocal.Length);




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

        public void InRangeValidator()
        {
            Console.WriteLine("Ingresa un numero : ");
            PrimerEntradaUsuario = double.Parse(Console.ReadLine());
            if (PrimerEntradaUsuario>= 10 && PrimerEntradaUsuario <=20)
            {
                Console.WriteLine($"El numero {PrimerEntradaUsuario} esta en el rango");
            }
            else
            {
                Console.WriteLine($"El numero {PrimerEntradaUsuario} esta fuera del rango");

            }

        }
    }

    


    }







