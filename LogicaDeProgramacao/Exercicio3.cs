using System;

namespace Exercicios
{
    public class Exercicio3
    {
        public static void Executar()
        {
            // Testes de Mesa - Exibindo todos os detalhes conforme solicitado
            Console.WriteLine("A) a = 1, b = 2, c = 3");
            Console.WriteLine("Primeira condição: a < b + c && b < a + c && c < a + b");
            Console.WriteLine("1 < 2 + 3 && 2 < 1 + 3 && 3 < 1 + 2");
            Console.WriteLine("1 < 5 && 2 < 4 && 3 < 3 (A condição falha, porque 3 não é menor que 3).");
            Console.WriteLine("Resultado: \"Não é possível formar um triângulo\".");
            Console.WriteLine();

            Console.WriteLine("B) a = 3, b = 4, c = 5");
            Console.WriteLine("Primeira condição: a < b + c && b < a + c && c < a + b");
            Console.WriteLine("3 < 4 + 5 && 4 < 3 + 5 && 5 < 3 + 4");
            Console.WriteLine("3 < 9 && 4 < 8 && 5 < 7 (Tudo verdadeiro).");
            Console.WriteLine("Segunda condição: a == b && b == c (Não é verdadeiro).");
            Console.WriteLine("Terceira condição: a == b || b == c || a == c (Não é verdadeiro).");
            Console.WriteLine("Resultado: \"Triângulo Escaleno\".");
            Console.WriteLine();

            Console.WriteLine("C) a = 2, b = 2, c = 4");
            Console.WriteLine("Primeira condição: a < b + c && b < a + c && c < a + b");
            Console.WriteLine("2 < 2 + 4 && 2 < 2 + 4 && 4 < 2 + 2");
            Console.WriteLine("2 < 6 && 2 < 6 && 4 < 4 (A condição falha, porque 4 não é menor que 4).");
            Console.WriteLine("Resultado: \"Não é possível formar um triângulo\".");
            Console.WriteLine();

            Console.WriteLine("D) a = 4, b = 4, c = 4");
            Console.WriteLine("Primeira condição: a < b + c && b < a + c && c < a + b");
            Console.WriteLine("4 < 4 + 4 && 4 < 4 + 4 && 4 < 4 + 4");
            Console.WriteLine("4 < 8 && 4 < 8 && 4 < 8 (Tudo verdadeiro).");
            Console.WriteLine("Segunda condição: a == b && b == c (Verdadeiro).");
            Console.WriteLine("Resultado: \"Triângulo Equilátero\".");
            Console.WriteLine();

            Console.WriteLine("E) a = 5, b = 3, c = 3");
            Console.WriteLine("Primeira condição: a < b + c && b < a + c && c < a + b");
            Console.WriteLine("5 < 3 + 3 && 3 < 5 + 3 && 3 < 5 + 3");
            Console.WriteLine("5 < 6 && 3 < 8 && 3 < 8 (Tudo verdadeiro).");
            Console.WriteLine("Segunda condição: a == b && b == c (Não é verdadeiro).");
            Console.WriteLine("Terceira condição: a == b || b == c || a == c (Verdadeiro, pois b == c).");
            Console.WriteLine("Resultado: \"Triângulo Isósceles\".");
            Console.WriteLine();

            // Resumo do Teste de Mesa
            Console.WriteLine("Resumo do Teste de Mesa");
            Console.WriteLine("Teste A: Não é possível formar um triângulo.");
            Console.WriteLine("Teste B: Triângulo Escaleno.");
            Console.WriteLine("Teste C: Não é possível formar um triângulo.");
            Console.WriteLine("Teste D: Triângulo Equilátero.");
            Console.WriteLine("Teste E: Triângulo Isósceles.");
        }
    }
}

/* 
            A) a = 1, b = 2, c = 3
            Primeira condição: a < b + c && b < a + c && c < a + b
            1 < 2 + 3 && 2 < 1 + 3 && 3 < 1 + 2
            1 < 5 && 2 < 4 && 3 < 3 (A condição falha, porque 3 não é menor que 3).
            Resultado: "Não é possível formar um triângulo".

            B) a = 3, b = 4, c = 5
            Primeira condição: a < b + c && b < a + c && c < a + b
            3 < 4 + 5 && 4 < 3 + 5 && 5 < 3 + 4
            3 < 9 && 4 < 8 && 5 < 7 (Tudo verdadeiro).
            Segunda condição: a == b && b == c (Não é verdadeiro).
            Terceira condição: a == b || b == c || a == c (Não é verdadeiro).
            Resultado: "Triângulo Escaleno".

            C) a = 2, b = 2, c = 4
            Primeira condição: a < b + c && b < a + c && c < a + b
            2 < 2 + 4 && 2 < 2 + 4 && 4 < 2 + 2
            2 < 6 && 2 < 6 && 4 < 4 (A condição falha, porque 4 não é menor que 4).
            Resultado: "Não é possível formar um triângulo".

            D) a = 4, b = 4, c = 4
            Primeira condição: a < b + c && b < a + c && c < a + b
            4 < 4 + 4 && 4 < 4 + 4 && 4 < 4 + 4
            4 < 8 && 4 < 8 && 4 < 8 (Tudo verdadeiro).
            Segunda condição: a == b && b == c (Verdadeiro).
            Resultado: "Triângulo Equilátero".

            E) a = 5, b = 3, c = 3
            Primeira condição: a < b + c && b < a + c && c < a + b
            5 < 3 + 3 && 3 < 5 + 3 && 3 < 5 + 3
            5 < 6 && 3 < 8 && 3 < 8 (Tudo verdadeiro).
            Segunda condição: a == b && b == c (Não é verdadeiro).
            Terceira condição: a == b || b == c || a == c (Verdadeiro, pois b == c).
            Resultado: "Triângulo Isósceles".

            Resumo do Teste de Mesa
            Teste A: Não é possível formar um triângulo.
            Teste B: Triângulo Escaleno.
            Teste C: Não é possível formar um triângulo.
            Teste D: Triângulo Equilátero.
            Teste E: Triângulo Isósceles.
            */