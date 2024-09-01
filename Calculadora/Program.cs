using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção inválida.");
                    break;

                case '+':
                    resultado = n1 + n2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case '-':
                    resultado = n1 - n2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case 'x':
                case 'X':
                    resultado = n1 * n2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                case '/':
                case ':':

                    if (n2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0");
                    }
                    else
                    {
                        resultado = n1 / n2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;
            }

            Console.Write("Quer continuar calculando (s / n) ?");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                goto Inicio;
            }

            else
            {
                Console.WriteLine("Fim do cálculo.");
            }

            Console.ReadKey();
        }
    }
}
