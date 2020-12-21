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
using System.Windows.Shapes;

namespace Sistema.Visao {
    /// <summary>
    /// Interaction logic for Produto.xaml
    /// </summary>
    public partial class Produto : Window {
        public Produto()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            tbcCadastro.IsEnabled = true;
            tbcCadastro.IsSelected = true;
            tbcConsulta.IsEnabled = false;
            Limpar();
            /*List<Fornecedor> Fornecedores = new List<Fornecedor>();
            Fornecedores.Add(new Fornecedor() { for_nome = "Carlos" });
            Fornecedores.Add(new Fornecedor() { Codigo = 250, Nome = "João" });
            Fornecedores.Add(new Fornecedor() { Codigo = 335, Nome = "Maria" });
            Fornecedores.Add(new Fornecedor() { Codigo = 458, Nome = "Carlos" });
            Fornecedores.Add(new Fornecedor() { Codigo = 976, Nome = "Antonia" });
            cmbFornecedor.ItemsSource = Fornecedores;*/
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            tbcConsulta.IsEnabled = true;
            tbcCadastro.IsEnabled = false;
            tbcConsulta.IsSelected = true;
            Limpar();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            tbcConsulta.IsEnabled = true;
            tbcCadastro.IsEnabled = false;
            tbcConsulta.IsSelected = true;
            Limpar();
        }

        private void Limpar()
        {
            txbNome.Text = "";
            txbQuantidade.Text = "";
            cmbFornecedor.SelectedValue = 0;
            txbPesquisar.Text = "";
        }
    }
}
