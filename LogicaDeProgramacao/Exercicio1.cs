namespace Exercicios
{
    public class Exercicio1
    {
        public static void Executar()
        {
            int totalCarrosAte2000 = 0;
            int totalCarros = 0;

            while (true)
            {
                Console.WriteLine("Informe o preço do carro (ou 0 para sair): ");

                // TryParse para evitar exceções em entradas inválidas
                if (!double.TryParse(Console.ReadLine(), out double preco))
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                    continue; // Pula para o próximo ciclo se a entrada for inválida
                }

                if (preco == 0) break; // Finaliza o loop se o preço for 0

                Console.WriteLine("Informe o ano do carro: ");

                // Valida para garantir que o ano também seja válido
                if (!int.TryParse(Console.ReadLine(), out int ano))
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                    continue;
                }

                // Calcula o desconto com base no ano
                double desconto = ano <= 2000 ? 0.12 : 0.07;
                double valorDesconto = preco * desconto;
                double valorFinal = preco - valorDesconto;

                // Exibe os resultados ao usuário
                Console.WriteLine($"Valor do desconto: {valorDesconto:C}");
                Console.WriteLine($"Valor a ser pago: {valorFinal:C}");

                // Atualiza os contadores
                if (ano <= 2000) totalCarrosAte2000++;
                totalCarros++;
            }

            // Totais
            Console.WriteLine($"\nTotal de carros até 2000: {totalCarrosAte2000}");
            Console.WriteLine($"Total de carros no geral: {totalCarros}");
        }
    }
}
