using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIOBank
{
    public partial class F_Depositar : Form
    {
        public F_Depositar()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void txb_ValorDeposito_Click(object sender, EventArgs e)
        {
            txb_ValorDeposito.Clear();
        }

        private void bnt_Depositar_Click(object sender, EventArgs e)
        {
            Program.ListContas[int.Parse(textBox1.Text)].Depositar(int.Parse(txb_ValorDeposito.Text));
            txb_ValorDeposito.Text = "Digite o Valor a ser Depositado: ";
            textBox1.Text = "Digite o Número da Conta: ";
        }
    }
}
