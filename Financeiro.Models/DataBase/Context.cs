using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Models.Objetos;
using Financeiro.Models.Objetos.Cadastros;
using Financeiro.Models.Objetos.Estoque;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Models.DataBase
{
    public class Context :DbContext
    {
        public DbSet<oMunicipio> dbMunicipio { get; set; }
        public DbSet<oEstado> dbEstado { get; set; }
        public DbSet<oPessoa> dbPessoa { get; set; }
        public DbSet<oPessoaFisica> dbPessoaFisica { get; set; }
        public DbSet<oPessoaJuridica> dbPessoaJuridica { get; set; }
        public DbSet<oCliente> dbCliente { get; set; }
        public DbSet<oProduto> dbProduto { get; set; }
        public DbSet<oCategoriaProduto> dbCategoriaProduto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;database=dbFinanceiro;password=32962377");
        }
    }
}
