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
using Financeiro.WpfTelas.Controllers;
using Financeiro.WpfTelas.UserControls.Menus;

namespace Financeiro.WpfTelas.Telas.Estoque
{
    /// <summary>
    /// Lógica interna para winCadastroProduto.xaml
    /// </summary>
    public partial class winCadastroProduto : Window
    {
        public winCadastroProduto(oProduto cat)
        {
            InitializeComponent();
            new ControlerSalvar<oProduto>(cat, this, menuSalvar);
            this.uscdastroProduto.cmbCategoria.SelectedIndex = 0;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            oProduto cat = (oProduto)DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            oProduto cat = (oProduto)DataContext;
            if (cat._IdProduto>0&&cat._IdCategoriaProduto>0)
                this.uscdastroProduto.cmbCategoria.SelectedValuePath ="" + cat._IdCategoriaProduto;
            //this.uscdastroProduto.cmbCategoria.SelectedValue = cat._CategoriaProduto;
        }
    }
}
