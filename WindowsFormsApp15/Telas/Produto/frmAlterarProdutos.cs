using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas
{
    public partial class frmAlterarProdutos : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmAlterarProdutos()
        {
            InitializeComponent();
            this.CarregarFornecedor();
        }

        public void CarregarTela(tb_produto model)
        {
            txtIdProduto.Text = model.id_produto.ToString();
            txtNome.Text = model.nm_produto;
            txtCategoria.Text = model.ds_categoria;
            cboFornecedor.Text = model.tb_fornecedor.nm_fornecedor;
            nudValor.Value = model.vl_valor;

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(model.img_produto);

            imgImagem.Image = imagem;
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
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_fornecedor comboFornecedor = cboFornecedor.SelectedItem as tb_fornecedor;
                Model.tb_produto modelo = new Model.tb_produto();
                tb_produto produto = business.Listar(Convert.ToInt32(txtIdProduto.Text));

                modelo.id_produto = Convert.ToInt32(txtIdProduto.Text);
                modelo.id_fornecedor = comboFornecedor.id_fornecedor;
                modelo.ds_categoria = txtCategoria.Text;
                modelo.nm_produto = txtNome.Text;
                modelo.vl_valor = nudValor.Value;

                byte[] imagem_byte = null;

                if (txtImagem.Text == string.Empty)
                {
                    modelo.img_produto = produto.img_produto;
                }
                else
                {
                    FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fstream);

                    imagem_byte = br.ReadBytes((int)fstream.Length);

                    modelo.img_produto = imagem_byte;
                }

                business.AlterarProduto(modelo);

                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProduto.Text);

            Model.tb_produto modelo = business.Listar(id);

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(modelo.img_produto);

            cboFornecedor.Text = modelo.tb_fornecedor.nm_fornecedor;
            txtNome.Text = modelo.nm_produto;
            imgImagem.Image = imagem;
            txtIdProduto.Text = modelo.ds_categoria;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|JPEG Files(*.jfif)|*.jfif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                imgImagem.ImageLocation = foto;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            imgImagem.Image = Properties.Resources._860086;
        }
    }
}
