using System.ComponentModel;
using System.Drawing;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            double resultadoNovo = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("- Calculadora 2023 - \n");

                Console.WriteLine("==== Operações matemática ====");
                Console.WriteLine("1- Adição \n2- Subtração \n3- Divisão \n4- Multiplicação \n5- Sair");
                Console.Write("\nInforme a opção desejada => ");
                opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Informe o primeiro número: ");
                        double numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double numero2 = double.Parse(Console.ReadLine());
                        
                        double resultado = numero1 + numero2;

                        resultadoNovo = Math.Round(resultado, 2);

                        Console.WriteLine($"\nO resultado é: {resultadoNovo}");

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Informe o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        resultado = numero1 - numero2;

                        resultadoNovo = Math.Round(resultado, 2);

                        Console.WriteLine($"\nO resultado é: {resultadoNovo}");

                        Console.WriteLine("\nPressione qualquer tecla para continuar..."); 
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Informe o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        if (numero1 == 0 || numero2 == 0)
                        {
                            Console.WriteLine("\nNão pode utilizar o número 0 na divisão! Tente novamente.");
                            Console.ReadKey();
                        }
                        else
                        {
                            resultado = numero1 / numero2;

                            resultadoNovo = Math.Round(resultado, 2);

                            Console.WriteLine($"\nO resultado é: {resultadoNovo}");

                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Informe o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        resultado = numero1 * numero2;

                        resultadoNovo = Math.Round(resultado, 2);

                        Console.WriteLine($"\nO resultado é: {resultadoNovo}");

                        Console.WriteLine("\nPressione qualquer tecla para continuar..."); 
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("\nSaindo da calculadora...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Clique qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}