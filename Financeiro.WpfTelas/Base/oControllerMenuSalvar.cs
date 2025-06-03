using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Financeiro.Models.Objetos.Base;
using Financeiro.WpfTelas.UserControls.Menus;

namespace Financeiro.WpfTelas.Base
{
    public class oControllerMenuSalvar<L>
    {
        Window _win;
        public oControllerMenuSalvar(L obj, menuSalvar menuSalvar, Window win)
        {
            _win = win;
            _win.DataContext = obj;
            menuSalvar.btnSair.Click += BtnSair_Click;
            menuSalvar.btnSalvar.Click += BtnSalvar_Click;
        }

        private void BtnSalvar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                string erro = "";
                L _obj = (L)_win.DataContext;
                if (_obj != null)
                    if (_obj is inBase<L> basee)
                        if (basee.Salvar(ref erro))
                        {
                            MessageBox.Show("Salvo com Sucesso", "Salvo", MessageBoxButton.OK, MessageBoxImage.Information);
                            _win.Close();
                        }
                        else
                            MessageBox.Show("Erro ao Salvar, verifique os erros.\n"+erro, "ERRO", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar! \n" + ex.Message, "ERRO", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnSair_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _win.Close();           
        }
    }
}
