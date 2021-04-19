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
    public partial class F_Gerenciador : Form
    {

        public F_Gerenciador()
        {
            InitializeComponent();
        }
        private void F_Gerenciador_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.FromArgb(167, 162, 169);
                }
            }

            F_Inicial f_Inicial = new();
            f_Inicial.ShowDialog();
        }

        private void tsm_AddAcc_Click(object sender, EventArgs e)
        {
            F_AddAcc f_AddAcc = new F_AddAcc();
            f_AddAcc.MdiParent = this;
            f_AddAcc.Show();
        }

        private void tsm_Depositar_Click(object sender, EventArgs e)
        {
            F_Depositar f_Depositar = new();
            f_Depositar.MdiParent = this;
            f_Depositar.Show();
        }
        private void tsm_Sacar_Click(object sender, EventArgs e)
        {
            F_Sacar f_Sacar = new();
            f_Sacar.MdiParent = this;
            f_Sacar.Show();
        }

        private void tsm_Transferir_Click(object sender, EventArgs e)
        {
            F_Transferir f_Transferir = new();
            f_Transferir.MdiParent = this;
            f_Transferir.Show();
        }

        private void tsm_ListarContas_Click(object sender, EventArgs e)
        {
            F_ListarContas f_ListarContas = new();
            f_ListarContas.MdiParent = this;
            f_ListarContas.Show();
        }
    }
}
