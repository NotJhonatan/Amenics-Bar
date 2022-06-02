namespace WindowsFormsApp15.Telas.Usuario
{
    partial class frmDeletarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletarUsuario));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(37, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 330;
            this.label8.Text = "Funcionário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(37, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 322;
            this.label6.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(232, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 22);
            this.txtUsuario.TabIndex = 327;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 326;
            this.label4.Text = "Nível de Acesso:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Enabled = false;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(78, 220);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 20);
            this.label27.TabIndex = 166;
            this.label27.Text = "ID Usuario:";
            this.label27.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(193, 218);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 284;
            this.txtID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(178, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 325;
            this.label5.Text = "Deletar Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cboFuncionario);
            this.groupBox2.Controls.Add(this.cboNivel);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 246);
            this.groupBox2.TabIndex = 324;
            this.groupBox2.TabStop = false;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.Enabled = false;
            this.cboFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Items.AddRange(new object[] {
            "Baixo",
            "Médio",
            "Alto",
            "Administrador"});
            this.cboFuncionario.Location = new System.Drawing.Point(232, 123);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(183, 24);
            this.cboFuncionario.TabIndex = 333;
            // 
            // cboNivel
            // 
            this.cboNivel.Enabled = false;
            this.cboNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "Baixo",
            "Médio",
            "Alto",
            "Administrador"});
            this.cboNivel.Location = new System.Drawing.Point(232, 84);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(183, 24);
            this.cboNivel.TabIndex = 332;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeletar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.BorderRadius = 0;
            this.btnDeletar.ButtonText = "DELETAR";
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletar.Iconimage = global::WindowsFormsApp15.Properties.Resources.IconeRemover1;
            this.btnDeletar.Iconimage_right = null;
            this.btnDeletar.Iconimage_right_Selected = null;
            this.btnDeletar.Iconimage_Selected = null;
            this.btnDeletar.IconMarginLeft = 15;
            this.btnDeletar.IconMarginRight = 0;
            this.btnDeletar.IconRightVisible = true;
            this.btnDeletar.IconRightZoom = 0D;
            this.btnDeletar.IconVisible = true;
            this.btnDeletar.IconZoom = 50D;
            this.btnDeletar.IsTab = false;
            this.btnDeletar.Location = new System.Drawing.Point(163, 188);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeletar.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(138, 34);
            this.btnDeletar.TabIndex = 171;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.EditarFuncionario;
            this.pictureBox1.Location = new System.Drawing.Point(182, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 329;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Controls.Add(this.lblSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 28);
            this.panel1.TabIndex = 328;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(442, 2);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 23);
            this.lblMinimizar.TabIndex = 156;
            this.lblMinimizar.Text = "_";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSair.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(467, 5);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(23, 23);
            this.lblSair.TabIndex = 155;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmDeletarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 521);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeletarUsuario";
            this.Text = "frmDeletarUsuario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtID;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.ComboBox cboFuncionario;
    }
}