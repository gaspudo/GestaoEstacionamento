using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstacionamento.classes.Pagamento
{
    public class PagamentoDinheiro : IPagamento
    {
        public void Pagar(decimal valor)
        {
            decimal acumulado = 0;
            Console.WriteLine($"TOTAL:\t{valor:c}");
            while (acumulado < valor) 
            {
                decimal falta = valor - acumulado;
                Console.Write($"Faltam: {falta:C}. Digite quanto vai entregar: ");
                
                
                decimal entrega; 
                bool sucesso = decimal.TryParse(Console.ReadLine(), out entrega); 
                
                acumulado += entrega;
            }

            if (acumulado > valor) 
            {
                decimal troco = acumulado - valor;
                Console.WriteLine($"TROCO:\t{troco:C}");
            }

        Console.WriteLine("Pagamento concluído com sucesso!");
        }
    }
}