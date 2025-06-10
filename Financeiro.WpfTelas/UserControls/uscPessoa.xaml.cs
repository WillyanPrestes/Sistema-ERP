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
using Financeiro.Models.Objetos.Cadastros;

namespace Financeiro.WpfTelas.UserControls
{
    /// <summary>
    /// Interação lógica para uscPessoa.xam
    /// </summary>
    public partial class uscPessoa : UserControl
    {
        public uscPessoa()
        {
            InitializeComponent();
            cmbEstado.ItemsSource = new oEstado().Buscar();
        }

        private void cmbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbEstado.SelectedIndex != -1)
                if (cmbEstado.SelectedItem != null)
                {
                    if (cmbEstado.SelectedItem is oEstado estado)
                    {
                        cmbEstado.SelectedIndex = -1;
                        cmbMunicipio.ItemsSource = new oMunicipio().Buscar(c => c._IdEstado == estado._IdEstado);
                    }
                }
        }
    }
}
