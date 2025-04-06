using Financeiro.Models.Objetos.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Entrada
{
    public class oCompra
    {
        public int _IdCompra { get; set; }
        public DateTimeOffset _DataCompra { get; set; }
        public decimal _ValorTotal { get; set; }
        public string _Observacoes { get; set; }
        public List<oCompraItem> _CompraItens { get; set; }
        public int _IdFornecedor { get; set; }
        public oFornecedor _Fornecedor { get; set; }
    }
}
