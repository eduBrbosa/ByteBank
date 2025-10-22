using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2026, 03, 14);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;


            string msg = $"Vencimento em {GetIntevaloDeTempoLegivel(diferenca)}";

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(msg);

            Console.ReadLine();
        }


        static string GetIntevaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                return quantidadeMeses + " mês(es)";
            }

            return timeSpan.Days + " dias";
        }
    }
}
