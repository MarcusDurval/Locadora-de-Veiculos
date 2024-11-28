namespace Locadora
{
    partial class Frm_locadora
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
            pb_imagem = new PictureBox();
            lbl_principal = new Label();
            tb_email = new TextBox();
            tb_password = new TextBox();
            btn_login = new Button();
            lbl_cadastro = new Label();
            lk_clique = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pb_imagem).BeginInit();
            SuspendLayout();
            // 
            // pb_imagem
            // 
            pb_imagem.Image = Properties.Resources.ganho_de_capital_venda_veiculo;
            pb_imagem.Location = new Point(12, 12);
            pb_imagem.Name = "pb_imagem";
            pb_imagem.Size = new Size(504, 426);
            pb_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imagem.TabIndex = 0;
            pb_imagem.TabStop = false;
            // 
            // lbl_principal
            // 
            lbl_principal.Font = new Font("Microsoft New Tai Lue", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_principal.ForeColor = Color.Gray;
            lbl_principal.Location = new Point(527, 12);
            lbl_principal.Name = "lbl_principal";
            lbl_principal.Size = new Size(257, 38);
            lbl_principal.TabIndex = 1;
            lbl_principal.Text = "SEJA BEM-VINDO";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(527, 109);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "E-mail";
            tb_email.Size = new Size(266, 23);
            tb_email.TabIndex = 2;
            tb_email.TextAlign = HorizontalAlignment.Center;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(527, 161);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "Password";
            tb_password.Size = new Size(266, 23);
            tb_password.TabIndex = 2;
            tb_password.TextAlign = HorizontalAlignment.Center;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Gray;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = SystemColors.Control;
            btn_login.Image = Properties.Resources.entrar;
            btn_login.Location = new Point(524, 399);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(266, 39);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.TextAlign = ContentAlignment.MiddleRight;
            btn_login.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_login.UseVisualStyleBackColor = false;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.ForeColor = Color.Gray;
            lbl_cadastro.Location = new Point(560, 349);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(138, 15);
            lbl_cadastro.TabIndex = 4;
            lbl_cadastro.Text = "Ainda não tem cadastro?";
            // 
            // lk_clique
            // 
            lk_clique.AutoSize = true;
            lk_clique.LinkColor = Color.Gray;
            lk_clique.Location = new Point(695, 349);
            lk_clique.Name = "lk_clique";
            lk_clique.Size = new Size(72, 15);
            lk_clique.TabIndex = 5;
            lk_clique.TabStop = true;
            lk_clique.Text = "Clique Aqui:";
            lk_clique.LinkClicked += lk_clique_LinkClicked;
            // 
            // Frm_locadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lk_clique);
            Controls.Add(lbl_cadastro);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(tb_email);
            Controls.Add(lbl_principal);
            Controls.Add(pb_imagem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_locadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pb_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_imagem;
        private Label lbl_principal;
        private TextBox tb_email;
        private TextBox tb_password;
        private Button btn_login;
        private Label lbl_cadastro;
        private LinkLabel lk_clique;
    }
}
