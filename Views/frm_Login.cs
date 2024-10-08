using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ProjetoAgenda
{
    public partial class frm_Informacoes : Form
    {
        private void habilitar_texto()
        {
            if (txt_nome.Text != "" && txt_senha.Text.Length >= 8 && txt_senha.Text != "" && txt_usuario.Text != "" && txt_senha2.Text == txt_senha.Text)
            {
                btn_cadastro.Enabled = true;
            }
            else
            {
                btn_cadastro.Enabled = false;
            }
        }

        public frm_Informacoes()
        {
            InitializeComponent();
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server = 127.0.0.1;Database=dbAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(stringconexao);

            conexao.Open();

            string sql = $"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";
            
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
            comando.Parameters.AddWithValue("@senha", txt_senha.Text);

            comando.ExecuteNonQuery();

            conexao.Close(); 
        }
    }
}
