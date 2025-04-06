using Financeiro.Models.Objetos.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Entrada
{
    public class oCompraItem
    {
        public int _IdCompra { get; set; }
        public int _IdProduto { get; set; }
        public oProduto _Produto { get; set; }
        public decimal _Qtd { get; set; }
        public decimal _PrecoUnitario { get; set; }
        public decimal _ValorTotal { get; set; }
    }
}
