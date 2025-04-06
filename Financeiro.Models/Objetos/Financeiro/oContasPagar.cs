using Financeiro.Models.Objetos.Cadastros;
using Financeiro.Models.Objetos.Entrada;
using Financeiro.Models.Objetos.Saida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Financeiro
{
    public class oContasPagar
    {
        public int _IdContasPaga { get; set; }
        public string _Descricao { get; set; }
        public DateTimeOffset _DataConta { get; set; }
        public DateTimeOffset _DataPagamento { get; set; }
        public DateTimeOffset _DataVencimento { get; set; }
        public decimal _ValorTotal { get; set; }
        public bool _Pago { get; set; }
        public int _IdFornecedor { get; set; }
        public oFornecedor  _Fornecedor { get; set; }
        public int? _IdCompra { get; set; }
        public oCompra? _Compra { get; set; }
    }
}
