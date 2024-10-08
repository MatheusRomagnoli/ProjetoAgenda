using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
