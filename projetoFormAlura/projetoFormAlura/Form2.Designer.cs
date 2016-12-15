namespace projetoFormAlura
{
    partial class Form2
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
            this.comboTitular22 = new System.Windows.Forms.ComboBox();
            this.titulares2 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.TextoNConta = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.btDeposito = new System.Windows.Forms.Button();
            this.btSaque = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTitular22
            // 
            this.comboTitular22.FormattingEnabled = true;
            this.comboTitular22.Location = new System.Drawing.Point(117, 379);
            this.comboTitular22.Name = "comboTitular22";
            this.comboTitular22.Size = new System.Drawing.Size(206, 21);
            this.comboTitular22.TabIndex = 0;
            this.comboTitular22.SelectedIndexChanged += new System.EventHandler(this.comboTirular_SelectedIndexChanged);
            // 
            // titulares2
            // 
            this.titulares2.AutoSize = true;
            this.titulares2.Location = new System.Drawing.Point(43, 387);
            this.titulares2.Name = "titulares2";
            this.titulares2.Size = new System.Drawing.Size(50, 13);
            this.titulares2.TabIndex = 1;
            this.titulares2.Text = "Titulares:";
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(117, 40);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(206, 20);
            this.textoNome.TabIndex = 2;
            // 
            // TextoNConta
            // 
            this.TextoNConta.Location = new System.Drawing.Point(117, 84);
            this.TextoNConta.Name = "TextoNConta";
            this.TextoNConta.Size = new System.Drawing.Size(206, 20);
            this.TextoNConta.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(117, 135);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(206, 20);
            this.textoSaldo.TabIndex = 4;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(117, 186);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(206, 20);
            this.textoValor.TabIndex = 5;
            // 
            // btDeposito
            // 
            this.btDeposito.Location = new System.Drawing.Point(117, 256);
            this.btDeposito.Name = "btDeposito";
            this.btDeposito.Size = new System.Drawing.Size(92, 23);
            this.btDeposito.TabIndex = 6;
            this.btDeposito.Text = "Depósito";
            this.btDeposito.UseVisualStyleBackColor = true;
            this.btDeposito.Click += new System.EventHandler(this.btDeposito_Click);
            // 
            // btSaque
            // 
            this.btSaque.Location = new System.Drawing.Point(231, 256);
            this.btSaque.Name = "btSaque";
            this.btSaque.Size = new System.Drawing.Size(92, 23);
            this.btSaque.TabIndex = 7;
            this.btSaque.Text = "Saque";
            this.btSaque.UseVisualStyleBackColor = true;
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(59, 193);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 8;
            this.valor.Text = "Valor:";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(18, 142);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(83, 13);
            this.saldo.TabIndex = 9;
            this.saldo.Text = "Saldo da Conta:";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(8, 84);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(93, 13);
            this.numero.TabIndex = 10;
            this.numero.Text = "Numero da Conta:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(16, 40);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(85, 13);
            this.nome.TabIndex = 11;
            this.nome.Text = "Nome do Titular:";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 465);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.btSaque);
            this.Controls.Add(this.btDeposito);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.TextoNConta);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.titulares2);
            this.Controls.Add(this.comboTitular22);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTitular22;
        private System.Windows.Forms.Label titulares2;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox TextoNConta;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button btDeposito;
        private System.Windows.Forms.Button btSaque;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label nome;
    }
}