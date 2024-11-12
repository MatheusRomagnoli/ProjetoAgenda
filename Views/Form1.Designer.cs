namespace ProjetoAgenda
{
    partial class frm_cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usuario = new TextBox();
            label1 = new Label();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            btn_cadastrar = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(117, 168);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(334, 47);
            txt_usuario.TabIndex = 0;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 29);
            label1.Name = "label1";
            label1.Size = new Size(138, 59);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 20F);
            lbl_usuario.Location = new Point(117, 114);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(114, 37);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 20F);
            lbl_senha.Location = new Point(117, 242);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(95, 37);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(117, 296);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(334, 47);
            txt_senha.TabIndex = 3;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Pink;
            btn_cadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Location = new Point(170, 485);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(215, 57);
            btn_cadastrar.TabIndex = 5;
            btn_cadastrar.Text = "logar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Pink;
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.Enabled = false;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Location = new Point(170, 422);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(215, 57);
            btn_login.TabIndex = 6;
            btn_login.Text = "cadastrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = Properties.Resources.tyler_foto;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(564, 577);
            Controls.Add(btn_login);
            Controls.Add(btn_cadastrar);
            Controls.Add(lbl_senha);
            Controls.Add(txt_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Name = "frm_cadastro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Label label1;
        private Label lbl_usuario;
        private Label lbl_senha;
        private TextBox txt_senha;
        private Button btn_cadastrar;
        private Button btn_login;
    }
}
