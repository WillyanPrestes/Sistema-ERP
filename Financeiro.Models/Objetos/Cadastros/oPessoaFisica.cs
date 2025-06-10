using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Objetos.Base;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oPessoaFisica : oPessoa
    {
        [Required]
        public string? _Nome
        {
            get => GetValor<string>(nameof(_Nome));
            set => SetValor(value, nameof(_Nome)); }
        public string? _Apelido
        {
            get => GetValor<string>(nameof(_Apelido));
            set => SetValor(value, nameof(_Apelido));
        }
        public string? _CPF
        {
            get => GetValor<string>(nameof(_CPF));
            set => SetValor(value, nameof(_CPF));
        }
    }
}
