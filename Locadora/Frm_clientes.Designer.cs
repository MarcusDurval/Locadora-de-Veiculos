namespace Locadora
{
    partial class Frm_clientes
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
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_salvar = new ToolStripButton();
            label1 = new Label();
            tb_id = new TextBox();
            label2 = new Label();
            tb_nome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_bairro = new TextBox();
            label6 = new Label();
            tb_cidade = new TextBox();
            label7 = new Label();
            tb_email = new TextBox();
            gp_documento = new GroupBox();
            msk_cpf = new MaskedTextBox();
            label10 = new Label();
            label9 = new Label();
            tb_rg = new TextBox();
            label8 = new Label();
            gp_contato = new GroupBox();
            msk_telefone2 = new MaskedTextBox();
            msk_telefone1 = new MaskedTextBox();
            label11 = new Label();
            label12 = new Label();
            dtp_cadastro = new DateTimePicker();
            label13 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            msk_datanascimento = new MaskedTextBox();
            msk_categoria = new MaskedTextBox();
            label14 = new Label();
            tb_genero = new TextBox();
            dtg_cliente = new DataGridView();
            msk_cnh = new MaskedTextBox();
            toolStrip1.SuspendLayout();
            gp_documento.SuspendLayout();
            gp_contato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, toolStripSeparator1, btn_salvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(921, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.AutoSize = false;
            btn_novo.Image = Properties.Resources.novo;
            btn_novo.ImageScaling = ToolStripItemImageScaling.None;
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(98, 55);
            btn_novo.Text = "Novo";
            btn_novo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSize = false;
            btn_salvar.Image = Properties.Resources.salvar;
            btn_salvar.ImageScaling = ToolStripItemImageScaling.None;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(98, 55);
            btn_salvar.Text = "Salvar";
            btn_salvar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 96);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Registro:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(198, 91);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(55, 23);
            tb_id.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 133);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(198, 130);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(418, 23);
            tb_nome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 166);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 1;
            label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 205);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 1;
            label4.Text = "Numero da cnh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(118, 245);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 1;
            label5.Text = "Bairro:";
            // 
            // tb_bairro
            // 
            tb_bairro.Location = new Point(198, 245);
            tb_bairro.Name = "tb_bairro";
            tb_bairro.Size = new Size(418, 23);
            tb_bairro.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(110, 288);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 1;
            label6.Text = "Cidade:";
            // 
            // tb_cidade
            // 
            tb_cidade.Location = new Point(198, 285);
            tb_cidade.Name = "tb_cidade";
            tb_cidade.Size = new Size(418, 23);
            tb_cidade.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(118, 333);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 1;
            label7.Text = "Email:";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(198, 330);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(418, 23);
            tb_email.TabIndex = 3;
            // 
            // gp_documento
            // 
            gp_documento.Controls.Add(msk_cpf);
            gp_documento.Controls.Add(label10);
            gp_documento.Controls.Add(label9);
            gp_documento.Controls.Add(tb_rg);
            gp_documento.Location = new Point(648, 133);
            gp_documento.Name = "gp_documento";
            gp_documento.Size = new Size(261, 81);
            gp_documento.TabIndex = 4;
            gp_documento.TabStop = false;
            gp_documento.Text = "Documentos";
            // 
            // msk_cpf
            // 
            msk_cpf.Location = new Point(65, 52);
            msk_cpf.Mask = "999,999,999-99";
            msk_cpf.Name = "msk_cpf";
            msk_cpf.Size = new Size(128, 23);
            msk_cpf.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 52);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 1;
            label10.Text = "CPF:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 1;
            label9.Text = "RG:";
            // 
            // tb_rg
            // 
            tb_rg.Location = new Point(65, 19);
            tb_rg.Name = "tb_rg";
            tb_rg.Size = new Size(128, 23);
            tb_rg.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(438, 202);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 1;
            label8.Text = "Categoria:";
            // 
            // gp_contato
            // 
            gp_contato.Controls.Add(msk_telefone2);
            gp_contato.Controls.Add(msk_telefone1);
            gp_contato.Controls.Add(label11);
            gp_contato.Controls.Add(label12);
            gp_contato.Location = new Point(648, 245);
            gp_contato.Name = "gp_contato";
            gp_contato.Size = new Size(261, 81);
            gp_contato.TabIndex = 4;
            gp_contato.TabStop = false;
            gp_contato.Text = "Contato";
            // 
            // msk_telefone2
            // 
            msk_telefone2.Location = new Point(106, 49);
            msk_telefone2.Mask = "(99) 0000-0000";
            msk_telefone2.Name = "msk_telefone2";
            msk_telefone2.Size = new Size(128, 23);
            msk_telefone2.TabIndex = 3;
            // 
            // msk_telefone1
            // 
            msk_telefone1.Location = new Point(106, 17);
            msk_telefone1.Mask = "(99) 0000-0000";
            msk_telefone1.Name = "msk_telefone1";
            msk_telefone1.Size = new Size(128, 23);
            msk_telefone1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 52);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 1;
            label11.Text = "Telefone2:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 1;
            label12.Text = "Telefone1:";
            // 
            // dtp_cadastro
            // 
            dtp_cadastro.CustomFormat = "dd/MM/yyyy";
            dtp_cadastro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_cadastro.Format = DateTimePickerFormat.Short;
            dtp_cadastro.Location = new Point(508, 94);
            dtp_cadastro.Name = "dtp_cadastro";
            dtp_cadastro.Size = new Size(108, 22);
            dtp_cadastro.TabIndex = 5;
            dtp_cadastro.Value = new DateTime(2024, 11, 28, 1, 6, 47, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(371, 96);
            label13.Name = "label13";
            label13.Size = new Size(131, 20);
            label13.TabIndex = 1;
            label13.Text = "Data  Cadastro";
            // 
            // msk_datanascimento
            // 
            msk_datanascimento.Location = new Point(198, 166);
            msk_datanascimento.Mask = "00/00/0000";
            msk_datanascimento.Name = "msk_datanascimento";
            msk_datanascimento.Size = new Size(235, 23);
            msk_datanascimento.TabIndex = 6;
            // 
            // msk_categoria
            // 
            msk_categoria.Location = new Point(537, 199);
            msk_categoria.Mask = "0/0";
            msk_categoria.Name = "msk_categoria";
            msk_categoria.Size = new Size(79, 23);
            msk_categoria.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(437, 165);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 1;
            label14.Text = "Genero:";
            // 
            // tb_genero
            // 
            tb_genero.Location = new Point(508, 163);
            tb_genero.Name = "tb_genero";
            tb_genero.Size = new Size(108, 23);
            tb_genero.TabIndex = 2;
            // 
            // dtg_cliente
            // 
            dtg_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cliente.Location = new Point(12, 359);
            dtg_cliente.Name = "dtg_cliente";
            dtg_cliente.Size = new Size(897, 261);
            dtg_cliente.TabIndex = 8;
            // 
            // msk_cnh
            // 
            msk_cnh.Location = new Point(198, 203);
            msk_cnh.Mask = "999,999,999-99";
            msk_cnh.Name = "msk_cnh";
            msk_cnh.Size = new Size(235, 23);
            msk_cnh.TabIndex = 3;
            // 
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 632);
            Controls.Add(msk_cnh);
            Controls.Add(dtg_cliente);
            Controls.Add(msk_categoria);
            Controls.Add(msk_datanascimento);
            Controls.Add(dtp_cadastro);
            Controls.Add(gp_contato);
            Controls.Add(gp_documento);
            Controls.Add(tb_email);
            Controls.Add(tb_cidade);
            Controls.Add(label7);
            Controls.Add(tb_bairro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_nome);
            Controls.Add(label3);
            Controls.Add(tb_genero);
            Controls.Add(tb_id);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gp_documento.ResumeLayout(false);
            gp_documento.PerformLayout();
            gp_contato.ResumeLayout(false);
            gp_contato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_novo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_salvar;
        private Label label1;
        private TextBox tb_id;
        private Label label2;
        private TextBox tb_nome;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_bairro;
        private Label label6;
        private TextBox tb_cidade;
        private Label label7;
        private TextBox tb_email;
        private GroupBox gp_documento;
        private Label label8;
        private MaskedTextBox msk_cpf;
        private Label label10;
        private Label label9;
        private TextBox tb_rg;
        private GroupBox gp_contato;
        private MaskedTextBox msk_telefone2;
        private MaskedTextBox msk_telefone1;
        private Label label11;
        private Label label12;
        private DateTimePicker dtp_cadastro;
        private Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox msk_datanascimento;
        private MaskedTextBox msk_categoria;
        private Label label14;
        private TextBox tb_genero;
        private DataGridView dtg_cliente;
        private MaskedTextBox msk_cnh;
    }
}