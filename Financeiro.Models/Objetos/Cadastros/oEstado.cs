using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Interface;
using Financeiro.Models.Objetos.Base;

namespace Financeiro.Models.Objetos.Cadastros
{
    [Table("Estado")]
    public class oEstado: _Base, inBaseObject<oEstado>
    {
        [Key]
        public int? _IdEstado
        {
            get => GetValor<int>(nameof(_IdEstado));
            set => SetValor(value, nameof(_IdEstado));
        }
        [Required]
        public string? _Descricao
        {
            get => GetValor<string>(nameof(_Descricao));
            set => SetValor(value, nameof(_Descricao));
        }
        [Required]
        public string? _Uf
        {
            get => GetValor<string>(nameof(_Uf));
            set => SetValor(value, nameof(_Uf));
        }

        public List<oEstado> Buscar(Expression<Func<oEstado, bool>> expression = null)
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
