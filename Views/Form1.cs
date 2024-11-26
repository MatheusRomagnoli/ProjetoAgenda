using ProjetoAgenda.Controller;
using ProjetoAgenda.VariableGlobal;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void habilitar_botao_login()
        {
            if (txt_usuario.Text != "" && txt_senha.Text.Length >= 8)
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            habilitar_botao_login();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            habilitar_botao_login();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario(txt_usuario.Text, txt_senha.Text);

            MessageBox.Show(resultado.ToString());

            if (resultado)
            {
                frm_Principal formPrincipal = new frm_Principal();
                formPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não foi possível efetuar o Login, o usuário já exsiste");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (btn_login.Enabled == true) 
            {
                frm_Informacoes forminfo = new frm_Informacoes();
                forminfo.ShowDialog();
            }
        }
    }
}
