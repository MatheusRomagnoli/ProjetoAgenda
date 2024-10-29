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
using ProjetoAgenda.Controller;
using ProjetoAgenda.data;

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
            string nome = txt_nome.Text;
            string usuario = txt_usuario.Text;
            string telefone = txt_telefone.Text;
            string senha = txt_senha.Text;
            
            UsuarioController controleUsuario = new UsuarioController();
            
            bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);
            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
        }
    }
}
