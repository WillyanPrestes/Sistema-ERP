using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.DataBase;
using Financeiro.Models.Interface;
using Financeiro.Models.Objetos.Base;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Models.Objetos.Estoque
{
    public class oProduto : _Base, inBaseObject<oProduto>
    {
        [Key]
        public int _IdProduto
        {
            get => GetValor<int>(nameof(_IdProduto));
            set => SetValor(value, nameof(_IdProduto));
        }
        [Required]
        public string _Descricao
        {
            get => GetValor<string>(nameof(_Descricao));
            set => SetValor(value, nameof(_Descricao));
        }
        [Required]
        public decimal _Custo
        {
            get => GetValor<decimal>(nameof(_Custo));
            set => SetValor(value, nameof(_Custo));
        }
        [Required]
        public decimal _MargemLucro
        {
            get => GetValor<decimal>(nameof(_MargemLucro));
            set => SetValor(value, nameof(_MargemLucro));
        }
        [Required]
        public decimal _PrecoVenda
        {
            get => GetValor<decimal>(nameof(_PrecoVenda));
            set => SetValor(value, nameof(_PrecoVenda));
        }
        [Required]
        public decimal _EstoqueAtual
        {
            get => GetValor<decimal>(nameof(_EstoqueAtual));
            set => SetValor(value, nameof(_EstoqueAtual));
        }
        [Required]
        public decimal _EstoqueMinimo
        {
            get => GetValor<decimal>(nameof(_EstoqueMinimo));
            set => SetValor(value, nameof(_EstoqueMinimo));
        }
        [Required]
        public string _UnidadeMedida
        {
            get => GetValor<string>(nameof(_UnidadeMedida));
            set => SetValor(value, nameof(_UnidadeMedida));
        }
        [Required]
        public bool _Ativo
        {
            get => GetValor<bool>(nameof(_Ativo));
            set => SetValor(value, nameof(_Ativo));
        }
        [Required]
        public int _IdCategoriaProduto
        {
            get => GetValor<int>(nameof(_IdCategoriaProduto));
            set => SetValor(value, nameof(_IdCategoriaProduto));
        }
        [ForeignKey("_IdCategoriaProduto")]
        public oCategoriaProduto _CategoriaProduto
        {
            get => GetValor<oCategoriaProduto>(nameof(_CategoriaProduto));
            set => SetValor(value, nameof(_CategoriaProduto));
        }

        public bool Deletar()
        {
            try
            {
                using (var db = new _Context())
                {
                    if (this._IdProduto > 0)
                    {
                        db.Remove(this);
                        db.SaveChanges();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                msgErros = ex.InnerException?.Message ?? ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                msgErros = ex.Message;
                return false;
            }
            return true;
        }

        public bool Salvar()
        {
            try
            {
                using (var db = new _Context())
                {
                    // Marcar a categoria como existente (caso esteja preenchida)
                    if (this._CategoriaProduto != null)
                    {
                        this._IdCategoriaProduto = this._CategoriaProduto._IdCategoriaProduto;
                        db.Entry(this._CategoriaProduto).State = EntityState.Unchanged;
                    }
                    // Inserção ou atualização
                    if (this._IdProduto <= 0)
                    {
                        //db.Entry(this).State = EntityState.Added;
                        db.dbProduto.Add(this);
                    }
                    else
                        db.dbProduto.Update(this);

                    

                    db.SaveChanges();

                    // Reseta o ID após salvar para evitar problemas futuros
                    this._IdProduto = 0;
                }
            }
            catch (DbUpdateException ex)
            {
                this._IdProduto = 0;
                msgErros = ex.InnerException?.Message ?? ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this._IdProduto = 0;
                msgErros = ex.Message;
                return false;
            }

            return true;
        }

        public List<oProduto> Buscar(Expression<Func<oProduto, bool>> expression = null)
        {
            List<oProduto> lst = new List<oProduto>();
            using (var db = new _Context())
                lst = expression != null ? db.dbProduto.Include(c=>c._CategoriaProduto).Where(expression).ToList() : lst = db.dbProduto.Include(c => c._CategoriaProduto).ToList();
            return lst;
        }
    }
}
