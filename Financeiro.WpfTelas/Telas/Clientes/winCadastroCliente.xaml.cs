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
using Financeiro.Models.Objetos.Estoque;
using Financeiro.WpfTelas.Controllers;
using Financeiro.WpfTelas.UserControls.Menus;

namespace Financeiro.WpfTelas.Telas.Clientes
{
    /// <summary>
    /// Lógica interna para winCadastroCliente.xaml
    /// </summary>
    public partial class winCadastroCliente : Window
    {
        public winCadastroCliente(oCliente cliente)
        {
            InitializeComponent();
            new ControlerSalvar<oCliente>(cliente, this, menuSalvar);
        }
    }
}
