namespace MeuPrimeiroApp
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
            this.Ligar = new System.Windows.Forms.Button();
            this.Desligar = new System.Windows.Forms.Button();
            this.detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(150, 70);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(75, 23);
            this.Ligar.TabIndex = 0;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(316, 70);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(75, 23);
            this.Desligar.TabIndex = 1;
            this.Desligar.Text = "Desligar";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // detalhes
            // 
            this.detalhes.Location = new System.Drawing.Point(494, 69);
            this.detalhes.Name = "detalhes";
            this.detalhes.Size = new System.Drawing.Size(75, 23);
            this.detalhes.TabIndex = 2;
            this.detalhes.Text = "Detalhes";
            this.detalhes.UseVisualStyleBackColor = true;
            this.detalhes.Click += new System.EventHandler(this.detalhes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detalhes);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.Ligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button detalhes;
        private System.Windows.Forms.Button button1;
    }
}

