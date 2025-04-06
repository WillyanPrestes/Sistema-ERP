using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oMunicipio
    {
        public int _IdMunicipio { get; set; }
        public string _Descricao { get; set; }
        public int _IdEstado { get; set; }
        public oEstado _Estado { get; set; }
    }
}
