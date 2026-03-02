using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstacionamento.classes
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            string chave = Guid.NewGuid().ToString();
            Console.WriteLine($"TOTAL:\t\t{valor:c}\nCHAVE PIX:\t{chave}");
        }
    }
}