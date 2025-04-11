using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public abstract class oPessoa
    {
        [Key]
        public int _IdPessoa { get; set; }
        public string _Telefone { get; set; }
        public string _Celular { get; set; }
        public string _Logradouro { get; set; }
        public string _Bairro { get; set; }
        public string _Cep { get; set; }
        public string _Numero { get; set; }
        public string _Email { get; set; }
        public int _IdMunicipio { get; set; }
        [ForeignKey("_IdMunicipio")]
        public oMunicipio _Municipio { get; set; }
    }
}
