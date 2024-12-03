using MySql.Data.MySqlClient;
using ProjetoAgenda.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public DataTable GetContatos()
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();
        }
    }
}
