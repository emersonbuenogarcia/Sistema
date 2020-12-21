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
using Sistema.Controle;
using Sistema.Modelo;

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
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            try
            {
                usuario u = new usuario();
                u.usu_nome = txbUsuario.Text;
                u.usu_senha = hashbytes('md5', psbSenha.Password);
                if (LoginUsuario.Logar(u) == true)
                {
                    Principal principal = new Principal();
                    principal.IsEnabled = true;
                    principal.Show();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
