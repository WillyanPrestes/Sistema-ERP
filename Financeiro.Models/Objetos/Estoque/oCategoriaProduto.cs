using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.DataBase;
using Financeiro.Models.Objetos.Base;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oCategoriaProduto:_Validacao,inBase<oCategoriaProduto>
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
            throw new NotImplementedException();
        }

        public List<oCategoriaProduto> Listar(Func<oCategoriaProduto, bool>? predicate)
        {
            _Context c = new _Context();
            if (predicate != null) 
               return c.dbCategoriaProduto.Where(predicate).ToList();

            return c.dbCategoriaProduto.ToList();
        }

        public bool Salvar(ref string erro)
        {
            try
            {
                _Context c = new _Context();
                c.Add(this);
                c.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                return false;
            }
        }
    }
}
