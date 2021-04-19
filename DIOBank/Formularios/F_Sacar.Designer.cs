
namespace DIOBank
{
    partial class F_Sacar
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
            this.txt_ValSaque = new System.Windows.Forms.TextBox();
            this.Txt_Nunconta = new System.Windows.Forms.TextBox();
            this.bnt_Sacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ValSaque
            // 
            this.txt_ValSaque.BackColor = System.Drawing.Color.White;
            this.txt_ValSaque.Location = new System.Drawing.Point(7, 108);
            this.txt_ValSaque.Name = "txt_ValSaque";
            this.txt_ValSaque.Size = new System.Drawing.Size(150, 23);
            this.txt_ValSaque.TabIndex = 0;
            this.txt_ValSaque.Enter += new System.EventHandler(this.txt_ValSaque_Enter);
            // 
            // Txt_Nunconta
            // 
            this.Txt_Nunconta.BackColor = System.Drawing.Color.White;
            this.Txt_Nunconta.Location = new System.Drawing.Point(7, 42);
            this.Txt_Nunconta.Name = "Txt_Nunconta";
            this.Txt_Nunconta.Size = new System.Drawing.Size(150, 23);
            this.Txt_Nunconta.TabIndex = 0;
            this.Txt_Nunconta.Enter += new System.EventHandler(this.Txt_Nunconta_Enter);
            // 
            // bnt_Sacar
            // 
            this.bnt_Sacar.Location = new System.Drawing.Point(7, 194);
            this.bnt_Sacar.Name = "bnt_Sacar";
            this.bnt_Sacar.Size = new System.Drawing.Size(150, 23);
            this.bnt_Sacar.TabIndex = 1;
            this.bnt_Sacar.Text = "Sacar";
            this.bnt_Sacar.UseVisualStyleBackColor = true;
            this.bnt_Sacar.Click += new System.EventHandler(this.bnt_Sacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o número da conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o valor a ser sacado:";
            // 
            // F_Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(177, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_Sacar);
            this.Controls.Add(this.Txt_Nunconta);
            this.Controls.Add(this.txt_ValSaque);
            this.MaximizeBox = false;
            this.Name = "F_Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ValSaque;
        private System.Windows.Forms.TextBox Txt_Nunconta;
        private System.Windows.Forms.Button bnt_Sacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}