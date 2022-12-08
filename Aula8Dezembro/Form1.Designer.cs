namespace Aula8Dezembro
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
            this.input = new System.Windows.Forms.TextBox();
            this.mariza = new System.Windows.Forms.Label();
            this.botaoEmviar = new System.Windows.Forms.Button();
            this.mensagemFinal = new System.Windows.Forms.Label();
            this.labelDigitar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(204, 140);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            // 
            // mariza
            // 
            this.mariza.AutoSize = true;
            this.mariza.Location = new System.Drawing.Point(209, 227);
            this.mariza.Name = "mariza";
            this.mariza.Size = new System.Drawing.Size(0, 13);
            this.mariza.TabIndex = 1;
            // 
            // botaoEmviar
            // 
            this.botaoEmviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEmviar.Location = new System.Drawing.Point(204, 166);
            this.botaoEmviar.Name = "botaoEmviar";
            this.botaoEmviar.Size = new System.Drawing.Size(111, 58);
            this.botaoEmviar.TabIndex = 2;
            this.botaoEmviar.Text = "enviar";
            this.botaoEmviar.UseVisualStyleBackColor = true;
            this.botaoEmviar.Click += new System.EventHandler(this.botaoEmviar_Click);
            // 
            // mensagemFinal
            // 
            this.mensagemFinal.AutoSize = true;
            this.mensagemFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemFinal.Location = new System.Drawing.Point(200, 279);
            this.mensagemFinal.Name = "mensagemFinal";
            this.mensagemFinal.Size = new System.Drawing.Size(224, 25);
            this.mensagemFinal.TabIndex = 3;
            this.mensagemFinal.Text = "O nome digitado foi:";
            // 
            // labelDigitar
            // 
            this.labelDigitar.AutoSize = true;
            this.labelDigitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigitar.Location = new System.Drawing.Point(199, 94);
            this.labelDigitar.Name = "labelDigitar";
            this.labelDigitar.Size = new System.Drawing.Size(182, 25);
            this.labelDigitar.TabIndex = 4;
            this.labelDigitar.Text = "Digite um nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDigitar);
            this.Controls.Add(this.mensagemFinal);
            this.Controls.Add(this.botaoEmviar);
            this.Controls.Add(this.mariza);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label mariza;
        private System.Windows.Forms.Button botaoEmviar;
        private System.Windows.Forms.Label mensagemFinal;
        private System.Windows.Forms.Label labelDigitar;
    }
}

