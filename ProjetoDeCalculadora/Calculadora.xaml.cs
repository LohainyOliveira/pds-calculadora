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

namespace ProjetoDeCalculadora
{
	/// <summary>
	/// Lógica interna para Calculadora.xaml
	/// </summary>
	public partial class Calculadora : Window
	{
		public Calculadora()
		{
			InitializeComponent();
		}

		private void btSomar_Click(object sender, RoutedEventArgs e)
		{
			double numeroUm = Convert.ToDouble(textNumeroUm.Text);
			double numeroDois = Convert.ToDouble(textNumeroDois.Text);

			double resultado = numeroUm + numeroDois;
			textResultado.Text = Convert.ToString(resultado);
		}

		private void btSubtrair_Click(object sender, RoutedEventArgs e)
		{
			double numeroUm = Convert.ToDouble(textNumeroUm.Text);
			double numeroDois = Convert.ToDouble(textNumeroDois.Text);

			double resultado = numeroUm - numeroDois;
			textResultado.Text = Convert.ToString(resultado);
		}

		private void btDividir_Click(object sender, RoutedEventArgs e)
		{
			double numeroUm = Convert.ToDouble(textNumeroUm.Text);
			double numeroDois = Convert.ToDouble(textNumeroDois.Text);

			double resultado = numeroUm / numeroDois;
			textResultado.Text = Convert.ToString(resultado);
		}

		private void btMultiplicar_Click(object sender, RoutedEventArgs e)
		{
			double numeroUm = Convert.ToDouble(textNumeroUm.Text);
			double numeroDois = Convert.ToDouble(textNumeroDois.Text);

			double resultado = numeroUm * numeroDois;
			textResultado.Text = Convert.ToString(resultado);
		}
	}
}
