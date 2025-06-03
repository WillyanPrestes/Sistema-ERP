using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Interface
{
    public interface inBaseObject<L>
    {
        public bool Salvar();
        public bool Deletar();
        public List<L> Buscar();
    }
}
