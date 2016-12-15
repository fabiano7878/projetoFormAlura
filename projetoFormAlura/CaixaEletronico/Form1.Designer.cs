namespace CaixaEletronico
{
    partial class Form1
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
            this.titularesSeleciona = new System.Windows.Forms.Label();
            this.comboTitular = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titularesSeleciona
            // 
            this.titularesSeleciona.AutoSize = true;
            this.titularesSeleciona.Location = new System.Drawing.Point(53, 453);
            this.titularesSeleciona.Name = "titularesSeleciona";
            this.titularesSeleciona.Size = new System.Drawing.Size(107, 13);
            this.titularesSeleciona.TabIndex = 1;
            this.titularesSeleciona.Text = "Seleção de Titulares:";
            this.titularesSeleciona.Click += new System.EventHandler(this.comboTitular_SelectedIndexChanged);
            // 
            // comboTitular
            // 
            this.comboTitular.FormattingEnabled = true;
            this.comboTitular.Location = new System.Drawing.Point(253, 445);
            this.comboTitular.Name = "comboTitular";
            this.comboTitular.Size = new System.Drawing.Size(246, 21);
            this.comboTitular.TabIndex = 2;
            this.comboTitular.Text = "Selecione o Titular";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(559, 524);
            this.Controls.Add(this.comboTitular);
            this.Controls.Add(this.titularesSeleciona);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.TextBox TextoNConta;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button btDeposito;
        private System.Windows.Forms.Button btSaque;
        private System.Windows.Forms.ComboBox comboTitular;
        private System.Windows.Forms.Label titulares;
        private System.Windows.Forms.Label titularesSeleciona;
    }
}

