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
    public partial class FormAlterarCliente : Form
    {
        public FormAlterarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd=")
            };

            cmd.Connection.Open();
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                textAltNome.Text = r.GetString(1);
                textAltSobrenome.Text = r.GetString(2);
                textAltCidade.Text = r.GetString(3);
            }
            else
            {
                MessageBox.Show("Digite um ID válido! Digite novamente.");
            }

            cmd.Connection.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd=")
        };
            cmd.CommandText = "UPDATE Cliente SET NOME = @nome, SOBRENOME = @sobrenome, CIDADE = @cidade WHERE ID = @id;";

            Cliente c = new Cliente();
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", c.Sobrenome);
            cmd.Parameters.AddWithValue("@cidade", c.Cidade);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Cliente alterado com sucesso!");
        }

        private void VoltarAoInicio3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
