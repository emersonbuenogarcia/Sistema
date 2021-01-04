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

        private void mnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mniFornecedores_Click(object sender, RoutedEventArgs e)
        {
            Fornecedores ownedFornecedores = new Fornecedores();
            ownedFornecedores.Owner = this;
            ownedFornecedores.ShowDialog();
        }

        private void mniProdutos_Click(object sender, RoutedEventArgs e)
        {
            Produtos ownedProdutos = new Produtos();
            ownedProdutos.Owner = this;
            ownedProdutos.ShowDialog();
        }
    }
}
