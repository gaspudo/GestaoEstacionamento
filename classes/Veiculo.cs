using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GestaoEstacionamento;

namespace GestaoEstacionamento
{
    public abstract class Veiculo
    {
        public string Placa {get; }
        public string Marca {get; }
        public string Modelo {get; }

        public Veiculo (string placa, string marca, string modelo)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }

        protected abstract int ValorHoraAdd {get;}
        protected abstract int ValorInicial {get;}

        public decimal ValorTotal {get; protected set ;}
        public void CalcularValor (int horas) {
             ValorTotal = ValorInicial + (Math.Max(0, horas - 1) * ValorHoraAdd);
        }

        public void MostrarSituacao()
        {
            Console.WriteLine($"Placa:\t{Placa} \nMarca:\t{Marca} \nModelo:\t{Modelo} \nValor a pagar:\t{ValorTotal:c} ");
        } 

    }
}