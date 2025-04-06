using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oProduto
    {
        public int _IdProduto { get; set; }
        public string _Descricao { get; set; }
        public decimal _PrecoCusto { get; set; }
        public decimal _MargemLucro { get; set; }
        public decimal _PrecoVenda { get; set; }
        public decimal _EstoqueAtual { get; set; }
        public decimal _EstoqueMinimo { get; set; }
        public string _UnidadeMedia { get; set; }
        public bool _Ativo { get; set; }
        public int _IdCategoriaProduto { get; set; }
        public oCategoriaProduto _CategoriaProduto { get; set; }
    }
}
