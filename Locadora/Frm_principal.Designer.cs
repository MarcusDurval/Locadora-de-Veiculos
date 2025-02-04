namespace Locadora
{
    partial class Frm_principal
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
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ganho_de_capital_venda_veiculo;
            pictureBox1.Location = new Point(0, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator3, toolStripButton3, toolStripSeparator1, toolStripButton1, toolStripSeparator2, toolStripButton4, toolStripButton5, toolStripSeparator5, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 58);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.Image = Properties.Resources.orçamentos;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(98, 55);
            toolStripButton2.Text = "Locação";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 58);
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.Image = Properties.Resources.funcionários;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(98, 55);
            toolStripButton3.Text = "Funcionarios";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.Image = Properties.Resources.clientes;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(98, 55);
            toolStripButton1.Text = "Clientes";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 58);
            // 
            // toolStripButton4
            // 
            toolStripButton4.AutoSize = false;
            toolStripButton4.Image = Properties.Resources.pequeno;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(98, 55);
            toolStripButton4.Text = "Veiculos";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripButton5.AutoSize = false;
            toolStripButton5.Image = Properties.Resources.excluir;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(98, 55);
            toolStripButton5.Text = "Sair";
            toolStripButton5.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 58);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 58);
            // 
            // Frm_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
    }
}