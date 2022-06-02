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

namespace WindowsFormsApp15.Telas.Compra
{
    public partial class frmTelaCompra : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmTelaCompra()
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

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Business.ProdutoBusiness produtoBusiness = new Business.ProdutoBusiness();
        private void frmTelaCompra_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuario.Text = Autenticacao.Usuario.UsuarioLogado.Nome;

                List<tb_produto> lista = produtoBusiness.ConsultarTodosProdutos();

                listProduto.DisplayMember = nameof(tb_produto.nm_produto);
                listProduto.DataSource = lista;

                Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                Image imagem = imageConverter.byteArrayToImage(Autenticacao.Usuario.UsuarioLogado.Foto);

                imgUsuario.Image = imagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Business.CompraBusiness compraBusiness = new Business.CompraBusiness();
                Business.EstoqueBusiness estoqueBusiness = new Business.EstoqueBusiness();
                Model.tb_compra compra = new Model.tb_compra();

                compra.dt_compra = DateTime.Now.Date;
                compra.vl_valorTotal = Convert.ToDecimal(lblTotal.Text);

                compraBusiness.InserirCompra(compra);

                Model.tb_compra_item compraItem = new Model.tb_compra_item();
                Model.tb_estoque estoqueItem = new Model.tb_estoque();

                List<Model.tb_produto> itens = dgvProdutos.DataSource as List<Model.tb_produto>;

                    foreach (var item in itens)
                    {
                        compraItem.id_compra = compra.id_compra;
                        compraItem.id_produto = item.id_produto;

                        estoqueItem.id_produto = item.id_produto;
                        estoqueItem.dt_entrada = DateTime.Now.Date;
                        estoqueItem.bt_vendido = false;

                        compraBusiness.InserirCompraItem(compraItem);
                        estoqueBusiness.CadastrarEstoque(estoqueItem);
                    }
                

                MessageBox.Show("Compra finalizada com sucesso");

                dgvProdutos.DataSource = null;

                lblTotal.Text = "0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto produto = listProduto.SelectedItem as Model.tb_produto;

                List<Model.tb_produto> itens = dgvProdutos.DataSource as List<Model.tb_produto>;

                if (itens == null)
                {
                    itens = new List<Model.tb_produto>();
                }

                int quantiadade = Convert.ToInt32(nudQuantidade.Value);

                for (int i = 0; i < quantiadade; i++)
                {
                    itens.Add(produto);

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = itens;

                    decimal total = itens.Sum(x => x.vl_valor);

                    lblTotal.Text = total.ToString();
                }

                nudQuantidade.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                try
                {
                    tb_produto produto = dgvProdutos.CurrentRow.DataBoundItem as tb_produto;

                    List<Model.tb_produto> itens = dgvProdutos.DataSource as List<Model.tb_produto>;

                    itens.Remove(produto);

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = itens;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}