using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oFuncionario
    {
        public int _IdFornecedor { get; set; }
        public int _IdPessoa { get; set; }
        public oPessoa _Pessoa { get; set; }
        public decimal _Salario { get; set; }
        public bool _Ativo { get; set; }
    }
}
