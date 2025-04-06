using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oPessoa
    {
        public int _IdPessoa { get; set; }
        public string _Telefone { get; set; }
        public string _Celular { get; set; }
        public string _Logradouro { get; set; }
        public string _Bairro { get; set; }
        public string _Cep { get; set; }
        public string _Numero { get; set; }
        public string _Email { get; set; }
        public int _IdMunicipio { get; set; }
        public oMunicipio _Municipio { get; set; }
    }
}
