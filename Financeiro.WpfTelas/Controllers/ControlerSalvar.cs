using Financeiro.Models.Objetos.Base;
using Financeiro.WpfTelas.UserControls.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Financeiro.Models.Interface;

namespace Financeiro.WpfTelas.Controllers
{
    public class ControlerSalvar<L>
    {
        L _obj;
        Window _window;
        menuSalvar _menuSalvar;

        public ControlerSalvar(L obj,Window win, menuSalvar menu) 
        {
            _obj = obj;
            _window = win;
            _window.DataContext = _obj;
            _menuSalvar = menu;
            _menuSalvar.btnSair.Click += BtnSair_Click;
            _menuSalvar.btnSalvar.Click += BtnSalvar_Click;
            _window.KeyDown += _window_KeyDown;
        }

        private void _window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case System.Windows.Input.Key.F1:
                    Salvar();
                    break;
                case System.Windows.Input.Key.Escape:
                    _window.Close();
                    break;
            }
        }

        private void Salvar()
        {
            L ob = (L)_window.DataContext;
            if (ob is _Base validacao)
            {
                if (!validacao.HasErrors)
                    if (ob is inBaseObject<L> ba)
                    {
                        if (ba.Salvar())
                        {
                            MessageBox.Show("Salvo com Sucesso!", "Salvo", MessageBoxButton.OK, MessageBoxImage.Information);
                            _window.Close();
                        }
                        else
                            MessageBox.Show("ERRO ao Salvar, verifique os erros!\n" + validacao.retornoErroValidacao(), "ERRO ao Salvar", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
            }
        }
        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Salvar();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            _window.Close();
        }
    }
}
