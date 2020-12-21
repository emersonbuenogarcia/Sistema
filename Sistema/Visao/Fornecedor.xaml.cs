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
using Sistema.Modelo;

namespace Sistema.Visao {
    /// <summary>
    /// Interaction logic for Fornecedor.xaml
    /// </summary>
    public partial class Fornecedor : Window {
        private string opcao;
        private bool retorno = false;
        private Controle.EditaFornecedor editar = new Controle.EditaFornecedor();
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Gravar();
            tbcConsulta.IsEnabled = true;
            tbcCadastro.IsEnabled = false;
            tbcConsulta.IsSelected = true;
            Limpar();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            opcao = "Inserir";
            tbcCadastro.IsEnabled = true;
            tbcCadastro.IsSelected = true;
            tbcConsulta.IsEnabled = false;
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
            txbCNPJ.Text = "";
            txbEndereco.Text = "";
            ckbAtivo.IsChecked = true;
            txbPesquisar.Text = "";
        }

        private bool Verifica()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            if (txbCNPJ.Text == string.Empty)
            {
                MessageBox.Show("Campo CNPJ requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            if (txbEndereco.Text == string.Empty)
            {
                MessageBox.Show("Campo Endereço requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }

       /* public Produto getForn()
        {
            if (opcao == "Alterar"))
            {

            }
        }*/

        private void Gravar()
        {
            bool veri;
            veri = Verifica();
            if (veri == true)
            {
                if (opcao == "Inserir")
                {
                    fornecedores f = new fornecedores();
                   /* getForn();*/
                    if (editar.InsereFornecedor(f) == true)
                    {
                        retorno = true;
                    }
                }
                else if (opcao == "Alterar")
                {
                   
                    }
                }
            }
        }
    }
}
