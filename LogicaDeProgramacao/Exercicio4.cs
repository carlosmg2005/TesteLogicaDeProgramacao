using System;
using PublicHoliday;

namespace Exercicios
{
    public class Exercicio4
    {
        public static void Executar()
        {
            DateTime vencimentoOriginal;
            DateTime vencimentoNovo;
            double valorBoleto;

            while (true)
            {
                // Solicita a data de vencimento original
                Console.Write("Digite a data de vencimento original (dd/MM/yyyy): ");
                string? entradaVencimentoOriginal = Console.ReadLine();

                if (string.IsNullOrEmpty(entradaVencimentoOriginal))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                // Verifica se a entrada pode ser convertida para DateTime
                if (!DateTime.TryParseExact(entradaVencimentoOriginal, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out vencimentoOriginal))
                {
                    Console.WriteLine("Formato de data inválido. Tente novamente.");
                    continue;
                }

                // Solicita a data de vencimento nova
                Console.Write("Digite a data de vencimento nova (dd/MM/yyyy): ");
                string? entradaVencimentoNovo = Console.ReadLine();

                if (string.IsNullOrEmpty(entradaVencimentoNovo))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                // Verifica se a entrada pode ser convertida para DateTime
                if (!DateTime.TryParseExact(entradaVencimentoNovo, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out vencimentoNovo))
                {
                    Console.WriteLine("Formato de data inválido. Tente novamente.");
                    continue;
                }

                // Solicita o valor do boleto
                Console.Write("Digite o valor do boleto: ");
                string? entradaValorBoleto = Console.ReadLine();

                if (string.IsNullOrEmpty(entradaValorBoleto) || !double.TryParse(entradaValorBoleto, out valorBoleto))
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    continue;
                }

                // Função que calcula o valor do boleto recalculado e o valor dos juros e multa
                var resultado = CalcularJurosEMulta(vencimentoOriginal, vencimentoNovo, valorBoleto);
                Console.WriteLine($"Valor do Boleto Recalculado: R${resultado.Item1:F2}");
                Console.WriteLine($"Valor Total Juros: R${resultado.Item2:F2}");
                Console.WriteLine($"Valor Total Multa: R${resultado.Item3:F2}");

                Console.WriteLine(); // Adiciona uma linha em branco para separar os cálculos

                // Pergunta se deseja calcular outro boleto
                Console.Write("Deseja calcular outro boleto? (s/n): ");
                string? continuar = Console.ReadLine()?.ToLower();

                if (continuar != "s")
                {
                    break;
                }
            }

            Console.WriteLine("Encerramento do exercício.");
        }

        public static Tuple<double, double, double> CalcularJurosEMulta(DateTime vencimentoOriginal, DateTime vencimentoNovo, double valorBoleto)
        {
            double jurosDiarios = 0.03; // Valor dos juros por dia
            double multa = 2.00; // Valor fixo da multa
            double jurosTotais = 0.00;
            double valorTotalBoleto = valorBoleto;

            // Cria uma instância de BrazilPublicHoliday
            BrazilPublicHoliday publicHoliday = new BrazilPublicHoliday();

            // Verifica se a data de vencimento original é um feriado ou final de semana
            bool vencimentoFeriado = publicHoliday.IsPublicHoliday(vencimentoOriginal); // Passa o DateTime diretamente
            bool vencimentoFinalSemana = (vencimentoOriginal.DayOfWeek == DayOfWeek.Saturday || vencimentoOriginal.DayOfWeek == DayOfWeek.Sunday);

            // Regra 6: Se a data de pagamento for o mesmo dia da data de vencimento, não deve cobrar juros nem multa
            if (vencimentoOriginal.Date == vencimentoNovo.Date)
            {
                return Tuple.Create(valorBoleto, 0.0, 0.0);
            }

            // Regra 7: Se a data de pagamento for anterior à data de vencimento, não cobra juros nem multa
            if (vencimentoNovo.Date < vencimentoOriginal.Date)
            {
                return Tuple.Create(valorBoleto, 0.0, 0.0);
            }

            // Regra 1 e 2: Se a data de vencimento for feriado ou final de semana
            if ((vencimentoFeriado || vencimentoFinalSemana) && vencimentoNovo.Date > vencimentoOriginal.Date)
            {
                int diasDeAtraso = (vencimentoNovo - vencimentoOriginal).Days;

                // Se for no dia útil seguinte, não cobra juros nem multa
                if (diasDeAtraso == 1)
                {
                    return Tuple.Create(valorBoleto, 0.0, 0.0);
                }

                // Caso contrário, cobra juros e multa
                jurosTotais = diasDeAtraso * jurosDiarios;
                valorTotalBoleto = valorBoleto + jurosTotais + multa;
                return Tuple.Create(valorTotalBoleto, jurosTotais, multa);
            }

            // Regra 8: Se o vencimento for dia útil e pagamento no dia útil seguinte
            if (vencimentoOriginal.Date.AddDays(1) == vencimentoNovo.Date)
            {
                jurosTotais = jurosDiarios;
                valorTotalBoleto = valorBoleto + jurosTotais + multa;
                return Tuple.Create(valorTotalBoleto, jurosTotais, multa);
            }

            // Caso geral: cobra juros e multa de todo o período
            int diasDeAtrasoTotal = (vencimentoNovo - vencimentoOriginal).Days;
            jurosTotais = diasDeAtrasoTotal * jurosDiarios;
            valorTotalBoleto = valorBoleto + jurosTotais + multa;
            return Tuple.Create(valorTotalBoleto, jurosTotais, multa);
        }
    }
}