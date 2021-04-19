
namespace DIOBank
{
    partial class F_AddAcc
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.cb_PF = new System.Windows.Forms.CheckBox();
            this.cb_PJ = new System.Windows.Forms.CheckBox();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_Credito = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(42, 128);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(158, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.Text = "Digite o Nome do Cliente.";
            this.txt_Nome.Click += new System.EventHandler(this.txt_Nome_Click);
            // 
            // cb_PF
            // 
            this.cb_PF.AutoSize = true;
            this.cb_PF.Location = new System.Drawing.Point(12, 81);
            this.cb_PF.Name = "cb_PF";
            this.cb_PF.Size = new System.Drawing.Size(94, 19);
            this.cb_PF.TabIndex = 1;
            this.cb_PF.Text = "Pessoa Física";
            this.cb_PF.UseVisualStyleBackColor = true;
            this.cb_PF.CheckedChanged += new System.EventHandler(this.cb_PF_CheckedChanged);
            // 
            // cb_PJ
            // 
            this.cb_PJ.AutoSize = true;
            this.cb_PJ.Location = new System.Drawing.Point(126, 81);
            this.cb_PJ.Name = "cb_PJ";
            this.cb_PJ.Size = new System.Drawing.Size(105, 19);
            this.cb_PJ.TabIndex = 2;
            this.cb_PJ.Text = "Pessoa Jurídica";
            this.cb_PJ.UseVisualStyleBackColor = true;
            this.cb_PJ.CheckedChanged += new System.EventHandler(this.cb_PJ_CheckedChanged);
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(42, 176);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(158, 23);
            this.txt_Saldo.TabIndex = 3;
            this.txt_Saldo.Text = "Digite o saldo inicial:";
            this.txt_Saldo.Click += new System.EventHandler(this.txt_Saldo_Click);
            // 
            // txt_Credito
            // 
            this.txt_Credito.Location = new System.Drawing.Point(42, 230);
            this.txt_Credito.Name = "txt_Credito";
            this.txt_Credito.Size = new System.Drawing.Size(158, 23);
            this.txt_Credito.TabIndex = 4;
            this.txt_Credito.Text = "Digite o crédito:";
            this.txt_Credito.Click += new System.EventHandler(this.txt_Credito_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_AddAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(243, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Credito);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.cb_PJ);
            this.Controls.Add(this.cb_PF);
            this.Controls.Add(this.txt_Nome);
            this.MaximizeBox = false;
            this.Name = "F_AddAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.CheckBox cb_PF;
        private System.Windows.Forms.CheckBox cb_PJ;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_Credito;
        private System.Windows.Forms.Button button1;
    }
}