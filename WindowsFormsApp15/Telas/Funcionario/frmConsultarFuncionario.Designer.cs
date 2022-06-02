namespace WindowsFormsApp15.Telas
{
    partial class frmConsultarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            this.dgvConsultarFuncionario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpContrat = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarFuncionario
            // 
            this.dgvConsultarFuncionario.AllowUserToAddRows = false;
            this.dgvConsultarFuncionario.AllowUserToDeleteRows = false;
            this.dgvConsultarFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column15,
            this.Column2,
            this.Column3,
            this.Columm4,
            this.ds_telefone,
            this.ds_celular,
            this.ds_email,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvConsultarFuncionario.Location = new System.Drawing.Point(11, 323);
            this.dgvConsultarFuncionario.Name = "dgvConsultarFuncionario";
            this.dgvConsultarFuncionario.ReadOnly = true;
            this.dgvConsultarFuncionario.Size = new System.Drawing.Size(1145, 337);
            this.dgvConsultarFuncionario.TabIndex = 165;
            this.dgvConsultarFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarFuncionario_CellClick);
            this.dgvConsultarFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarFuncionario_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::WindowsFormsApp15.Properties.Resources.flat_style_circle_edit_icon_icons_com_66939;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "";
            this.Column15.Image = global::WindowsFormsApp15.Properties.Resources.recyclebinfilled_recycling_full_garbage_1993;
            this.Column15.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 25;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nm_funcionario";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ds_rg";
            this.Column3.HeaderText = "RG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Columm4
            // 
            this.Columm4.DataPropertyName = "ds_cpf";
            this.Columm4.HeaderText = "CPF";
            this.Columm4.Name = "Columm4";
            this.Columm4.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "ds_telefone";
            this.ds_telefone.HeaderText = "Telefone";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            // 
            // ds_celular
            // 
            this.ds_celular.DataPropertyName = "ds_celular";
            this.ds_celular.HeaderText = "Celular";
            this.ds_celular.Name = "ds_celular";
            this.ds_celular.ReadOnly = true;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "ds_email";
            this.ds_email.HeaderText = "Email";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dt_nascimento";
            this.Column4.HeaderText = "Nascimento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ds_genero";
            this.Column5.HeaderText = "Sexo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ds_cep";
            this.Column7.HeaderText = "CEP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ds_endereco";
            this.Column6.HeaderText = "Endereco";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ds_cidade";
            this.Column8.HeaderText = "Cidade";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ds_uf";
            this.Column9.HeaderText = "UF";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ds_numeroCasa";
            this.Column11.HeaderText = "Número";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ds_complemento";
            this.Column10.HeaderText = "Complemento";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ds_cargo";
            this.Column12.HeaderText = "Cargo";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "vl_salarioPorHora";
            this.Column13.HeaderText = "Salário";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "dt_contratacao";
            this.Column14.HeaderText = "Contratacao";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(494, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 173;
            this.label4.Text = "Consultar Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(521, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 172;
            this.label1.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(687, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 170;
            this.label2.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(31, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 167;
            this.label7.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(871, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 174;
            this.label6.Text = "Contratação:";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(568, 275);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(99, 24);
            this.txtRg.TabIndex = 177;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(741, 275);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(115, 24);
            this.txtCPF.TabIndex = 178;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // dtpContrat
            // 
            this.dtpContrat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpContrat.BorderRadius = 0;
            this.dtpContrat.ForeColor = System.Drawing.Color.White;
            this.dtpContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContrat.FormatCustom = null;
            this.dtpContrat.Location = new System.Drawing.Point(990, 275);
            this.dtpContrat.Name = "dtpContrat";
            this.dtpContrat.Size = new System.Drawing.Size(159, 27);
            this.dtpContrat.TabIndex = 179;
            this.dtpContrat.Value = new System.DateTime(2019, 9, 25, 23, 52, 13, 816);
            this.dtpContrat.onValueChanged += new System.EventHandler(this.dtpContrat_onValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(299, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 185;
            this.label9.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1135, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 155;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1113, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 156;
            this.label5.Text = "_";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 33);
            this.panel1.TabIndex = 166;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 276);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 20);
            this.txtNome.TabIndex = 188;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.Transparent;
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoto.Image = global::WindowsFormsApp15.Properties.Resources.collaborator_male;
            this.picFoto.Location = new System.Drawing.Point(504, 91);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(174, 169);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 189;
            this.picFoto.TabStop = false;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(366, 276);
            this.txtCargo.MaxLength = 20;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(147, 22);
            this.txtCargo.TabIndex = 336;
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 673);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpContrat);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConsultarFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarFuncionario";
            this.Text = "frmConsultarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultarFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private Bunifu.Framework.UI.BunifuDatepicker dtpContrat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}