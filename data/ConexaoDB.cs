using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.data
{
    static public class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            string stringconexao = "Server = 127.0.0.1;Database=dbAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(stringconexao);
            return conexao;
        }

        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            string stringconexao = $"Server = 127.0.0.1;Database=dbAgenda;User ID='{usuario}';Password='{senha}';";
            MySqlConnection conexao = new MySqlConnection(stringconexao);
            return conexao;
        }
    }
}
