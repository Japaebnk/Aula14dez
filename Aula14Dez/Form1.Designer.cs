namespace Aula14Dez
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaolimpar = new System.Windows.Forms.Button();
            this.labelmensagem = new System.Windows.Forms.Label();
            this.imputmensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaolimpar
            // 
            this.botaolimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaolimpar.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaolimpar.ForeColor = System.Drawing.Color.White;
            this.botaolimpar.Location = new System.Drawing.Point(283, 49);
            this.botaolimpar.Name = "botaolimpar";
            this.botaolimpar.Size = new System.Drawing.Size(80, 31);
            this.botaolimpar.TabIndex = 0;
            this.botaolimpar.Text = "LIMPAR";
            this.botaolimpar.UseVisualStyleBackColor = false;
            this.botaolimpar.Click += new System.EventHandler(this.botaolimpar_Click);
            // 
            // labelmensagem
            // 
            this.labelmensagem.AutoSize = true;
            this.labelmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmensagem.Location = new System.Drawing.Point(19, 92);
            this.labelmensagem.Name = "labelmensagem";
            this.labelmensagem.Size = new System.Drawing.Size(88, 20);
            this.labelmensagem.TabIndex = 1;
            this.labelmensagem.Text = "Mensagem";
            // 
            // imputmensagem
            // 
            this.imputmensagem.Location = new System.Drawing.Point(23, 55);
            this.imputmensagem.Name = "imputmensagem";
            this.imputmensagem.Size = new System.Drawing.Size(230, 20);
            this.imputmensagem.TabIndex = 2;
            this.imputmensagem.TextChanged += new System.EventHandler(this.imputmensagem_TextChanged);
            this.imputmensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerificaçãoDeCaracteres);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 131);
            this.Controls.Add(this.imputmensagem);
            this.Controls.Add(this.labelmensagem);
            this.Controls.Add(this.botaolimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaolimpar;
        private System.Windows.Forms.Label labelmensagem;
        private System.Windows.Forms.TextBox imputmensagem;
    }
}

