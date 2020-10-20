using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int resultSuma = 0;
            int resultResta = 0;
            int resultMultiplicacion = 0;
            int resultDiv = 0;
            int resultMod = 0;
            int resultPromedio = 0;
            int maximo = 0;
            int minimo = 0;

            Console.WriteLine("Programa para comparar dos números.");
            Console.Write("Ingrese número 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese número 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //result = number1 + number2;
                //resultResta = number1 - number2;
                //resultMult = number1 * number2;


                //Console.WriteLine("El resultado de sumar {0} con {1} es igual a {2}", number1, number2, result);
                //Console.WriteLine("El resultado de restar {0} con {1} es igual a {2}", number1, number2, resultResta);
                //Console.WriteLine("El resultado de multiplicar {0} con {1} es igual a {2}", number1, number2, resultMult);
                //if(number2 > 0)
                //{
                //    resultDiv = number1 / number2;
                //    resultMod = number1 % number2;
                //    Console.WriteLine("El resultado de dividir {0} entre {1} es igual a {2}", number1, number2, resultDiv);
                //    Console.WriteLine("El residuo de dividir {0} con {1} es igual a {2}", number1, number2, resultMod);
                //}
                //    Console.WriteLine("No es posible generar resultados dividiendo por 0");

                //if (number1 == number2)
                //    Console.WriteLine("El número {0} es igual al número {1}", number1, number2);
                //else if (number1 < number2)
                //    Console.WriteLine("El número {0} es menor al número {1}", number1, number2);
                //else 
                //    Console.WriteLine("El número {0} es mayor al número {1}", number1, number2);

                //if (number1 != number2)
                //    Console.WriteLine("El número {0} es diferente al número {1}", number1, number2);

                //if (number1 >= number2)
                //    Console.WriteLine("El número {0} es mayor igual al número {1}", number1, number2);

                //if (number1 <= number2)
                //    Console.WriteLine("El número {0} es menor o igual al número {1}", number1, number2);


                resultSuma = number1 + number2 + number3;
                resultPromedio = (number1 + number2 + number3) / 3;
                resultMultiplicacion = number1 * number2 * number3;

                Console.WriteLine("El resultado de sumar {0} con {1} y {2} es igual a {3}", number1, number2, number3, resultSuma);
                Console.WriteLine("El promedio de los números {0}, {1}, {2} es igual a {3}", number1, number2, number3, resultPromedio);
                Console.WriteLine("El resultado de multiplicar {0} con {1} y {2} es igual a {3}", number1, number2, number3, resultMultiplicacion);

                if (number1 > number2) { 
                    if (number1 > number3)
                        Console.WriteLine("El número mayor es el número {0}", number1);
                else if (number2 > number3)
                    if (number2 > number1)
                        Console.WriteLine("El número mayor es el número {0}", number2);
                }
                else
                        Console.WriteLine("El número mayor es el número {0}", number3);

                if (number1 < number2)
                {
                    if (number1 < number3)
                        Console.WriteLine("El número menor es el número {0}", number1);
                  else  if (number2 < number3)
                        if (number2 < number1)
                            Console.WriteLine("El número menor es el número {0}", number2);
                }
                else
                    Console.WriteLine("El número menor es el número {0}", number3);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
