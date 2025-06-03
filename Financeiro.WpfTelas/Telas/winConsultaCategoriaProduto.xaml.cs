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
using Financeiro.WpfTelas.Interface;

namespace Financeiro.WpfTelas.Telas
{
    /// <summary>
    /// Lógica interna para winConsultaCategoriaProduto.xaml
    /// </summary>
    public partial class winConsultaCategoriaProduto : Window,inConsulta
    {
        oControllerMenuConsulta<oCategoriaProduto> con;
        public winConsultaCategoriaProduto()
        {
            InitializeComponent();
            con=new oControllerMenuConsulta<oCategoriaProduto>(menuConsulta,this,dgt);
        }

        public void Pesquisar()
        {
            if(text)
            oCategoriaProduto categoriaProduto = new oCategoriaProduto();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pesquisar();
        }
    }
}
