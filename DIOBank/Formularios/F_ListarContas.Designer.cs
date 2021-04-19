
namespace DIOBank
{
    partial class F_ListarContas
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
            this.label1 = new System.Windows.Forms.Label();
            this.listb_Contas = new System.Windows.Forms.ListBox();
            this.bnt_Carregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contas:";
            // 
            // listb_Contas
            // 
            this.listb_Contas.FormattingEnabled = true;
            this.listb_Contas.ItemHeight = 15;
            this.listb_Contas.Location = new System.Drawing.Point(12, 89);
            this.listb_Contas.Name = "listb_Contas";
            this.listb_Contas.Size = new System.Drawing.Size(534, 349);
            this.listb_Contas.TabIndex = 1;
            // 
            // bnt_Carregar
            // 
            this.bnt_Carregar.Location = new System.Drawing.Point(398, 63);
            this.bnt_Carregar.Name = "bnt_Carregar";
            this.bnt_Carregar.Size = new System.Drawing.Size(143, 23);
            this.bnt_Carregar.TabIndex = 2;
            this.bnt_Carregar.Text = "Carregar Lista";
            this.bnt_Carregar.UseVisualStyleBackColor = true;
            this.bnt_Carregar.Click += new System.EventHandler(this.bnt_Carregar_Click);
            // 
            // F_ListarContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.bnt_Carregar);
            this.Controls.Add(this.listb_Contas);
            this.Controls.Add(this.label1);
            this.Name = "F_ListarContas";
            this.Text = "Lista de contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listb_Contas;
        private System.Windows.Forms.Button bnt_Carregar;
    }
}