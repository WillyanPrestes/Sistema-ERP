using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos
{
    public static class _Config
    {
        public static string _StringConexao
        {
            get{ return ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString; }
        }
    }
}
