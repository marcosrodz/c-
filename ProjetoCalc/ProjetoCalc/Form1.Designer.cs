namespace ProjetoCalc
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
            this.btSomar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblXXX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSomar
            // 
            this.btSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomar.Location = new System.Drawing.Point(501, 39);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(161, 41);
            this.btSomar.TabIndex = 0;
            this.btSomar.Text = "SOMA";
            this.btSomar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nº 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btSubtracao
            // 
            this.btSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtracao.Location = new System.Drawing.Point(501, 98);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(161, 41);
            this.btSubtracao.TabIndex = 9;
            this.btSubtracao.Text = "SUBTRAÇÃO";
            this.btSubtracao.UseVisualStyleBackColor = true;
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacao.Location = new System.Drawing.Point(501, 156);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(161, 41);
            this.btMultiplicacao.TabIndex = 10;
            this.btMultiplicacao.Text = "MULTIPLICAÇÃO";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btDivisao
            // 
            this.btDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivisao.Location = new System.Drawing.Point(501, 219);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(161, 41);
            this.btDivisao.TabIndex = 11;
            this.btDivisao.Text = "DIVISÃO";
            this.btDivisao.UseVisualStyleBackColor = true;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Red;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(501, 278);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(161, 41);
            this.btFechar.TabIndex = 12;
            this.btFechar.Text = "FECHAR";
            this.btFechar.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(39, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado";
            // 
            // lblXXX
            // 
            this.lblXXX.AutoSize = true;
            this.lblXXX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXXX.Location = new System.Drawing.Point(39, 201);
            this.lblXXX.Name = "lblXXX";
            this.lblXXX.Size = new System.Drawing.Size(69, 20);
            this.lblXXX.TabIndex = 14;
            this.lblXXX.Text = "XXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 365);
            this.Controls.Add(this.lblXXX);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSomar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblXXX;
    }
}

