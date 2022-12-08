namespace Aula8Dezembro
{
    partial class limpar
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
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.TextBox();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.Location = new System.Drawing.Point(293, 27);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 41);
            this.botaoLimpar.TabIndex = 0;
            this.botaoLimpar.Text = "limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(79, 110);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(289, 235);
            this.tela.TabIndex = 1;
            this.tela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputTexto
            // 
            this.inputTexto.Font = new System.Drawing.Font("Arial", 8.25F);
            this.inputTexto.Location = new System.Drawing.Point(79, 48);
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(100, 20);
            this.inputTexto.TabIndex = 2;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // limpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 469);
            this.Controls.Add(this.inputTexto);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.botaoLimpar);
            this.Name = "limpar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.TextBox inputTexto;
    }
}