using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Objetos.Base;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oCategoriaProduto:_Validacao
    {
        [Key]
        public int _IdCategoriaProduto
        {
            get => GetValor<int>(nameof(_IdCategoriaProduto));
            set => SetValor(value, nameof(_IdCategoriaProduto));
        }
        [Required]
        public string _Descricao
        {
            get => GetValor<string>(nameof(_Descricao));
            set => SetValor(value, nameof(_Descricao));
        }
    }
}
