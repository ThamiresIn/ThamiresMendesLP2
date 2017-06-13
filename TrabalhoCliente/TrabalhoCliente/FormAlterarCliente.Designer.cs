namespace TrabalhoCliente
{
    partial class FormAlterarCliente
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pesquisarID = new System.Windows.Forms.Label();
            this.altNome = new System.Windows.Forms.Label();
            this.altSobrenome = new System.Windows.Forms.Label();
            this.altCidade = new System.Windows.Forms.Label();
            this.textPerquisarID = new System.Windows.Forms.TextBox();
            this.textAltCidade = new System.Windows.Forms.TextBox();
            this.textAltSobrenome = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.textAltNome = new System.Windows.Forms.TextBox();
            this.VoltarAoInicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(312, 170);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pesquisarID
            // 
            this.pesquisarID.AutoSize = true;
            this.pesquisarID.Location = new System.Drawing.Point(71, 25);
            this.pesquisarID.Name = "pesquisarID";
            this.pesquisarID.Size = new System.Drawing.Size(134, 13);
            this.pesquisarID.TabIndex = 2;
            this.pesquisarID.Text = "ID do cliente a ser alterado";
            this.pesquisarID.Click += new System.EventHandler(this.label1_Click);
            // 
            // altNome
            // 
            this.altNome.AutoSize = true;
            this.altNome.Location = new System.Drawing.Point(144, 85);
            this.altNome.Name = "altNome";
            this.altNome.Size = new System.Drawing.Size(35, 13);
            this.altNome.TabIndex = 3;
            this.altNome.Text = "Nome";
            // 
            // altSobrenome
            // 
            this.altSobrenome.AutoSize = true;
            this.altSobrenome.Location = new System.Drawing.Point(144, 112);
            this.altSobrenome.Name = "altSobrenome";
            this.altSobrenome.Size = new System.Drawing.Size(61, 13);
            this.altSobrenome.TabIndex = 4;
            this.altSobrenome.Text = "Sobrenome";
            // 
            // altCidade
            // 
            this.altCidade.AutoSize = true;
            this.altCidade.Location = new System.Drawing.Point(144, 138);
            this.altCidade.Name = "altCidade";
            this.altCidade.Size = new System.Drawing.Size(40, 13);
            this.altCidade.TabIndex = 5;
            this.altCidade.Text = "Cidade";
            // 
            // textPerquisarID
            // 
            this.textPerquisarID.Location = new System.Drawing.Point(225, 22);
            this.textPerquisarID.Name = "textPerquisarID";
            this.textPerquisarID.Size = new System.Drawing.Size(100, 20);
            this.textPerquisarID.TabIndex = 6;
            // 
            // textAltCidade
            // 
            this.textAltCidade.Location = new System.Drawing.Point(230, 131);
            this.textAltCidade.Name = "textAltCidade";
            this.textAltCidade.Size = new System.Drawing.Size(227, 20);
            this.textAltCidade.TabIndex = 7;
            // 
            // textAltSobrenome
            // 
            this.textAltSobrenome.Location = new System.Drawing.Point(230, 105);
            this.textAltSobrenome.Name = "textAltSobrenome";
            this.textAltSobrenome.Size = new System.Drawing.Size(227, 20);
            this.textAltSobrenome.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(350, 20);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textAltNome
            // 
            this.textAltNome.Location = new System.Drawing.Point(230, 78);
            this.textAltNome.Name = "textAltNome";
            this.textAltNome.Size = new System.Drawing.Size(227, 20);
            this.textAltNome.TabIndex = 9;
            // 
            // VoltarAoInicio3
            // 
            this.VoltarAoInicio3.Location = new System.Drawing.Point(520, 212);
            this.VoltarAoInicio3.Name = "VoltarAoInicio3";
            this.VoltarAoInicio3.Size = new System.Drawing.Size(75, 23);
            this.VoltarAoInicio3.TabIndex = 19;
            this.VoltarAoInicio3.Text = "Voltar";
            this.VoltarAoInicio3.UseVisualStyleBackColor = true;
            this.VoltarAoInicio3.Click += new System.EventHandler(this.VoltarAoInicio3_Click);
            // 
            // FormAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 247);
            this.Controls.Add(this.VoltarAoInicio3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textAltNome);
            this.Controls.Add(this.textAltSobrenome);
            this.Controls.Add(this.textAltCidade);
            this.Controls.Add(this.textPerquisarID);
            this.Controls.Add(this.altCidade);
            this.Controls.Add(this.altSobrenome);
            this.Controls.Add(this.altNome);
            this.Controls.Add(this.pesquisarID);
            this.Controls.Add(this.btnAlterar);
            this.Name = "FormAlterarCliente";
            this.Text = "AlterarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label pesquisarID;
        private System.Windows.Forms.Label altNome;
        private System.Windows.Forms.Label altSobrenome;
        private System.Windows.Forms.Label altCidade;
        private System.Windows.Forms.TextBox textPerquisarID;
        private System.Windows.Forms.TextBox textAltCidade;
        private System.Windows.Forms.TextBox textAltSobrenome;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textAltNome;
        private System.Windows.Forms.Button VoltarAoInicio3;
    }
}