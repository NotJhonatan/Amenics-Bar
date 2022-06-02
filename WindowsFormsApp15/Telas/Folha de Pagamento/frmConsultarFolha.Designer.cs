namespace WindowsFormsApp15.Telas.Folha_de_Pagamento
{
    partial class frmConsultarFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFolha));
            this.dgvConsultarFuncionario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpContrat = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarFuncionario
            // 
            this.dgvConsultarFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionario.Location = new System.Drawing.Point(12, 192);
            this.dgvConsultarFuncionario.Name = "dgvConsultarFuncionario";
            this.dgvConsultarFuncionario.Size = new System.Drawing.Size(894, 491);
            this.dgvConsultarFuncionario.TabIndex = 203;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(330, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 207;
            this.label4.Text = "Consultar Folha de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(493, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 206;
            this.label2.Text = "Data de Emissão:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 205;
            this.label7.Text = "Funcionario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(859, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 156;
            this.label5.Text = "_";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(884, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 155;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 28);
            this.panel1.TabIndex = 204;
            // 
            // dtpContrat
            // 
            this.dtpContrat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpContrat.BorderRadius = 0;
            this.dtpContrat.ForeColor = System.Drawing.Color.White;
            this.dtpContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContrat.FormatCustom = null;
            this.dtpContrat.Location = new System.Drawing.Point(650, 152);
            this.dtpContrat.Name = "dtpContrat";
            this.dtpContrat.Size = new System.Drawing.Size(213, 24);
            this.dtpContrat.TabIndex = 209;
            this.dtpContrat.Value = new System.DateTime(2019, 9, 25, 23, 52, 13, 816);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Items.AddRange(new object[] {
            "Baixo",
            "Médio",
            "Alto",
            "Administrador"});
            this.cboFuncionario.Location = new System.Drawing.Point(148, 152);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(287, 24);
            this.cboFuncionario.TabIndex = 332;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // frmConsultarFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Background_1;
            this.ClientSize = new System.Drawing.Size(920, 693);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.dtpContrat);
            this.Controls.Add(this.dgvConsultarFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarFolha";
            this.Text = "frmConsultarFolha";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker dtpContrat;
        private System.Windows.Forms.ComboBox cboFuncionario;
    }
}