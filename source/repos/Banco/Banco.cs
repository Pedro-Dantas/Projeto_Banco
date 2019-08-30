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
        private Conta contaPedro;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contaPedro = new Conta() {

                Numero = 1,

            };
           

            Cliente clientePedro = new Cliente()
            {
                Nome = "Pedro",
                

            };

            textoTitular.Text = clientePedro.Nome;
            textoNumero.Text = contaPedro.Numero.ToString();
            textoSaldo.Text = contaPedro.Saldo.ToString();
            
        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {
            //o botão pega o valor da caixa de deposito e converte em double
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contaPedro.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(contaPedro.Saldo);
 
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contaPedro.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(contaPedro.Saldo);
            
        }

    }
}
