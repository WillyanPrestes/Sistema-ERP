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
using Financeiro.Models.Objetos.Estoque;
using Financeiro.WpfTelas.Base;

namespace Financeiro.WpfTelas.Telas
{
    /// <summary>
    /// Lógica interna para winCadastroCategoriaProduto.xaml
    /// </summary>
    public partial class winCadastroCategoriaProduto : Window
    {
        public winCadastroCategoriaProduto(oCategoriaProduto cat)
        {
            InitializeComponent();
            oControllerMenuSalvar<oCategoriaProduto> con = new oControllerMenuSalvar<oCategoriaProduto>
                (cat, this.menuSalvar, this);
        }
    }
}
