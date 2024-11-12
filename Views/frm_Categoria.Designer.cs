namespace ProjetoAgenda.Views
{
    partial class frm_Categoria
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
            groupBox1 = new GroupBox();
            btn_excluir = new Button();
            btn_cadastrar = new Button();
            txt_categoria = new TextBox();
            dgv_categoria = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txt_categoria);
            groupBox1.Location = new Point(31, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "insira o nome da nova categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(6, 100);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(207, 34);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(6, 60);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(207, 34);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += Cadastrar_Click;
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(6, 22);
            txt_categoria.Multiline = true;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(207, 32);
            txt_categoria.TabIndex = 0;
            // 
            // dgv_categoria
            // 
            dgv_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoria.Location = new Point(287, 17);
            dgv_categoria.Name = "dgv_categoria";
            dgv_categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_categoria.Size = new Size(331, 148);
            dgv_categoria.TabIndex = 1;
            dgv_categoria.CellContentClick += dgv_categoria_CellContentClick;
            // 
            // frm_Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 189);
            Controls.Add(dgv_categoria);
            Controls.Add(groupBox1);
            Name = "frm_Categoria";
            Text = "frm_Categoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cadastrar;
        private TextBox txt_categoria;
        private DataGridView dgv_categoria;
        private Button btn_excluir;
    }
}