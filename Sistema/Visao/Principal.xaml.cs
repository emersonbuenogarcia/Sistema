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
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window {
        public Principal()
        {
            InitializeComponent();
        }

        private void imProdutos_Click(object sender, RoutedEventArgs e)
        {
            Produto ownedProduto = new Produto();
            ownedProduto.Owner = this;
            ownedProduto.ShowDialog();
        }

        private void imFornecedores_Click(object sender, RoutedEventArgs e)
        {
            Fornecedor ownedFornecedor = new Fornecedor();
            ownedFornecedor.Owner = this;
            ownedFornecedor.ShowDialog();
        }

        private void imSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
