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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnConsultarID_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd="),
                CommandText = string.Format("SELECT C.NOME, C.SOBRENOME, C.CIDADE FROM Cliente C WHERE C.ID = {0};", textID)
            };

            cmd.Connection.Open;
            MySqlDataReader r;
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while(r.Read())
                {
                    int ID = r.GetInt32(0);
                    string Nome = r.GetString(1);
                    string Sobrenome = r.GetString(2);
                    string Cidade = r.GetString(3);
                    // mostrar as consultas
                }
            }
            cmd.Connection.Close;
        }

        private void btnConsultarCidade_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand ()
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cliente;Uid=root;Pwd="),
                CommandText = string.Format("SELECT C.NOME, C.SOBRENOME, C.CIDADE FROM Cliente C WHERE C.CIDADE = {0};", textCidade)
            };

            cmd.Connection.Open;
            MySqlDataReader r;
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    int ID = r.GetInt32(0);
                    string Nome = r.GetString(1);
                    string Sobrenome = r.GetString(2);
                    string Cidade = r.GetString(3);
                    // mostrar as consultas
                }
            }
            cmd.Connection.Close;
        } 

        private void VoltarAoInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
