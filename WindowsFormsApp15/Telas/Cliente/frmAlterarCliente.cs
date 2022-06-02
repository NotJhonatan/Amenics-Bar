using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas.Cliente
{
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        public void CarregarTela(tb_cliente model)
        {
            txtId.Text = model.id_cliente.ToString();
            txtNome.Text = model.nm_cliente;
            txtRg.Text = model.ds_rg;
            txtCpf.Text = model.ds_cpf;
            txtEmail.Text = model.ds_email;
            txtTelefone.Text = model.ds_telefone;
            txtCelular.Text = model.ds_celular;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Business.ClienteBusiness business = new Business.ClienteBusiness();
            Model.tb_cliente model = new Model.tb_cliente();

            model.nm_cliente = txtNome.Text;
            model.ds_rg = txtRg.Text;
            model.ds_cpf = txtCpf.Text;
            model.ds_email = txtEmail.Text;
            model.ds_telefone = txtTelefone.Text;
            model.ds_celular = txtCelular.Text;
            model.qtd_frequenciaMensal = 0;

            business.AlterarCliente(model);

            MessageBox.Show("Alterado com sucesso");
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
