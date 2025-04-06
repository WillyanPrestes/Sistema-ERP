using Financeiro.Models.Objetos.Cadastros;
using Financeiro.Models.Objetos.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Saida
{
    public class oVenda
    {
        public int _IdVenda { get; set; }
        public DateTimeOffset _DataVenda { get; set; }
        public decimal _ValorTotal { get; set; }
        public string _Observacoes { get; set; }
        public int _IdCliente { get; set; }
        public oCliente _Cliente { get; set; }
        public List<oVendaItem> _VendaItens { get; set; }
    }
}
