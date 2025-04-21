using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oProduto
    {
        [Key]
        public int? _IdProduto { get; set; }
        [Required]
        public string? _Descricao { get; set; }
        [Required]
        public decimal? _Custo { get; set; }
        [Required]
        public decimal? _MargemLucro { get; set; }
        [Required]
        public decimal? _PrecoVenda { get; set; }
        [Required]
        public decimal? _EstoqueAtual { get; set; }
        [Required]
        public decimal? _EstoqueMinimo { get; set; }
        [Required]
        public string? _UnidadeMedida { get; set; }
        [Required]
        public bool? _Ativo { get; set; }
        [Required]
        public int? _IdCategoriaProduto { get; set; }
        [ForeignKey("_IdCategoriaProduto")]
        public oCategoriaProduto? _CategoriaProduto { get; set; }
    }
}
