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
    public partial class frmDeletarCliente : Form
    {
        public frmDeletarCliente()
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

            int id = Convert.ToInt32(txtId.Text);

            business.RemoverCliente(id);

            MessageBox.Show("Deletado com sucesso");
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
