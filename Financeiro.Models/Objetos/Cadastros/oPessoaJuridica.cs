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
        public string? _RazaoSocial
        {
            get => GetValor<string>(nameof(_RazaoSocial));
            set => SetValor(value, nameof(_RazaoSocial));
        }
        public string? _NomeFantasia
        {
            get => GetValor<string>(nameof(_NomeFantasia));
            set => SetValor(value, nameof(_NomeFantasia));
        }
        public string? _CNPJ
        {
            get => GetValor<string>(nameof(_CNPJ));
            set => SetValor(value, nameof(_CNPJ));
        }
        public string? _IE
        {
            get => GetValor<string>(nameof(_IE));
            set => SetValor(value, nameof(_IE));
        }
    }
}
