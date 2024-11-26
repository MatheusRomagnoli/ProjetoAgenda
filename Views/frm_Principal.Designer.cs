namespace ProjetoAgenda.Views
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arwToolStripMenuItem = new ToolStripMenuItem();
            qToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            listaUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arwToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(640, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arwToolStripMenuItem
            // 
            arwToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { qToolStripMenuItem });
            arwToolStripMenuItem.Name = "arwToolStripMenuItem";
            arwToolStripMenuItem.Size = new Size(75, 24);
            arwToolStripMenuItem.Text = "Arquivo";
            arwToolStripMenuItem.Click += arwToolStripMenuItem_Click;
            // 
            // qToolStripMenuItem
            // 
            qToolStripMenuItem.Name = "qToolStripMenuItem";
            qToolStripMenuItem.Size = new Size(117, 26);
            qToolStripMenuItem.Text = "Sair";
            qToolStripMenuItem.Click += qToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, usuáriosToolStripMenuItem, agendaToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(224, 26);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(224, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaUsuáriosToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(224, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // listaUsuáriosToolStripMenuItem
            // 
            listaUsuáriosToolStripMenuItem.Name = "listaUsuáriosToolStripMenuItem";
            listaUsuáriosToolStripMenuItem.Size = new Size(182, 26);
            listaUsuáriosToolStripMenuItem.Text = "Lista Usuários";
            listaUsuáriosToolStripMenuItem.Click += listaUsuáriosToolStripMenuItem_Click;
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(224, 26);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frm_Principal";
            Text = "frm_Principal";
            Load += frm_Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arwToolStripMenuItem;
        private ToolStripMenuItem qToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem listaUsuáriosToolStripMenuItem;
        private ToolStripMenuItem agendaToolStripMenuItem;
    }
}