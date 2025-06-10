using Financeiro.Models.DataBase;
using Financeiro.Models.Interface;
using Financeiro.Models.Objetos.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oCategoriaProduto : _Base, inBaseObject<oCategoriaProduto>
    {
        [Key]
        public int _IdCategoriaProduto
        {
            get => GetValor<int>(nameof(_IdCategoriaProduto));
            set => SetValor(value, nameof(_IdCategoriaProduto));
        }
        [Required]
        public string _Descricao
        {
            get => GetValor<string>(nameof(_Descricao));
            set => SetValor(value, nameof(_Descricao));
        }


        public bool Deletar()
        {
            try
            {
                using (var db = new _Context())
                {
                    if (this._IdCategoriaProduto > 0)
                    {
                        db.Remove(this);
                        db.SaveChanges();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                msgErros = ex.InnerException?.Message ?? ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                msgErros = ex.Message;
                return false;
            }
            return true;
        }

        public bool Salvar()
        {
            try
            {
                using (var db = new _Context())
                {
                    if (this._IdCategoriaProduto <= 0)
                        db.dbCategoriaProduto.Add(this);
                    else
                        db.dbCategoriaProduto.Update(this);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                msgErros = ex.InnerException?.Message ?? ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                msgErros = ex.Message;
                return false;
            }
            return true;
        }

        public List<oCategoriaProduto> Buscar(Expression<Func<oCategoriaProduto, bool>> expression = null)
        {
            List<oCategoriaProduto> lst = new List<oCategoriaProduto>();
            using (var db = new _Context())
                lst = expression != null ? db.dbCategoriaProduto.Where(expression).ToList() : lst = db.dbCategoriaProduto.ToList();
            return lst;
        }
    }
}
