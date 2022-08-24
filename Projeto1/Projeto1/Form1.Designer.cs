namespace Projeto1
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
            this.btMostrar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblfrase = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btMostrar
            // 
            this.btMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrar.Location = new System.Drawing.Point(581, 53);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(180, 43);
            this.btMostrar.TabIndex = 0;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Red;
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(581, 114);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(180, 43);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lblfrase
            // 
            this.lblfrase.AutoSize = true;
            this.lblfrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrase.Location = new System.Drawing.Point(64, 42);
            this.lblfrase.Name = "lblfrase";
            this.lblfrase.Size = new System.Drawing.Size(141, 20);
            this.lblfrase.TabIndex = 2;
            this.lblfrase.Text = "Digite uma frase";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(64, 177);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblMostrar.TabIndex = 3;
            // 
            // txtfrase
            // 
            this.txtfrase.Location = new System.Drawing.Point(67, 76);
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(464, 20);
            this.txtfrase.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 318);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lblfrase);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btMostrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lblfrase;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.TextBox txtfrase;
    }
}

