using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using GestaoEstacionamento;
using GestaoEstacionamento.classes;
using GestaoEstacionamento.classes.Pagamento;

class Program {
    static void Main() {
        
        Veiculo? veiculo = null;
        IPagamento? pagamento = null;
        
        start:
        Console.WriteLine("---- Estacionamento ----");
        Console.WriteLine("Opções: ");
        Console.WriteLine("[1] Registrar um Carro.");
        Console.WriteLine("[2] Registrar uma Moto.");
        Console.WriteLine();
        
        int escolha = Convert.ToInt16(Console.ReadLine());
        if (escolha != 1 && escolha != 2)
        {
            Console.WriteLine("Erro. Veiculo Inválido.");
            goto start;
        }
        Console.Write("PLACA: ");
        string placa = (Console.ReadLine() ?? "Desconhecido").Trim();
        Console.Write("MARCA: ");
        string marca = (Console.ReadLine() ?? "Desconhecido").Trim();
        Console.Write("MODELO: ");
        string modelo = (Console.ReadLine() ?? "Desconhecido").Trim();
        
        switch (escolha)
        {
            case 1:
                veiculo = new Carro(placa, marca, modelo);
                break;
            case 2:
                veiculo = new Moto(placa, marca, modelo);
                break;
            default:
                break;
        }
        if (veiculo == null)
        {
            return;
        }
        Console.Clear();
        Console.WriteLine("Quantidade de horas que o Veículo permaneceu: ");
        int horasEst = int.Parse(Console.ReadLine() ?? "0");
        veiculo.CalcularValor(horasEst);
        decimal valorTotal = veiculo.ValorTotal;
        veiculo.MostrarSituacao();
        Console.WriteLine();
        
        pgto:
        Console.WriteLine("--- PAGAMENTO ---");
        Console.WriteLine("[1] Cartão de Crédito ou Débito (taxa de 2%)");
        Console.WriteLine("[2] PIX");
        Console.WriteLine("[3] Dinheiro");
        Console.WriteLine();
        string? opcaoPgto = (Console.ReadLine() ?? "0").Trim();
        switch (opcaoPgto)
        {
            case "1":
                pagamento = new PagamentoCc();
                break;
            case "2":
                pagamento = new PagamentoPix();
                break;
            case "3":
                pagamento = new PagamentoDinheiro();
                break;
            default:
                Console.WriteLine("Metódo Inválido. Tente novamente\n");
                break;
        } 
        if (pagamento == null)
        {
            goto pgto;
        }
        pagamento.Pagar(valorTotal);

        Console.WriteLine("Fim do Programa. Para sair digite qualquer tecla...");
        Console.ReadKey();
    }
}