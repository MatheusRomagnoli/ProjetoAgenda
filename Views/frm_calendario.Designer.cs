namespace ProjetoAgenda.Controller
{
    partial class frm_calendario
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
            cmbCategoria = new ComboBox();
            btn_cadastrar = new Button();
            btn_alterar = new Button();
            btn_excluir = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(25, 129);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(133, 23);
            cmbCategoria.TabIndex = 0;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(25, 171);
            btn_cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(82, 22);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(25, 210);
            btn_alterar.Margin = new Padding(3, 2, 3, 2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(82, 22);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(25, 247);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(82, 22);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 45);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 45);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 47);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "categorias:";
            // 
            // frm_calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_cadastrar);
            Controls.Add(cmbCategoria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_calendario";
            Text = "frm_calendario";
            Load += frm_calendario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategoria;
        private Button btn_cadastrar;
        private Button btn_alterar;
        private Button btn_excluir;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}