using Financeiro.Models.Objetos.Cadastros;
using Financeiro.Models.Objetos.Saida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Financeiro
{
    public class oContasReceber
    {
        public int _IdContasReceber { get; set; }
        public string _Descricao { get; set; }
        public DateTimeOffset _DataConta { get; set; }
        public DateTimeOffset _DataRecebimento { get; set; }
        public DateTimeOffset _DataVencimento { get; set; }
        public decimal _ValorTotal  { get; set; }
        public bool _Recebido { get; set; }
        public int _IdCliente { get; set; }
        public oCliente _Cliente { get; set; }
        public int? _IdVenda { get; set; }
        public oVenda? _Venda { get; set; }
    }
}
