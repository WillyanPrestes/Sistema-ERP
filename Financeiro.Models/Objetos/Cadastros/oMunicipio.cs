using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Cadastros
{
    [Table("Municipio")]
    public class oMunicipio
    {
        [Key]
        public int? _IdMunicipio { get; set; }
        [Required]
        public string? _Descricao { get; set; }
        public int? _IdEstado { get; set; }
        [ForeignKey("_IdEstado")]
        public oEstado? _Estado { get; set; }
    }
}
