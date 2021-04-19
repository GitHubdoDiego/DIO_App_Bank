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
    public partial class F_Sacar : Form
    {
        public F_Sacar()
        {
            InitializeComponent();
        }

        private void bnt_Sacar_Click(object sender, EventArgs e)
        {
            DIOBank.Program.ListContas[int.Parse(Txt_Nunconta.Text)].Sacar(int.Parse(txt_ValSaque.Text));
            Txt_Nunconta.Clear();
            txt_ValSaque.Clear();
        }

        private void Txt_Nunconta_Enter(object sender, EventArgs e)
        {
            Txt_Nunconta.Clear();
        }

        private void txt_ValSaque_Enter(object sender, EventArgs e)
        {
            txt_ValSaque.Clear();
        }
    }
}
