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
    internal class CategoriaController
    {
        public bool AddCategoria(string nome_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();
                string sql = "INSERT INTO tb_categoria(nome_categoria) VALUES (@nome_categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome_categoria", nome_categoria);

                int linhasAfetadas = comando.ExecuteNonQuery();



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
                MessageBox.Show($"ERRO AO CADASTRAR CATEGORIA: {erro.Message}");
                return false;
            }
            finally 
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "SELECT cod_categoria AS 'Código', nome_categoria AS 'Categoria' FROM tb_categoria;";

                conexao.Open();

                //ao inves de usar o mysqlcomand eu vou usar o mysql adapter pois quero trabalhar
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //criei uma tabela vazia
                DataTable tabela = new DataTable();

                //o adaptador vai prencher a tabela com os dados
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro )
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
