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
using System.Data.SqlClient;

namespace Sistema.Visao {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source =.; Initial Catalog = bdsistema; Persist Security Info = True; User ID = sa; Password = 123456");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed);
                sqlCon.Open();
                String query = "SELECT COUNT(1) FROM USUARIOS WHERE USU_NOME =@usuario and USU_SENHA =@senha";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@usuario", txbUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", psbSenha.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    String logado = "";
                    Principal principal = new Principal();
                    logado = txbUsuario.Text;
                    principal.lblLogado.Content = logado;
                    principal.Show(); 
                    this.Close();
                }
                else
                { 
                    MessageBox.Show("Usuário ou senha incorreto!", "Informação", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
