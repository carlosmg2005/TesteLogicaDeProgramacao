using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuExercicios.ExibirMenu(); // Chama o menu que gerencia os exercícios
        }
    }

    public class MenuExercicios
    {
        public static void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha o exercício que deseja ver:");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                string? escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Exercicio1.Executar(); // Chama o método para o exercício 1
                        break;
                    case "2":
                        Exercicio2.Executar(); // Chama o método para o exercício 2
                        break;
                    case "3":
                        Exercicio3.Executar(); // Chama o método para o exercício 3
                        break;
                    case "4":
                        Exercicio4.Executar(); // Chama o método para o exercício 4
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de mostrar o menu novamente
            }
        }
    }
}