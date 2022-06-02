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
    public partial class frmDeletarProduto : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmDeletarProduto()
        {
            InitializeComponent();
        }

        public void CarregarTela(tb_produto model)
        {
            txtIdProduto.Text = model.id_produto.ToString();
            txtNome.Text = model.nm_produto;
            txtCategoria.Text = model.ds_categoria;
            txtIDFornecedor.Text = model.tb_fornecedor.nm_fornecedor;
            nudValor.Value = model.vl_valor;

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(model.img_produto);

            imgImagem.Image = imagem;
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
        Model.tb_produto modelo = new Model.tb_produto();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdProduto.Text);

                business.RemoverProduto(id);

                MessageBox.Show("Deletado com Sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProduto.Text);

            Model.tb_produto modelo = business.Listar(id);

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(modelo.img_produto);

            txtIDFornecedor.Text = modelo.tb_fornecedor.nm_fornecedor;
            txtNome.Text = modelo.nm_produto;
            imgImagem.Image = imagem;
            txtCategoria.Text = modelo.ds_categoria;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
