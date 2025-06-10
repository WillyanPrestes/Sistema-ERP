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
using Financeiro.Models.Objetos.Estoque;

namespace Financeiro.WpfTelas.UserControls
{
    /// <summary>
    /// Interação lógica para uscCadastroProduto.xam
    /// </summary>
    public partial class uscCadastroProduto : UserControl
    {
        public uscCadastroProduto()
        {
            InitializeComponent();
            cmbCategoria.ItemsSource = new oCategoriaProduto().Buscar();
        }

    }
}
