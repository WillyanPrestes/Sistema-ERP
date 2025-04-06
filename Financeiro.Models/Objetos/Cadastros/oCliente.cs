using Financeiro.Models.Objetos.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oCliente
    {
        public int _IdCliente { get; set; }
        public int _IdPessoa { get; set; }
        public oPessoa _Pessoa { get; set; }
        public List<oContasReceber>? _ContasReceber { get; set; }
    }
}
