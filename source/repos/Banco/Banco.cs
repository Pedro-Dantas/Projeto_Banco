using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        //private Conta contaPedro;
        //private Conta contaCristiano;
        private Conta[] contaTitulares;
        private Cliente[] clienteTitulares;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //contaPedro = new Conta() { Numero = 1,   };
            //Cliente clientePedro = new Cliente() { Nome = "Pedro", };

            //contaCristiano = new Conta() { Numero = 2, };
            //Cliente clienteCristiano = new Cliente() { Nome = "Cristiano", };

            contaTitulares = new Conta[2] { new Conta(){ Numero = 1, }, new Conta() { Numero = 2, }};

            clienteTitulares = new Cliente[2] { new Cliente(){ Nome = "Pedro" }, new Cliente(){ Nome = "Cristiano" } };


            /*textoTitular.Text = clientePedro.Nome;
            textoTitular.Text = clienteTitulares[0].Nome;
            textoNumero.Text = contaTitulares[0].Numero.ToString();
            textoSaldo.Text = contaTitulares[0].Saldo.ToString();*/      
        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {
            //o botão pega o valor da caixa de deposito e converte em double
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contaTitulares[0].Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(contaTitulares[0].Saldo);
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contaTitulares[0].Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(contaTitulares[0].Saldo);
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboContas.Items.Add(contaTitulares[0].Titular.Nome);
            comboContas.Items.Add(contaTitulares[1].Titular.Nome);

            /*Podemos recuperar	qual é o índice (começando de zero)	do item que	foi  selecionado pelo usuário lendo	a propriedade SelectedIndex do comboContas*/
            int indice = comboContas.SelectedIndex;

            /*Esse índice representa qual é	o elemento do array	de contas que foi selecionado, logo, podemos usálo	para recuperar a conta que	foi	escolhida*/
            Conta selecionada = contaTitulares[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        }
    } 
}

