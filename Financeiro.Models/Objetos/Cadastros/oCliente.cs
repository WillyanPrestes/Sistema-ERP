using Financeiro.Models.Interface;
using Financeiro.Models.Objetos.Base;
using Financeiro.Models.Objetos.Estoque;
using Financeiro.Models.Objetos.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oCliente : _Base, inBaseObject<oCliente>
    {
        [Key]
        public int? _IdCliente {
            get => GetValor<int>(nameof(_IdCliente));
            set => SetValor(value, nameof(_IdCliente));
        }
        public int? _IdPessoa
        {
            get => GetValor<int>(nameof(_IdPessoa));
            set => SetValor(value, nameof(_IdPessoa));
        }
        [ForeignKey("_IdPessoa")]
        public oPessoa? _Pessoa
        {
            get => GetValor<oPessoa>(nameof(_Pessoa));
            set => SetValor(value, nameof(_Pessoa));
        }
        [NotMapped]
        public List<oContasReceber>? _ContasReceber
        {
            get => GetValor<List<oContasReceber>>(nameof(_ContasReceber));
            set => SetValor(value, nameof(_ContasReceber));
        }

        public List<oCliente> Buscar(Expression<Func<oCliente, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
