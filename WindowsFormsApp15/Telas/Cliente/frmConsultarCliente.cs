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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                tb_cliente cliente = dgvCliente.CurrentRow.DataBoundItem as tb_cliente;

                Telas.Cliente.frmAlterarCliente tela = new Cliente.frmAlterarCliente();
                tela.CarregarTela(cliente);
                tela.Show();
            }

            if (e.ColumnIndex == 1)
            {
                tb_cliente cliente = dgvCliente.CurrentRow.DataBoundItem as tb_cliente;

                Telas.Cliente.frmDeletarCliente tela = new frmDeletarCliente();
                tela.CarregarTela(cliente);
                tela.Show();
            }
        }

        Business.ClienteBusiness business = new Business.ClienteBusiness();
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;

                List<tb_cliente> lista = business.ConsultarClienteNome(nome);

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cpf = txtCpf.Text;

                List<tb_cliente> lista = business.ConsultarClienteCpf(cpf);

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rg = txtRg.Text;

                List<tb_cliente> lista = business.ConsultarClienteRg(rg);

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
