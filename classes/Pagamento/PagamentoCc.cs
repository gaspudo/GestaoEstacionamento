using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstacionamento.classes.Pagamento
{
    public class PagamentoCc : IPagamento
    {
        public void Pagar(decimal valor)
        {
            decimal valorComTaxa = valor * 1.02m ;
            Console.WriteLine($"SUBTOTAL:\t{valor:c}");
            Console.WriteLine($"TOTAL:\t\t{valorComTaxa:c}");
        }
    }
}