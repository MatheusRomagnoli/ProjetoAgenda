﻿namespace ProjetoAgenda.Views
{
    partial class frm_Usuarios
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
            dgv_usuarios = new DataGridView();
            btn_excluirUsuario = new Button();
            groupBox1 = new GroupBox();
            txt_usuarios = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_usuarios
            // 
            dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuarios.Location = new Point(293, 12);
            dgv_usuarios.Name = "dgv_usuarios";
            dgv_usuarios.Size = new Size(386, 220);
            dgv_usuarios.TabIndex = 0;
            // 
            // btn_excluirUsuario
            // 
            btn_excluirUsuario.Location = new Point(6, 81);
            btn_excluirUsuario.Name = "btn_excluirUsuario";
            btn_excluirUsuario.Size = new Size(246, 43);
            btn_excluirUsuario.TabIndex = 1;
            btn_excluirUsuario.Text = "Excluir Usuário";
            btn_excluirUsuario.UseVisualStyleBackColor = true;
            btn_excluirUsuario.Click += btn_excluirUsuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_usuarios);
            groupBox1.Controls.Add(btn_excluirUsuario);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 139);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Digite o usuário que deseja excluir";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txt_usuarios
            // 
            txt_usuarios.Location = new Point(6, 22);
            txt_usuarios.Multiline = true;
            txt_usuarios.Name = "txt_usuarios";
            txt_usuarios.Size = new Size(246, 41);
            txt_usuarios.TabIndex = 0;
            // 
            // frm_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 253);
            Controls.Add(groupBox1);
            Controls.Add(dgv_usuarios);
            Name = "frm_Usuarios";
            Text = "frm_Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_usuarios;
        private Button btn_excluirUsuario;
        private GroupBox groupBox1;
        private TextBox txt_usuarios;
    }
}