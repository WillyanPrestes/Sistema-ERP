using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Financeiro.WpfTelas.Telas;
using Financeiro.WpfTelas.Telas.Estoque;

namespace Financeiro.WpfTelas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastros_Click(object sender, RoutedEventArgs e)
        {
            spSubmenuCadastros.Visibility = spSubmenuCadastros.Visibility == Visibility.Visible
                                        ? Visibility.Collapsed
                                        : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            winConsultaProduto win = new winConsultaProduto();
            win.ShowDialog();
        }

        private void btnCategoriaProdutos_Click(object sender, RoutedEventArgs e)
        {
            winConsultaCategoriaProduto win = new winConsultaCategoriaProduto();
            win.ShowDialog();
            //winCadastroCategoriaProduto win =new winCadastroCategoriaProduto(new Models.Objetos.Estoque.oCategoriaProduto());
            //win.ShowDialog();
        }
    }
}