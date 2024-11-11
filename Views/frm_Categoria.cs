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
    public partial class frm_Categoria : Form
    {
        public frm_Categoria()
        {
            InitializeComponent();
            CategoriaController categoria = new CategoriaController();
            DataTable tabela = categoria.GetCategorias();
            dgv_categoria.DataSource = tabela;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(txt_categoria.Text);
            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada");
            }
            else
            {
                MessageBox.Show("Categoria não cadastrada");
            }

            
            
            
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_categoria.DataSource = tabela;

        }
    }
}
