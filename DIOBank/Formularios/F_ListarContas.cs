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
    public partial class F_ListarContas : Form
    {
        public F_ListarContas()
        {
            InitializeComponent();
        }

        private void bnt_Carregar_Click(object sender, EventArgs e)
        {
            listb_Contas.Items.Clear();
            if (Program.ListContas.Count == 0)
            {
                listb_Contas.Items.Add("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < Program.ListContas.Count; i++)
            {
                Conta conta = Program.ListContas[i];
                listb_Contas.Items.Add($"#{i} - ");
                listb_Contas.Items.Add(conta);
            }
        }
    }
}
