using projetoFormAlura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    class Conta
    {
        public int nAgencia;
        public int nConta;
        public int digitoConta; 
        public double saldo;
        public String titular;
        public Cliente cliente = new Cliente();        

        public void Saque(double valor)
        {
            if (valor <= this.saldo && valor > 0)
            {
                this.saldo -= valor;
            }
            else
            {
                MessageBox.Show("O Valor a ser sacado é Invalido! O valordo saue Não pode ser menor ou igual 0!");
            }
        }

        public void Deposito(double valor)
        {
            if(valor > 0) {
                this.saldo += valor;
            }else
            {
                MessageBox.Show("O Valor a ser depositado é Invalido! O valor Não pode ser menor que 0!");
            }
        }

        public void Transferencia(double valor, Conta contaDestino)
        {
            this.Saque(valor);
            contaDestino.Deposito(valor);

        }


        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }

    }



}
