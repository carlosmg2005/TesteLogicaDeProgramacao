using System;

namespace Exercicios
{
    public class Exercicio2
    {
        public static void Executar()
        {
            int codigoAluno;
            double nota1, nota2, nota3, media;

            while (true)
            {
                // Solicita o código do aluno
                Console.Write("Digite o código do aluno (ou 0 para encerrar): ");
                string? entradaCodigo = Console.ReadLine();

                if (string.IsNullOrEmpty(entradaCodigo))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                codigoAluno = int.Parse(entradaCodigo);

                if (codigoAluno == 0)
                    break;

                // Solicita as notas do aluno
                Console.Write("Digite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite a terceira nota: ");
                nota3 = double.Parse(Console.ReadLine() ?? "0");

                // Calcula a média ponderada
                double maiorNota = Math.Max(nota1, Math.Max(nota2, nota3));
                double somaOutrasNotas = (nota1 + nota2 + nota3) - maiorNota;
                media = (maiorNota * 4 + somaOutrasNotas * 3) / 10;

                // Exibe as informações do aluno
                Console.WriteLine($"Código do aluno: {codigoAluno}");
                Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
                Console.WriteLine($"Média: {media:F2}");

                // Verifica a situação do aluno
                if (media >= 6)
                    Console.WriteLine("APROVADO");
                else
                    Console.WriteLine("REPROVADO");

                Console.WriteLine(); // Adiciona uma linha em branco para separar os alunos
            }

            Console.WriteLine("Encerramento do exercício.");
        }
    }
}