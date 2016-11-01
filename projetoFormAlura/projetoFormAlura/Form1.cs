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

namespace CaixaEletronico
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
                

            novaC.cliente.nome = "Fabiano dos Santos Silva";
            novaC.titular = novaC.cliente.nome;
            novaC.nAgencia = 0277;
            novaC.nConta = 189344;
            novaC.digitoConta = 0;
            novaC.cliente.numeroCPF = "266.502.208-76";
            novaC.saldo = 100000000000999.99;

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Nome Titular: "+ novaC.titular+"\n Agencia: "+novaC.nAgencia+"\n C/c: "+novaC.nConta+" - "+novaC.digitoConta
                + "\n CPF: " + novaC.cliente.numeroCPF + "\n\n\n Saldo: " +novaC.saldo);

            Conta novaC2 = new Conta();
            novaC2.cliente.nome = "4k";
            novaC2.titular = novaC2.cliente.nome;
            novaC2.nAgencia = 0277;
            novaC2.nConta = 189311;
            novaC2.digitoConta = 0;
            novaC2.cliente.numeroCPF = "266.502.208-76";
            novaC2.saldo = 5000.99;

            Conta copia = novaC2;
            copia.saldo = 11;

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Nome Titular: " + novaC2.titular + "\n Agencia: " + novaC2.nAgencia + "\n C/c: " + novaC2.nConta + " - " + novaC2.digitoConta
                + "\n CPF: "+novaC2.cliente.numeroCPF + "\n\n\n Saldo: " + novaC2.saldo +"\n Copia: "+copia.saldo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta easyinvest = new Conta();
            Conta fabianoDayco = new Conta();
            Conta bradesco = new Conta();

            easyinvest.saldo = 500047.75;

            MessageBox.Show("Saldo da conta do Fabiano na EasyInvest: R$" + easyinvest.saldo + "\nSerá Transferido hoje para o Fabiano no Banco Daycoval o valor de R$ 10.000,00 \n");


            fabianoDayco.saldo = 29.77;            
            fabianoDayco.cliente.nome = "Fabiano dos Santos Silva";
            fabianoDayco.titular = fabianoDayco.cliente.nome;            
            fabianoDayco.nAgencia = 001;
            fabianoDayco.nConta = 0005272248;
            fabianoDayco.digitoConta = 5;
            fabianoDayco.cliente.numeroCPF = "266.502.208-76";
            

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Banco DayCoval \n Nome Titular: " + fabianoDayco.titular + "\n Agencia: " + fabianoDayco.nAgencia + "\n C/c: " + fabianoDayco.nConta + " - " + fabianoDayco.digitoConta
               + "\n CPF: " + fabianoDayco.cliente.numeroCPF + "\n\n\n Saldo: " + fabianoDayco.saldo);

            easyinvest.Transferencia(10000.00, fabianoDayco);
            MessageBox.Show("Saldo atual da conta do Fabiano na EasyInvest: R$" + easyinvest.saldo + "\nSaldo atual da conta do Fabiano no DayCoval: R$"+ fabianoDayco.saldo);

            bradesco.cliente.nome = "Fabiano dos Santos Silva";
            bradesco.titular = bradesco.cliente.nome;
            bradesco.nAgencia = 0277;
            bradesco.nConta = 189344;
            bradesco.digitoConta = 0;
            bradesco.cliente.numeroCPF = "266.502.208-76";
            bradesco.saldo = 147.50;

            MessageBox.Show("++++++++++Conta Corrente+++++++++ \n\n\n Banco Bradesco \n Nome Titular: " + bradesco.titular + "\n Agencia: " + bradesco.nAgencia + "\n C/c: " + bradesco.nConta + " - " + bradesco.digitoConta
                + "\n CPF: " + bradesco.cliente.numeroCPF + "\n\n\n Saldo: " + bradesco.saldo);

            MessageBox.Show("Transferencia 5 mil R$ do Banco Daycoval conta Fabiano para conta do Fabiano no Bradesco");
            fabianoDayco.Transferencia(5070.01,bradesco);

            MessageBox.Show("++++++++ Valores Atualizado 2016 ++++++++ \n EasyInvest: R$"+easyinvest.saldo+"\n Fabiano Daycoval: R$"+fabianoDayco.saldo+
                "\n Fabiano Bradesco: R$"+bradesco.saldo);


            MessageBox.Show("Saque de R$100,00 da conta Bradesco Fabiano");
            bradesco.Saque(100.00);
            MessageBox.Show("+++++++++ Valores Atualizado 2016 +++++++++ \n EasyInvest: R$" + easyinvest.saldo + "\n Fabiano Daycoval: R$" + fabianoDayco.saldo +
                "\n Fabiano Bradesco: R$" + bradesco.saldo);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta fabiano = new Conta();
            fabiano.saldo = 1000.00;
            double rend = fabiano.CalculaRendimentoAnual();

            MessageBox.Show("O rendimento Anual da Conta do Fabiano é de: "+rend);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            bool soudemaior = false;

            cli.idade = 18;
            cli.nome = "Fabiana";

            soudemaior = cli.EhMaiorDeIdade();
            if (soudemaior == true)
            {
                MessageBox.Show("Meu nome é: " + cli.nome + " e Minha idade é: " + cli.idade+ " E eu sou " + soudemaior + " maior de Idade!");
            }else
            {
                MessageBox.Show("Meu nome é: " + cli.nome + " e Minha idade é: " + cli.idade+ " E eu não sou maior de Idade! "+ soudemaior);
            }
        }
    }
}
