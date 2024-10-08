namespace ProjetoAgenda
{
    partial class frm_Informacoes
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
            lbl_nome = new Label();
            txt_nome = new TextBox();
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            txt_telefone = new TextBox();
            lbl_telefone = new Label();
            txt_senha2 = new TextBox();
            lbl_senha_repetir = new Label();
            btn_cadastro = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(125, 44);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(74, 28);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            lbl_nome.Click += lbl_nome_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(125, 84);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(288, 40);
            txt_nome.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(125, 165);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(288, 40);
            txt_usuario.TabIndex = 3;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.White;
            lbl_usuario.Location = new Point(125, 125);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(89, 28);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "Usuário:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(125, 328);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(288, 40);
            txt_senha.TabIndex = 7;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = Color.White;
            lbl_senha.Location = new Point(125, 288);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(74, 28);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Senha:";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(125, 247);
            txt_telefone.Multiline = true;
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(288, 40);
            txt_telefone.TabIndex = 5;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.BackColor = Color.Transparent;
            lbl_telefone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.ForeColor = Color.White;
            lbl_telefone.Location = new Point(125, 207);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(98, 28);
            lbl_telefone.TabIndex = 4;
            lbl_telefone.Text = "Telefone:";
            // 
            // txt_senha2
            // 
            txt_senha2.Location = new Point(125, 409);
            txt_senha2.Multiline = true;
            txt_senha2.Name = "txt_senha2";
            txt_senha2.Size = new Size(288, 40);
            txt_senha2.TabIndex = 9;
            // 
            // lbl_senha_repetir
            // 
            lbl_senha_repetir.AutoSize = true;
            lbl_senha_repetir.BackColor = Color.Transparent;
            lbl_senha_repetir.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha_repetir.ForeColor = Color.White;
            lbl_senha_repetir.Location = new Point(125, 369);
            lbl_senha_repetir.Name = "lbl_senha_repetir";
            lbl_senha_repetir.Size = new Size(156, 28);
            lbl_senha_repetir.TabIndex = 8;
            lbl_senha_repetir.Text = "Repita a senha:";
            // 
            // btn_cadastro
            // 
            btn_cadastro.Location = new Point(125, 469);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(288, 51);
            btn_cadastro.TabIndex = 10;
            btn_cadastro.Text = "Cadastrar";
            btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(125, 526);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(288, 51);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_Informacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.tyler_foto_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 589);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_cadastro);
            Controls.Add(txt_senha2);
            Controls.Add(lbl_senha_repetir);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Name = "frm_Informacoes";
            Text = "frm_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
        private TextBox txt_telefone;
        private Label lbl_telefone;
        private TextBox txt_senha2;
        private Label lbl_senha_repetir;
        private Button btn_cadastro;
        private Button btn_cancelar;
    }
}