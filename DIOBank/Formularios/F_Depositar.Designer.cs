
namespace DIOBank
{
    partial class F_Depositar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb_ValorDeposito = new System.Windows.Forms.TextBox();
            this.bnt_Depositar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Digite o número da conta:";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txb_ValorDeposito
            // 
            this.txb_ValorDeposito.Location = new System.Drawing.Point(13, 146);
            this.txb_ValorDeposito.Name = "txb_ValorDeposito";
            this.txb_ValorDeposito.Size = new System.Drawing.Size(176, 23);
            this.txb_ValorDeposito.TabIndex = 1;
            this.txb_ValorDeposito.Text = "Digite o valor a ser depositado:";
            this.txb_ValorDeposito.Click += new System.EventHandler(this.txb_ValorDeposito_Click);
            // 
            // bnt_Depositar
            // 
            this.bnt_Depositar.Location = new System.Drawing.Point(13, 207);
            this.bnt_Depositar.Name = "bnt_Depositar";
            this.bnt_Depositar.Size = new System.Drawing.Size(176, 23);
            this.bnt_Depositar.TabIndex = 0;
            this.bnt_Depositar.Text = "Depositar";
            this.bnt_Depositar.UseVisualStyleBackColor = true;
            this.bnt_Depositar.Click += new System.EventHandler(this.bnt_Depositar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEPOSITO";
            // 
            // F_Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(199, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_ValorDeposito);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnt_Depositar);
            this.Name = "F_Depositar";
            this.Text = "F_Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb_ValorDeposito;
        private System.Windows.Forms.Button bnt_Depositar;
        private System.Windows.Forms.Label label1;
    }
}