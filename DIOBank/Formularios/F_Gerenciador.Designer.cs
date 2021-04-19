
namespace DIOBank
{
    partial class F_Gerenciador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_AddAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_MngAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Depositar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Sacar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Transferir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ListarContas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_AddAcc,
            this.tsm_MngAcc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Adicionar Contas";
            // 
            // tsm_AddAcc
            // 
            this.tsm_AddAcc.Name = "tsm_AddAcc";
            this.tsm_AddAcc.Size = new System.Drawing.Size(110, 20);
            this.tsm_AddAcc.Text = "&Adicionar Contas";
            this.tsm_AddAcc.Click += new System.EventHandler(this.tsm_AddAcc_Click);
            // 
            // tsm_MngAcc
            // 
            this.tsm_MngAcc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Depositar,
            this.tsm_Sacar,
            this.tsm_Transferir,
            this.tsm_ListarContas});
            this.tsm_MngAcc.Name = "tsm_MngAcc";
            this.tsm_MngAcc.Size = new System.Drawing.Size(109, 20);
            this.tsm_MngAcc.Text = "&Gerenciar Contas";
            // 
            // tsm_Depositar
            // 
            this.tsm_Depositar.Name = "tsm_Depositar";
            this.tsm_Depositar.Size = new System.Drawing.Size(142, 22);
            this.tsm_Depositar.Text = "Depositar";
            this.tsm_Depositar.Click += new System.EventHandler(this.tsm_Depositar_Click);
            // 
            // tsm_Sacar
            // 
            this.tsm_Sacar.Name = "tsm_Sacar";
            this.tsm_Sacar.Size = new System.Drawing.Size(142, 22);
            this.tsm_Sacar.Text = "Sacar";
            this.tsm_Sacar.Click += new System.EventHandler(this.tsm_Sacar_Click);
            // 
            // tsm_Transferir
            // 
            this.tsm_Transferir.Name = "tsm_Transferir";
            this.tsm_Transferir.Size = new System.Drawing.Size(142, 22);
            this.tsm_Transferir.Text = "Transferir";
            this.tsm_Transferir.Click += new System.EventHandler(this.tsm_Transferir_Click);
            // 
            // tsm_ListarContas
            // 
            this.tsm_ListarContas.Name = "tsm_ListarContas";
            this.tsm_ListarContas.Size = new System.Drawing.Size(142, 22);
            this.tsm_ListarContas.Text = "Listar Contas";
            this.tsm_ListarContas.Click += new System.EventHandler(this.tsm_ListarContas_Click);
            // 
            // F_Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 560);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Gerenciador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Gerenciador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_AddAcc;
        private System.Windows.Forms.ToolStripMenuItem tsm_MngAcc;
        private System.Windows.Forms.ToolStripMenuItem tsm_Depositar;
        private System.Windows.Forms.ToolStripMenuItem tsm_Sacar;
        private System.Windows.Forms.ToolStripMenuItem tsm_Transferir;
        private System.Windows.Forms.ToolStripMenuItem tsm_ListarContas;
    }
}