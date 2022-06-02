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
    public partial class frmConsultarProduto : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmConsultarProduto()
        {
            InitializeComponent();
            this.CarregarFornecedor();
        }

        private void CarregarFornecedor()
        {
            Business.FornecedorBusiness business = new Business.FornecedorBusiness();

            List<tb_fornecedor> lista = business.ConsultarFornecedor();

            cboFornecedor.DisplayMember = nameof(tb_fornecedor.nm_fornecedor);
            cboFornecedor.DataSource = lista;
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

        Business.ProdutoBusiness business = new Business.ProdutoBusiness();
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;

                List<tb_produto> lista = business.ConsultarProduto(nome);

                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fornecedor = cboFornecedor.Text;

                List<tb_produto> lista = business.ConsultarProdutoFornecedor(fornecedor);

                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string categoria = txtCategoria.Text;

                List<tb_produto> lista = business.ConsultarProdutoCategoria(categoria);

                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                tb_produto produto = dgvProduto.CurrentRow.DataBoundItem as tb_produto;

                Telas.frmAlterarProdutos tela = new frmAlterarProdutos();
                tela.CarregarTela(produto);

                tela.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {
                tb_produto produto = dgvProduto.CurrentRow.DataBoundItem as tb_produto;

                Telas.frmDeletarProduto tela = new Telas.frmDeletarProduto();
                tela.CarregarTela(produto);
                tela.ShowDialog();
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_produto produto = dgvProduto.CurrentRow.DataBoundItem as tb_produto;

                Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                Image imagem = imageConverter.byteArrayToImage(produto.img_produto);

                picProduto.Image = imagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
