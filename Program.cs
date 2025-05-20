using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double num1, num2, resultado;

            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora\n");
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicación");
                Console.WriteLine("4- División");
                Console.WriteLine("5- Elevar un número a la potencia");
                Console.WriteLine("6- Salir\n");
                Console.Write("Seleccione una opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
                {
                    Console.Write("Opción inválida. Intente de nuevo: ");
                }

                if (opcion == 6)
                {
                    Console.WriteLine("\nSaliendo de la calculadora...");
                    break;
                }

                // Ingreso de primer número
                Console.Write("\nIngrese el primer número: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Entrada inválida. Ingrese un número válido: ");
                }

                // Ingreso de segundo número (excepto para potencia)
                if (opcion != 5)
                {
                    Console.Write("Ingrese el segundo número: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.Write("Entrada inválida. Ingrese un número válido: ");
                    }
                }
                else
                {
                    Console.Write("Ingrese la potencia: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.Write("Entrada inválida. Ingrese un número válido: ");
                    }
                }

                // Operaciones
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: No se puede dividir entre cero.");
                        }
                        break;
                    case 5:
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"\nResultado: {num1} ^ {num2} = {resultado}");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 6);
        }
    }
    }
