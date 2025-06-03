using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Financeiro.Models.Objetos.Base;
using Financeiro.WpfTelas.UserControls.Menus;

namespace Financeiro.WpfTelas.Base
{
    public class oControllerMenuConsulta<L>
    {
        Window _window;
        DataGrid _dg;
        L _obj;
        public oControllerMenuConsulta(L obj,menuConsulta menu, Window window, DataGrid dg)
        {
            _obj = obj;
            menu.btnEditar.Click += BtnEditar_Click;
            menu.btnNovo.Click += BtnNovo_Click;
            menu.btnExcluir.Click += BtnExcluir_Click;
            menu.btnVisualizar.Click += BtnVisualizar_Click;
        }

        private void BtnVisualizar_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Atualizar(Expression<Func<L, bool>> expression)
        {
            if (_obj is inBase<L>)
            {
                _obj.
            }
            _dg.DataContext=
        }
    }
}
