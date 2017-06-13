using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrabalhoCliente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            FormCadastrarCliente Cadastrar = new FormCadastrarCliente();
            Cadastrar.ShowDialog();
        }

        private void Consultar_Click(object sender, RoutedEventArgs e)
        {
            FormConsultarCliente Consultar = new FormConsultarCliente();
            Consultar.ShowDialog();
        }

        private void Alterar_Click(object sender, RoutedEventArgs e)
        {
            FormAlterarCliente Alterar = new FormAlterarCliente();
            Alterar.Show();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            FormExcluirCliente Excluir = new FormExcluirCliente();
            Excluir.ShowDialog();
        }

       
    }
}
