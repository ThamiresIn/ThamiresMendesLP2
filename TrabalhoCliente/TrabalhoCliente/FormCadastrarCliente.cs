using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoCliente
{
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd="),
                CommandText = "INSERT INTO Cliente (NOME, SOBRENOME, CIDADE) VALUES (@nome, @sobrenome,@cidade);"
            };

            Cliente c = new Cliente();
            c.Nome = textNome.Text;
            c.Sobrenome = textSobrenome.Text;
            c.Cidade = textCidade.Text;
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", c.Sobrenome);
            cmd.Parameters.AddWithValue("@cidade", c.Cidade);

            cmd.Connection.Open;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close;

            MessageBox.Show("Cliente cadastrado com sucesso");

        }

        private void VoltarAoInicio1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

