using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oPessoaJuridica:oPessoa
    {
        [Required]
        public string? _RazaoSocial { get; set; }
        public string? _NomeFantasia { get; set; }
        public string? _CNPJ { get; set; }
        public string? _IE { get; set; }
    }
}
