using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frm_Usuarios : Form
    {
        public frm_Usuarios()
        {
            InitializeComponent();
            AtualizaDataGridUsuario();
        }

        private void AtualizaDataGridUsuario()
        {
            UsuarioController usuario = new UsuarioController();
            DataTable tabela = usuario.GetUsers();
            dgv_usuarios.DataSource = tabela;
        }

        private void btn_excluirUsuario_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.ExcluirUsuario(txt_usuarios.Text);
            
            if (resultado)
            {
                MessageBox.Show("excluido com sucesso");
            }
            else
            {
                MessageBox.Show("o usuário NÃO foi excluído com sucesso");
            }

            AtualizaDataGridUsuario();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
