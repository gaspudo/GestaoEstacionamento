using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstacionamento
{
    public interface IPagamento
    {
        void Pagar(decimal valor);
    }
}