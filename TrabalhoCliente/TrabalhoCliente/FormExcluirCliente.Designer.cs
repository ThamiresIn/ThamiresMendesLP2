namespace TrabalhoCliente
{
    partial class FormExcluirCliente
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textPerquisarID = new System.Windows.Forms.TextBox();
            this.pesquisarID = new System.Windows.Forms.Label();
            this.textExNome = new System.Windows.Forms.TextBox();
            this.textExSobrenome = new System.Windows.Forms.TextBox();
            this.textSobrenome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.Label();
            this.Voltar4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(239, 200);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(354, 17);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // textPerquisarID
            // 
            this.textPerquisarID.Location = new System.Drawing.Point(229, 19);
            this.textPerquisarID.Name = "textPerquisarID";
            this.textPerquisarID.Size = new System.Drawing.Size(100, 20);
            this.textPerquisarID.TabIndex = 12;
            // 
            // pesquisarID
            // 
            this.pesquisarID.AutoSize = true;
            this.pesquisarID.Location = new System.Drawing.Point(75, 22);
            this.pesquisarID.Name = "pesquisarID";
            this.pesquisarID.Size = new System.Drawing.Size(135, 13);
            this.pesquisarID.TabIndex = 11;
            this.pesquisarID.Text = "ID do cliente a ser excluido";
            // 
            // textExNome
            // 
            this.textExNome.Location = new System.Drawing.Point(161, 101);
            this.textExNome.Name = "textExNome";
            this.textExNome.Size = new System.Drawing.Size(227, 20);
            this.textExNome.TabIndex = 17;
            // 
            // textExSobrenome
            // 
            this.textExSobrenome.Location = new System.Drawing.Point(161, 155);
            this.textExSobrenome.Name = "textExSobrenome";
            this.textExSobrenome.Size = new System.Drawing.Size(227, 20);
            this.textExSobrenome.TabIndex = 16;
            // 
            // textSobrenome
            // 
            this.textSobrenome.AutoSize = true;
            this.textSobrenome.Location = new System.Drawing.Point(158, 139);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(61, 13);
            this.textSobrenome.TabIndex = 15;
            this.textSobrenome.Text = "Sobrenome";
            // 
            // textNome
            // 
            this.textNome.AutoSize = true;
            this.textNome.Location = new System.Drawing.Point(158, 85);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(35, 13);
            this.textNome.TabIndex = 14;
            this.textNome.Text = "Nome";
            // 
            // Voltar4
            // 
            this.Voltar4.Location = new System.Drawing.Point(472, 226);
            this.Voltar4.Name = "Voltar4";
            this.Voltar4.Size = new System.Drawing.Size(75, 23);
            this.Voltar4.TabIndex = 18;
            this.Voltar4.Text = "Voltar4";
            this.Voltar4.UseVisualStyleBackColor = true;
            this.Voltar4.Click += new System.EventHandler(this.VoltarAoInicio4_Click);
            // 
            // FormExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.Voltar4);
            this.Controls.Add(this.textExNome);
            this.Controls.Add(this.textExSobrenome);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textPerquisarID);
            this.Controls.Add(this.pesquisarID);
            this.Controls.Add(this.btnExcluir);
            this.Name = "FormExcluirCliente";
            this.Text = "ExcluirCliente";
            this.Load += new System.EventHandler(this.FormExcluirCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textPerquisarID;
        private System.Windows.Forms.Label pesquisarID;
        private System.Windows.Forms.TextBox textExNome;
        private System.Windows.Forms.TextBox textExSobrenome;
        private System.Windows.Forms.Label textSobrenome;
        private System.Windows.Forms.Label textNome;
        private System.Windows.Forms.Button Voltar4;
    }
}