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

namespace Financeiro.WpfTelas.Telas.Estoque
{
    /// <summary>
    /// Lógica interna para winConsultaProduto.xaml
    /// </summary>
    public partial class winConsultaProduto : Window
    {
        private oControllerMenuConsulta<oProduto> con;

        public winConsultaProduto()
        {
            InitializeComponent(); 
            con = new oControllerMenuConsulta<oProduto>(new oProduto(), this.menuConsulta, this, this.dgt, typeof(winCadastroProduto));
        }

        public void Pesquisar()
        {
            con.Atualizar(c => c._Descricao.Contains(txtDescricao.Text));
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pesquisar();
        }
    }
}
