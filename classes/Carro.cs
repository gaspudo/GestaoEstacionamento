using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstacionamento
{
    public class Carro : Veiculo
    {
        public Carro(string placa, string marca, string modelo) : base(placa, marca, modelo) {}

        protected override int ValorHoraAdd => 3;
        protected override int ValorInicial => 12;
    }
}