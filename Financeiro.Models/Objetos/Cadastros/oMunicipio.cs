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
    [Table("Municipio")]
    public class oMunicipio:_Base, inBaseObject<oMunicipio>
    {
        [Key]
        public int? _IdMunicipio
        {
            get => GetValor<int>(nameof(_IdMunicipio));
            set => SetValor(value, nameof(_IdMunicipio));
        }
        [Required]
        public string? _Descricao
        {
            get => GetValor<string>(nameof(_Descricao));
            set => SetValor(value, nameof(_Descricao));
        }
        public int? _IdEstado
        {
            get => GetValor<int>(nameof(_IdEstado));
            set => SetValor(value, nameof(_IdEstado));
        }
        [ForeignKey("_IdEstado")]
        [Required]
        public oEstado? _Estado
        {
            get => GetValor<oEstado>(nameof(_Estado));
            set => SetValor(value, nameof(_Estado));
        }

        public List<oMunicipio> Buscar(Expression<Func<oMunicipio, bool>> expression = null)
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
