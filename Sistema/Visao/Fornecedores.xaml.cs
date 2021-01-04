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
using Sistema.Controle;

namespace Sistema.Visao {
    /// <summary>
    /// Interaction logic for Fornecedores.xaml
    /// </summary>
    public partial class Fornecedores : Window {
        private string opcao;
        private bool retorno = false;
        private int a;
        private EditarFornecedor editar = new EditarFornecedor();
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

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

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Gravar();
        }

        private void TxbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txbCNPJ_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListarFornecedores();
        }

        private void Gravar()
        {
            bool veri;
            veri = Verifica();
            if (veri == true)
            {
                if (opcao == "Inserir")
                {
                    fornecedore f = new fornecedore();
                    f.for_nome = txbNome.Text;
                    f.for_endereco = txbEndereco.Text;
                    if (ckbAtivo.IsChecked == true)
                    {
                        f.for_ativo = char.ToString('1');
                    }
                    else
                    {
                        f.for_ativo = char.ToString('0');
                    }
                    if (editar.InserirFornecedor(f) == true)
                    {
                        retorno = true;
                    }
                }
                else if (opcao == "Alterar")
                {


                }
                tbcConsulta.IsEnabled = true;
                tbcCadastro.IsEnabled = false;
                tbcConsulta.IsSelected = true;
                Limpar();
                ListarFornecedores();
            }
            else
            {


            }
        }

        private bool Verifica()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                txbNome.Focus();
                return false;
            }
            if (txbCNPJ.Text == string.Empty)
            {
                MessageBox.Show("Campo CNPJ requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                txbCNPJ.Focus();
                return false;
            }
            if (txbEndereco.Text == string.Empty)
            {
                MessageBox.Show("Campo Endereço requerido!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                txbEndereco.Focus();
                return false;
            }
            return true;
        }

        private void ListarFornecedores()
        {
            using (bdsistemaEntities ctx = new bdsistemaEntities())
            {
                var consulta = ctx.fornecedores;
                dtgFornecedor.ItemsSource = consulta.ToList();
            }
        }

        private void BuscarPesquisa()
        {

        }

        private void txbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                BuscarPesquisa();
            }
        }

        private void TxbCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if (e.Key == Key.Tab) return;
            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void Limpar()
        {
            txbNome.Text = "";
            txbCNPJ.Text = "";
            txbEndereco.Text = "";
            ckbAtivo.IsChecked = true;
            txbPesquisar.Text = "";
        }
    }
}
