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
        public int Agencia { get; set; }
        public int Nconta { get; set; }
        public int DigitoConta { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public virtual void Saque(double valor)
        {
            if (valor <= this.Saldo && valor > 0)
            {
                this.Saldo -= valor;
            }
            else
            {
                MessageBox.Show("O Valor a ser sacado é Invalido! O valor do saque Não pode ser menor ou igual 0!");
            }
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
            else
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
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }

    }



}
