using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oCategoriaProduto
    {
        [Key]
        public int _IdCategoriaProduto { get; set; }
        [Required]
        public string _Descricao { get; set; }
    }
}
