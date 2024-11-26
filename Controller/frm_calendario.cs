using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Controller
{
    public partial class frm_calendario : Form
    {
        public frm_calendario()
        {
            InitializeComponent();
        }

        private void frm_calendario_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            cmbCategoria.DataSource = tabela;
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.DisplayMember = "cod_categoria";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
