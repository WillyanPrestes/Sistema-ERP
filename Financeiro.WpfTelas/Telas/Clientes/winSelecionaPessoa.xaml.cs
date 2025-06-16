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
using Financeiro.Models.Objetos.Cadastros;

namespace Financeiro.WpfTelas.Telas.Clientes
{
    /// <summary>
    /// Lógica interna para winSelecionaPessoa.xaml
    /// </summary>
    public partial class winSelecionaPessoa : Window
    {
        public winSelecionaPessoa()
        {
            InitializeComponent();
            menuConfirma.btnConfirmar.Click += BtnConfirmar_Click;
            menuConfirma.btnSair.Click += BtnSair_Click;
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            winCadastroCliente win;
            if (rbFisica.IsChecked == true)
            {
                win = new winCadastroCliente(new oCliente(new oPessoaFisica()));
                win.ShowDialog();
            }
            else if (rbJuridica.IsChecked == true)
            {
                win = new winCadastroCliente(new oCliente(new oPessoaFisica()));
                win.ShowDialog();
            }
        }
    }
}
