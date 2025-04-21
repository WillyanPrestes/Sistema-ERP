using Financeiro.Models.Objetos.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    public class oCliente
    {
        [Key]
        public int? _IdCliente { get; set; }
        public int? _IdPessoa { get; set; }
        [ForeignKey("_IdPessoa")]
        public oPessoa? _Pessoa { get; set; }
        [NotMapped]
        public List<oContasReceber>? _ContasReceber { get; set; }
    }
}
