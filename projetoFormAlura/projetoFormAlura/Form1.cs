using projetoFormAlura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFormAlura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botão Musica
        private void button1_Click(object sender, EventArgs e)
        {


            String artist = "Jhon Mayer";
            String musica = "Assasin";

            MessageBox.Show("Play Now: "+artist + " - "+musica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Conta conta = new ContaCorrente();

            conta.Titular = new Cliente("Fabiano dos Santos Silva");
            conta.Agencia = 0277;
            conta.Nconta = 189344;
            conta.DigitoConta = 0;
            conta.Titular.NumeroCPF = "266.502.208-76";
            conta.Titular.Idade = 37;
            conta.Titular.Endereco = "Rua Ataulfo Alves";
            conta.Deposito(100000000000999.99);


            textoTitular.Text = conta.Titular.Nome;
            textoCPF.Text = conta.Titular.NumeroCPF;
            textoAgencia.Text = Convert.ToString(conta.Agencia);
            textoNConta.Text = Convert.ToString(conta.Nconta)+"-"+ Convert.ToString(conta.DigitoConta);
            textoSaldoAtualCC.Text = Convert.ToString(conta.Saldo);
            textoIdade.Text = Convert.ToString(conta.Titular.Idade);
            textoEndereco.Text = conta.Titular.Endereco;

            Conta poup = new ContaPoupanca();
            poup.Deposito(7500.00);
            
            textoSaldoAtualPoup.Text = Convert.ToString(poup.Saldo);
            

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(conta);
            t.Adiciona(poup);
            

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal);
        }
        //Botão calc
       private void button2_Click(object sender, EventArgs e)
        {
            
            int x = 3;
            int y = 4;
            int c = 15;
                                             
            if (c % x == 0)
            {
              MessageBox.Show(c+" é divisivel por " + x + " e não por " + y);
            }else if(c % y == 0)
            {
              MessageBox.Show(c+" é divisivel por " + y + " e não por " + x);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int result1 = 0;
            int result2 = 0;
            String result1Texto = "";
            String result2Texto = "";

            for (int i =0; i < 30; i++)
            {
                result1 = i % 3;
                result2 = i % 4;
                if (result1 == 0)
                {
                    result1Texto = result1Texto + i + ",";
                }else if(result2 == 0) {
                    result2Texto = result2Texto + i + ",";
                }
                
            }
            MessageBox.Show("Os numeros divisiveis por 3 são: " + result1Texto + "\n E os numeros divisiveis por 4 são: " + result2Texto);
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            int result = 0;
            int y = 100;
            int total = 0; 

            String result1Texto = "";

            for (int i = 1; i < y; i++)
            {

                result = i % 3;

                if (result == 0)
                {
                    result1Texto = result1Texto + i+",";
                    total = total + i;
                }
            }

            MessageBox.Show("Numeros multiplos de 3: "+ result1Texto + "\n e a soma de todos esses multiplos é: "+ total);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Conta novaC = new Conta();
            novaC.Titular = new Cliente();

            novaC.Titular.Nome = "Fabiano dos Santos Silva";
            novaC.Agencia = 0277;
            novaC.Nconta = 189344;
            novaC.DigitoConta = 0;
            novaC.Titular.NumeroCPF = "266.502.208-76";
            novaC.Deposito(100000000000999.99);

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Nome Titular: "+ novaC.Titular.Nome +"\n Agencia: "+novaC.Agencia + "\n C/c: "+novaC.Nconta + " - "+novaC.DigitoConta
                + "\n CPF: " + novaC.Titular.NumeroCPF + "\n\n\n Saldo: " +novaC.Saldo);

            Conta novaC2 = new Conta();
            novaC2.Titular = new Cliente();

            novaC2.Titular.Nome = "4k";
            novaC2.Agencia = 0277;
            novaC2.Nconta = 189311;
            novaC2.DigitoConta = 0;
            novaC2.Titular.NumeroCPF = "266.502.208-76";
            novaC2.Deposito(5000.99);

            Conta copia = novaC2;
            copia.Deposito(11);

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Nome Titular: " + novaC2.Titular.Nome + "\n Agencia: " + novaC2.Agencia + "\n C/c: " + novaC2.Nconta + " - " + novaC2.DigitoConta
                + "\n CPF: "+novaC2.Titular.NumeroCPF + "\n\n\n Saldo: " + novaC2.Saldo +"\n Copia: "+copia.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(novaC);
            t.Adiciona(novaC2);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta easyinvest = new Conta();
            Conta fabianoDayco = new Conta();
            Conta bradesco = new Conta();

            bradesco.Titular = new Cliente();
            fabianoDayco.Titular = new Cliente();
            easyinvest.Titular = new Cliente();


            easyinvest.Deposito(500047.75);

            MessageBox.Show("Saldo da conta do Fabiano na EasyInvest: R$" + easyinvest.Saldo + "\nSerá Transferido hoje para o Fabiano no Banco Daycoval o valor de R$ 10.000,00 \n");


            fabianoDayco.Deposito(29.77);            
            fabianoDayco.Titular.Nome = "Fabiano dos Santos Silva";           
            fabianoDayco.Agencia = 001;
            fabianoDayco.Nconta = 0005272248;
            fabianoDayco.DigitoConta = 5;
            fabianoDayco.Titular.NumeroCPF = "266.502.208-76";
            

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Banco DayCoval \n Nome Titular: " + fabianoDayco.Titular.Nome + "\n Agencia: " + fabianoDayco.Agencia + "\n C/c: " + fabianoDayco.Nconta + " - " + fabianoDayco.DigitoConta
               + "\n CPF: " + fabianoDayco.Titular.NumeroCPF + "\n\n\n Saldo: " + fabianoDayco.Saldo);

            easyinvest.Transferencia(10000.00, fabianoDayco);
            MessageBox.Show("Saldo atual da conta do Fabiano na EasyInvest: R$" + easyinvest.Saldo + "\nSaldo atual da conta do Fabiano no DayCoval: R$"+ fabianoDayco.Saldo);

            bradesco.Titular.Nome = "Fabiano dos Santos Silva";
            bradesco.Agencia = 0277;
            bradesco.Nconta = 189344;
            bradesco.DigitoConta = 0;
            bradesco.Titular.NumeroCPF = "266.502.208-76";
            bradesco.Deposito(147.50);

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Banco Bradesco \n Nome Titular: " + bradesco.Titular.Nome + "\n Agencia: " + bradesco.Agencia + "\n C/c: " + bradesco.Nconta + " - " + bradesco.DigitoConta
                + "\n CPF: " + bradesco.Titular.NumeroCPF + "\n\n\n Saldo: " + bradesco.Saldo);

            MessageBox.Show("Transferencia 5 mil R$ do Banco Daycoval conta Fabiano para conta do Fabiano no Bradesco");
            fabianoDayco.Transferencia(5070.01,bradesco);

            MessageBox.Show("++++++++ Valores Atualizado 2016 ++++++++ \n EasyInvest: R$"+easyinvest.Saldo+"\n Fabiano Daycoval: R$"+fabianoDayco.Saldo+
                "\n Fabiano Bradesco: R$"+bradesco.Saldo);


            MessageBox.Show("Saque de R$100,00 da conta Bradesco Fabiano");
            bradesco.Saque(100.00);
            MessageBox.Show("+++++++++ Valores Atualizado 2016 +++++++++ \n EasyInvest: R$" + easyinvest.Saldo + "\n Fabiano Daycoval: R$" + fabianoDayco.Saldo +
                "\n Fabiano Bradesco: R$" + bradesco.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(bradesco);
            t.Adiciona(easyinvest);
            t.Adiciona(fabianoDayco);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta fabiano = new Conta();
            fabiano.Deposito(1000.00);
            double rend = fabiano.CalculaRendimentoAnual();

            MessageBox.Show("O rendimento Anual da Conta do Fabiano é de: "+rend);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente("Fabiana");
            bool soudemaior = false;

            Conta conta = new Conta() { Nconta = 123 };

            cli.Idade = 18;   

            soudemaior = cli.EhMaiorDeIdade;
            if (soudemaior == true)
            {
                MessageBox.Show("Meu nome é: " + cli.Nome + " e Minha idade é: " + cli.Idade+ " E eu sou " + soudemaior + " maior de Idade! Numero da Conta: "+conta.Nconta);
            }else
            {
                MessageBox.Show("Meu nome é: " + cli.Nome + " e Minha idade é: " + cli.Idade+ " E eu não sou maior de Idade! "+ soudemaior+" Numero da Conta: "+conta.Nconta);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaCorrente();            
            conta.Deposito(Convert.ToDouble(textoSaldoAtualCC.Text) + Convert.ToDouble(textoValorCC.Text));
            textoSaldoAtualCC.Text = Convert.ToString(conta.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(conta);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal + Convert.ToDouble(textoValorTotalContas.Text));
        }

        private void Saque_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaCorrente();
            conta.Deposito(Convert.ToDouble(textoSaldoAtualCC.Text));
            conta.Saque(Convert.ToDouble(textoValorCC.Text));
            textoSaldoAtualCC.Text = Convert.ToString(conta.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(conta);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal + Convert.ToDouble(textoValorTotalContas.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ContaPoupanca poup = new ContaPoupanca();            
            poup.Deposito(Convert.ToDouble(textoSaldoAtualPoup.Text));
            textoSaldoAtualPoup.Text = Convert.ToString(poup.Saldo);
            poup.Saque(Convert.ToDouble(textoValorPoup.Text));
            textoSaldoAtualPoup.Text = Convert.ToString(poup.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(poup);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal + Convert.ToDouble(textoValorTotalContas.Text));
        }

        private void depositopoup_Click(object sender, EventArgs e)
        {

            ContaPoupanca poup = new ContaPoupanca();            
            poup.Deposito(Convert.ToDouble(textoSaldoAtualPoup.Text) + Convert.ToDouble(textoValorPoup.Text));
            textoSaldoAtualPoup.Text = Convert.ToString(poup.Saldo);

            TotalizadorDeContas t = new TotalizadorDeContas();            
            t.Adiciona(poup);

            textoValorTotalContas.Text = Convert.ToString(t.saldoTotal + Convert.ToDouble(textoValorTotalContas.Text));
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string[] nomes = new string[] { "mauricio", "mario", "victor", "william", "guilherme" };
            string concatenacao = "";
            foreach (string nome in nomes)
            {
                concatenacao += nome;
            }
            MessageBox.Show(concatenacao);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Conta[] banco = new Conta[3];
            for (int i = 0; i < 3; i++)
            {
                banco[i] = new Conta();
                banco[i].Nconta = (i + 1) * 100;
                Console.WriteLine(banco[i].Nconta);
            }
        }
    }
}
