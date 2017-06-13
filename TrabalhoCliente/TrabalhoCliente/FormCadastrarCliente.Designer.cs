namespace TrabalhoCliente
{
    partial class FormCadastrarCliente
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.VoltarAoInicio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(212, 176);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(133, 51);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(234, 20);
            this.textNome.TabIndex = 1;
            // 
            // textSobrenome
            // 
            this.textSobrenome.Location = new System.Drawing.Point(133, 88);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(234, 20);
            this.textSobrenome.TabIndex = 2;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(133, 129);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(234, 20);
            this.textCidade.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(71, 54);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Location = new System.Drawing.Point(71, 95);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Sobrenome.TabIndex = 5;
            this.Sobrenome.Text = "Sobrenome";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(71, 136);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 6;
            this.Cidade.Text = "Cidade";
            // 
            // VoltarAoInicio1
            // 
            this.VoltarAoInicio1.Location = new System.Drawing.Point(359, 227);
            this.VoltarAoInicio1.Name = "VoltarAoInicio1";
            this.VoltarAoInicio1.Size = new System.Drawing.Size(75, 23);
            this.VoltarAoInicio1.TabIndex = 19;
            this.VoltarAoInicio1.Text = "Voltar";
            this.VoltarAoInicio1.UseVisualStyleBackColor = true;
            this.VoltarAoInicio1.Click += new System.EventHandler(this.VoltarAoInicio1_Click);
            // 
            // FormCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.VoltarAoInicio1);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormCadastrarCliente";
            this.Text = "CadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Button VoltarAoInicio1;
    }
}