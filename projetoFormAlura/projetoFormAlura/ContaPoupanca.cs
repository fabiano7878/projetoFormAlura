using projetoFormAlura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormAlura
{
    class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
