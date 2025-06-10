using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Objetos.Base;

namespace Financeiro.Models.Objetos.Cadastros
{
    public abstract class oPessoa: _Base
    {
        [Key]
        public int? _IdPessoa
        {
            get => GetValor<int>(nameof(_IdPessoa));
            set => SetValor(value, nameof(_IdPessoa));
        }
        public string? _Telefone
        {
            get => GetValor<string>(nameof(_Telefone));
            set => SetValor(value, nameof(_Telefone));
        }
        public string? _Celular
        {
            get => GetValor<string>(nameof(_Celular));
            set => SetValor(value, nameof(_Celular)); }
        public string? _Logradouro
        {
            get => GetValor<string>(nameof(_Logradouro));
            set => SetValor(value, nameof(_Logradouro));
        }
        public string? _Bairro
        {
            get => GetValor<string>(nameof(_Bairro));
            set => SetValor(value, nameof(_Bairro));
        }
        public string? _Cep
        {
            get => GetValor<string>(nameof(_Cep));
            set => SetValor(value, nameof(_Cep));
        }
        public string? _Numero
        {
            get => GetValor<string>(nameof(_Numero));
            set => SetValor(value, nameof(_Numero));
        }
        public string? _Email
        {
            get => GetValor<string>(nameof(_Email));
            set => SetValor(value, nameof(_Email));
        }
        [Required]
        public int? _IdMunicipio
        {
            get => GetValor<int>(nameof(_IdMunicipio));
            set => SetValor(value, nameof(_IdMunicipio));
        }
        [ForeignKey("_IdMunicipio")]
        [Required]
        public oMunicipio? _Municipio
        {
            get => GetValor<oMunicipio>(nameof(_Municipio));
            set => SetValor(value, nameof(_Municipio));
        }
    }
}
