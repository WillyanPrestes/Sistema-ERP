using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oPessoaFisica : oPessoa
    {
        public string _Nome { get; set; }
        public string _Apelido { get; set; }
        public string _CPF { get; set; }
    }
}
