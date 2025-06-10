using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Financeiro.Models.Interface;
using Financeiro.Models.Objetos.Base;
using Financeiro.WpfTelas.UserControls.Menus;

namespace Financeiro.WpfTelas.Base
{
    public class oControllerMenuConsulta<L>
    {
        Window _window;
        DataGrid _dg;
        Type _TypeNovo;
        L _obj;
        public oControllerMenuConsulta(L obj,menuConsulta menu, Window window, DataGrid dg,Type typeNovo)
        {
            _obj = obj;
            _window = window;
            _dg = dg;
            _TypeNovo = typeNovo;
            menu.btnEditar.Click += BtnEditar_Click;
            menu.btnNovo.Click += BtnNovo_Click;
            menu.btnExcluir.Click += BtnExcluir_Click;
            menu.btnVisualizar.Visibility=Visibility.Collapsed;
            Atualizar();
        }


        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            L obj = (L)_dg.SelectedItem;
            if (obj != null)
            {
                var resultado = MessageBox.Show(
                     "Deseja realmente excluir o item?",
                     "Confirmação",
                     MessageBoxButton.YesNo,
                     MessageBoxImage.Question
                );
                if (resultado == MessageBoxResult.Yes)
                    if (obj is _Base ba)
                        if (obj is inBaseObject<L> inba)
                            if (inba.Deletar())
                            {
                                MessageBox.Show("Item excluido com Sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                                Atualizar();
                            }
                            else
                                MessageBox.Show("ERRO ao excluir o Item !\n" + ba.msgErros, "ERRO", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            //Type t = _obj.GetType();
            Window win = (Window)Activator.CreateInstance(this._TypeNovo,
                (L)Activator.CreateInstance(typeof(L)));
            win.ShowDialog();
            Atualizar();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            L obj = (L)_dg.SelectedItem;
            if (obj != null)
            {
                Window win = (Window)Activator.CreateInstance(this._TypeNovo, obj);
                win.ShowDialog();
                Atualizar();
            }
        }
        public void Atualizar(Expression<Func<L, bool>> expression=null)
        {
            if (_obj is inBaseObject<L> t)
                _dg.ItemsSource=t.Buscar(expression);
        }
    }
}
