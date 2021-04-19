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
    public partial class F_Transferir : Form
    {
        public F_Transferir()
        {
            InitializeComponent();
        }

        private void txb_NumCntOrigem_Click(object sender, EventArgs e)
        {
            txb_NumCntOrigem.Clear();
        }

        private void txb_NumCntDestino_Click(object sender, EventArgs e)
        {
            txb_NumCntDestino.Clear();
        }

        private void txb_ValorTrans_Click(object sender, EventArgs e)
        {
            txb_ValorTrans.Clear();
        }

        private void bnt_Transferir_Click(object sender, EventArgs e)
        {
            Program.ListContas[int.Parse(txb_NumCntOrigem.Text)].Transferir(
                int.Parse(txb_ValorTrans.Text), Program.ListContas[int.Parse(txb_NumCntDestino.Text)]);
            
            
            txb_ValorTrans.Text = "Valor a ser transferido: ";
            txb_NumCntOrigem.Text = "Número da Conta de Origem: ";
            txb_NumCntDestino.Text = "Número da conta de Destino: ";
        }
    }
}
