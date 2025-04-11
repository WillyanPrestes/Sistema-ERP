using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    [Table("Estado")]
    public class oEstado
    {
        [Key]
        public int? _CodEstado { get; set; }
        [Required]
        public string? _Descricao { get; set; }
        [Required]
        public string? _Uf { get; set; }
    }
}
