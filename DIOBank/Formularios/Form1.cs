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
    public partial class F_Inicial : Form
    {
        public F_Inicial()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(62, 76, 94);
            //this.btn_Entrar.BackColor = Color.FromArgb(70, 67, 94);
            
        }

        private void btn_Entrar_Click(object sender, EventArgs e) => Close();

        
    }
}
