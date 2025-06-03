using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Objetos.Estoque;

namespace Financeiro.Models.Objetos.Base
{
    public interface inBase<L>
    {
        public bool Salvar(ref string erro);
        public bool Deletar();
        public List<L> Listar(Func<L, bool>? predicate);
    }
}
