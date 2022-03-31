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

namespace ProjetoDeCalculadora
{
	/// <summary>
	/// Interação lógica para MainWindow.xam
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void btAcessar_Click(object sender, RoutedEventArgs e)
        {

            string senha = textSenha.Password.ToString();
            string user = textUsuario.Text;

            if (user == "Lohainy" & senha == "1234")
            {
                MessageBox.Show("Logado!");
                textUsuario.Clear();
                textSenha.Clear();
                Calculadora calculadora = new Calculadora();
                calculadora.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
                textUsuario.Clear();
                textSenha.Clear();
            }
        }
	}
}
