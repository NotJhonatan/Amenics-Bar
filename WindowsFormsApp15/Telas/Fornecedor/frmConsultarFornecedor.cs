using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas
{
    public partial class frmConsultarFornecedor : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmConsultarFornecedor()
        {
            InitializeComponent();
        }
        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Business.FornecedorBusiness business = new Business.FornecedorBusiness();

                string nome = txtFornecedor.Text;

                List<tb_fornecedor> lista = business.ConsultarFornecedorNome(nome);

                dgvConsultarFuncionario.AutoGenerateColumns = false;
                dgvConsultarFuncionario.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Business.FornecedorBusiness business = new Business.FornecedorBusiness();

                string nomeempresa = txtEmpresa.Text;

                List<tb_fornecedor> lista = business.ConsultarFornecedorNomeEmpresa(nomeempresa);

                dgvConsultarFuncionario.AutoGenerateColumns = false;
                dgvConsultarFuncionario.DataSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarFornecedor_Load(object sender, EventArgs e)
        {
        }

        private void dgvConsultarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                tb_fornecedor fornecedor = dgvConsultarFuncionario.CurrentRow.DataBoundItem as tb_fornecedor;
                Telas.Fornecedor.frmAlterarFornecedor tela = new Fornecedor.frmAlterarFornecedor();
                tela.CarregarTela(fornecedor);
                tela.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {
                tb_fornecedor fornecedor = dgvConsultarFuncionario.CurrentRow.DataBoundItem as tb_fornecedor;
                Telas.Fornecedor.frmDeletarFornecedor tela = new Fornecedor.frmDeletarFornecedor();
                tela.CarregarTela(fornecedor);
                tela.ShowDialog();
            }
        }
    }
}
