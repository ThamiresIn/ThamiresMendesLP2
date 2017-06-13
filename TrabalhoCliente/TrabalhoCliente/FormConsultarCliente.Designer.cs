namespace TrabalhoCliente
{
    partial class FormConsultarCliente
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
            this.btnConsultarID = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.ConsultaPorID = new System.Windows.Forms.Label();
            this.ConsultarPorCidade = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.btnConsultarCidade = new System.Windows.Forms.Button();
            this.VoltarAoInicio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarID
            // 
            this.btnConsultarID.Location = new System.Drawing.Point(293, 8);
            this.btnConsultarID.Name = "btnConsultarID";
            this.btnConsultarID.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarID.TabIndex = 1;
            this.btnConsultarID.Text = "Consultar";
            this.btnConsultarID.UseVisualStyleBackColor = true;
            this.btnConsultarID.Click += new System.EventHandler(this.btnConsultarID_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(156, 8);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 2;
            // 
            // ConsultaPorID
            // 
            this.ConsultaPorID.AutoSize = true;
            this.ConsultaPorID.Location = new System.Drawing.Point(28, 15);
            this.ConsultaPorID.Name = "ConsultaPorID";
            this.ConsultaPorID.Size = new System.Drawing.Size(80, 13);
            this.ConsultaPorID.TabIndex = 3;
            this.ConsultaPorID.Text = "Consulta por ID";
            // 
            // ConsultarPorCidade
            // 
            this.ConsultarPorCidade.AutoSize = true;
            this.ConsultarPorCidade.Location = new System.Drawing.Point(28, 55);
            this.ConsultarPorCidade.Name = "ConsultarPorCidade";
            this.ConsultarPorCidade.Size = new System.Drawing.Size(102, 13);
            this.ConsultarPorCidade.TabIndex = 6;
            this.ConsultarPorCidade.Text = "Consulta por Cidade";
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(156, 48);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(100, 20);
            this.textCidade.TabIndex = 5;
            // 
            // btnConsultarCidade
            // 
            this.btnConsultarCidade.Location = new System.Drawing.Point(293, 48);
            this.btnConsultarCidade.Name = "btnConsultarCidade";
            this.btnConsultarCidade.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCidade.TabIndex = 4;
            this.btnConsultarCidade.Text = "Consultar";
            this.btnConsultarCidade.UseVisualStyleBackColor = true;
            this.btnConsultarCidade.Click += new System.EventHandler(this.btnConsultarCidade_Click);
            // 
            // VoltarAoInicio2
            // 
            this.VoltarAoInicio2.Location = new System.Drawing.Point(397, 272);
            this.VoltarAoInicio2.Name = "VoltarAoInicio2";
            this.VoltarAoInicio2.Size = new System.Drawing.Size(75, 23);
            this.VoltarAoInicio2.TabIndex = 19;
            this.VoltarAoInicio2.Text = "Voltar";
            this.VoltarAoInicio2.UseVisualStyleBackColor = true;
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 307);
            this.Controls.Add(this.VoltarAoInicio2);
            this.Controls.Add(this.ConsultarPorCidade);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.btnConsultarCidade);
            this.Controls.Add(this.ConsultaPorID);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnConsultarID);
            this.Name = "FormConsultarCliente";
            this.Text = "ConsultarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label ConsultaPorID;
        private System.Windows.Forms.Label ConsultarPorCidade;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Button btnConsultarCidade;
        private System.Windows.Forms.Button VoltarAoInicio2;
    }
}