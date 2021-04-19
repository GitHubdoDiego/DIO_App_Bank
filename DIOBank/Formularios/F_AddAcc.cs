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
    public partial class F_AddAcc : Form
    {
        int entradaTipoConta = 0;
        public F_AddAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_PF.Checked == false && cb_PJ.Checked == false)
            {
                entradaTipoConta = 0;
            }
            string entradaNome = txt_Nome.Text;
            double entradaSaldo = double.Parse(txt_Saldo.Text);
            double entradaCredito = double.Parse(txt_Credito.Text);

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);
            Program.ListContas.Add(novaConta);

            cb_PF.Checked = cb_PJ.Checked = false;
            txt_Nome.Text = "Digite o Nome do Cliente: ";
            txt_Saldo.Text = "Digite o Saldo Inicial: "; 
            txt_Credito.Text = "Digite o Credito: ";
        }

        private void cb_PF_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PF.Checked)
            {
                entradaTipoConta = 1;
                cb_PJ.Checked = false;
            }
        }

        private void cb_PJ_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PJ.Checked)
            {
                entradaTipoConta = 2;
                cb_PF.Checked = false;
            }
        }

        private void txt_Nome_Click(object sender, EventArgs e)
        {
            txt_Nome.Clear();
        }

        private void txt_Saldo_Click(object sender, EventArgs e)
        {
            txt_Saldo.Clear();
        }

        private void txt_Credito_Click(object sender, EventArgs e)
        {
            txt_Credito.Clear();
        }
    }
}
