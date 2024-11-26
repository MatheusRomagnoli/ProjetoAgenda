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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void arwToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categoria formcategoria = new frm_Categoria();
            formcategoria.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listaUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuarios formUsuarios = new frm_Usuarios();
            formUsuarios.ShowDialog();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_calendario frmcalendario = new frm_calendario();
            frmcalendario.ShowDialog();
        }
    }
}
