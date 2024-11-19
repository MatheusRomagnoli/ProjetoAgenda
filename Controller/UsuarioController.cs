using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using ProjetoAgenda.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                int linhasAfetadas = comando.ExecuteNonQuery();

                this.CriarUsuarioSQL(usuario, senha);

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }
            
        }

        public bool LogarUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = @"select * from tbUsuarios
                               WHERE nome = @usuario and BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        
        public bool ExcluirUsuario(string usuario)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();
                string sql = "DELETE from tbUsuarios WHERE usuario = @usuario;";
                
                conexao.Open();

                MySqlCommand comando = new MySqlCommand (sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public DataTable GetUsers()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "SELECT usuario, nome, telefone FROM tbUsuarios;";

                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar Usuários: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool AlterarSenha(string usuario, string senha)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "UPDATE tbUsuarios SET senha = (@senha) WHERE usuario = (@usuario);";

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool CriarUsuarioSQL(string usuario, string senha)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @$"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}'
                                GRANT select, insert, delete, update on dbagenda.* to '{usuario}'@'%';
                                FLUSH PRIVILEGES";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    
    }
}
