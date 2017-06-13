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
    public partial class FormExcluirCliente : Form
    {
        public FormExcluirCliente()
        {
            InitializeComponent();
        }

        private void FormExcluirCliente_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd=")
            };

            cmd.Connection.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textNome.Text = r.GetString(1);
                textSobrenome.Text = r.GetString(2);
            }
            else
            {
                MessageBox.Show("Digite um ID válido!");
                textPerquisarID.Clear();
            }
            cmd.Connection.Close();

        }

        private void Voltar4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
