using CaixaEletronico;
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
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            contas[0] = new Conta();
            contas[0].Titular = new Cliente();
            contas[0].Titular.Nome = "Ari Assis Silva";
            contas[0].Agencia = 0928;
            contas[0].DigitoConta = 7;
            contas[0].Nconta = 111999;

            contas[1] = new Conta();
            contas[1].Titular = new Cliente();
            contas[1].Titular.Nome = "Fabiano dos Santos Silva";
            contas[1].Agencia = 0277;
            contas[1].Nconta = 189344;
            contas[1].DigitoConta = 0;

            contas[2] = new Conta();
            contas[2].Titular = new Cliente();
            contas[2].Titular.Nome = "Liberata dos Santos Silva";
            contas[2].Agencia = 0928;
            contas[2].Nconta = 1010525;
            contas[2].DigitoConta = 0;

            foreach (Conta conta in contas)
            {
                comboTitular.Items.Add(conta.Titular.Nome);
            }
        }
        private void comboTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboTitular.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];
            textoNome.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            TextoNConta.Text = Convert.ToString(contaSelecionada.Agencia + " / " + contaSelecionada.Nconta + " - " + contaSelecionada.DigitoConta);
        }
        private void btDeposito_Click(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }
    }
}