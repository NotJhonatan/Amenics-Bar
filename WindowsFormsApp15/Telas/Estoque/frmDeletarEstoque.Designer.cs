namespace WindowsFormsApp15.Telas.Estoque
{
    partial class frmDeletarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletarEstoque));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnNao = new System.Windows.Forms.RadioButton();
            this.rdnSim = new System.Windows.Forms.RadioButton();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(185, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 343;
            this.label5.Text = "Deletar Estoque";
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
            this.panel1.TabIndex = 346;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources._860086;
            this.pictureBox1.Location = new System.Drawing.Point(189, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 347;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(125, 210);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 284;
            this.txtID.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Enabled = false;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(10, 212);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 20);
            this.label27.TabIndex = 166;
            this.label27.Text = "ID Estoque:";
            this.label27.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdnNao);
            this.groupBox2.Controls.Add(this.rdnSim);
            this.groupBox2.Controls.Add(this.nudValor);
            this.groupBox2.Controls.Add(this.dtpData);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Location = new System.Drawing.Point(16, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 278);
            this.groupBox2.TabIndex = 348;
            this.groupBox2.TabStop = false;
            // 
            // rdnNao
            // 
            this.rdnNao.AutoSize = true;
            this.rdnNao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnNao.ForeColor = System.Drawing.Color.White;
            this.rdnNao.Location = new System.Drawing.Point(305, 157);
            this.rdnNao.Name = "rdnNao";
            this.rdnNao.Size = new System.Drawing.Size(53, 20);
            this.rdnNao.TabIndex = 325;
            this.rdnNao.TabStop = true;
            this.rdnNao.Text = "Não";
            this.rdnNao.UseVisualStyleBackColor = true;
            // 
            // rdnSim
            // 
            this.rdnSim.AutoSize = true;
            this.rdnSim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnSim.ForeColor = System.Drawing.Color.White;
            this.rdnSim.Location = new System.Drawing.Point(205, 157);
            this.rdnSim.Name = "rdnSim";
            this.rdnSim.Size = new System.Drawing.Size(49, 20);
            this.rdnSim.TabIndex = 324;
            this.rdnSim.TabStop = true;
            this.rdnSim.Text = "Sim";
            this.rdnSim.UseVisualStyleBackColor = true;
            // 
            // nudValor
            // 
            this.nudValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValor.Location = new System.Drawing.Point(205, 117);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(210, 20);
            this.nudValor.TabIndex = 323;
            // 
            // dtpData
            // 
            this.dtpData.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpData.BorderRadius = 0;
            this.dtpData.ForeColor = System.Drawing.Color.White;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.FormatCustom = null;
            this.dtpData.Location = new System.Drawing.Point(205, 67);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(210, 32);
            this.dtpData.TabIndex = 322;
            this.dtpData.Value = new System.DateTime(2019, 9, 25, 23, 52, 13, 816);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(205, 29);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(210, 23);
            this.txtNomeProduto.TabIndex = 321;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 320;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 319;
            this.label3.Text = "Vendido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 317;
            this.label2.Text = "Data de Chegada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(31, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 316;
            this.label7.Text = "Nome do Produto";
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
            this.btnDeletar.IconMarginLeft = 20;
            this.btnDeletar.IconMarginRight = 0;
            this.btnDeletar.IconRightVisible = true;
            this.btnDeletar.IconRightZoom = 0D;
            this.btnDeletar.IconVisible = true;
            this.btnDeletar.IconZoom = 50D;
            this.btnDeletar.IsTab = false;
            this.btnDeletar.Location = new System.Drawing.Point(152, 217);
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
            // frmDeletarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 531);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeletarEstoque";
            this.Text = "frmDeletarEstoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnNao;
        private System.Windows.Forms.RadioButton rdnSim;
        private System.Windows.Forms.NumericUpDown nudValor;
        private Bunifu.Framework.UI.BunifuDatepicker dtpData;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
    }
}