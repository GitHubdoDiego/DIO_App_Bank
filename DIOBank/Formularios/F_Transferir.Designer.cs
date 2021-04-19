
namespace DIOBank
{
    partial class F_Transferir
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
            this.txb_NumCntOrigem = new System.Windows.Forms.TextBox();
            this.txb_NumCntDestino = new System.Windows.Forms.TextBox();
            this.txb_ValorTrans = new System.Windows.Forms.TextBox();
            this.bnt_Transferir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_NumCntOrigem
            // 
            this.txb_NumCntOrigem.Location = new System.Drawing.Point(12, 124);
            this.txb_NumCntOrigem.Name = "txb_NumCntOrigem";
            this.txb_NumCntOrigem.Size = new System.Drawing.Size(171, 23);
            this.txb_NumCntOrigem.TabIndex = 0;
            this.txb_NumCntOrigem.Text = "Número da conta de origem:";
            this.txb_NumCntOrigem.Click += new System.EventHandler(this.txb_NumCntOrigem_Click);
            // 
            // txb_NumCntDestino
            // 
            this.txb_NumCntDestino.Location = new System.Drawing.Point(12, 164);
            this.txb_NumCntDestino.Name = "txb_NumCntDestino";
            this.txb_NumCntDestino.Size = new System.Drawing.Size(171, 23);
            this.txb_NumCntDestino.TabIndex = 0;
            this.txb_NumCntDestino.Text = "Número da conta de destino:";
            this.txb_NumCntDestino.Click += new System.EventHandler(this.txb_NumCntDestino_Click);
            // 
            // txb_ValorTrans
            // 
            this.txb_ValorTrans.Location = new System.Drawing.Point(12, 208);
            this.txb_ValorTrans.Name = "txb_ValorTrans";
            this.txb_ValorTrans.Size = new System.Drawing.Size(171, 23);
            this.txb_ValorTrans.TabIndex = 0;
            this.txb_ValorTrans.Text = "Valor a ser transferido:";
            this.txb_ValorTrans.Click += new System.EventHandler(this.txb_ValorTrans_Click);
            // 
            // bnt_Transferir
            // 
            this.bnt_Transferir.Location = new System.Drawing.Point(12, 255);
            this.bnt_Transferir.Name = "bnt_Transferir";
            this.bnt_Transferir.Size = new System.Drawing.Size(171, 23);
            this.bnt_Transferir.TabIndex = 1;
            this.bnt_Transferir.Text = "Transferir";
            this.bnt_Transferir.UseVisualStyleBackColor = true;
            this.bnt_Transferir.Click += new System.EventHandler(this.bnt_Transferir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRANSFERÊNCIA";
            // 
            // F_Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(199, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_Transferir);
            this.Controls.Add(this.txb_ValorTrans);
            this.Controls.Add(this.txb_NumCntDestino);
            this.Controls.Add(this.txb_NumCntOrigem);
            this.MaximizeBox = false;
            this.Name = "F_Transferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_NumCntOrigem;
        private System.Windows.Forms.TextBox txb_NumCntDestino;
        private System.Windows.Forms.TextBox txb_ValorTrans;
        private System.Windows.Forms.Button bnt_Transferir;
        private System.Windows.Forms.Label label1;
    }
}