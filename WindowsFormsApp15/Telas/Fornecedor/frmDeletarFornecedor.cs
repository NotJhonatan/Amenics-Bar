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

namespace WindowsFormsApp15.Telas.Fornecedor
{
    public partial class frmDeletarFornecedor : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmDeletarFornecedor()
        {
            InitializeComponent();
        }

        public void CarregarTela(tb_fornecedor fornecedor)
        {
            //*Informações básicas*
            txtID.Text = fornecedor.id_fornecedor.ToString();
            txtCelular.Text = fornecedor.ds_celular;
            txtEmpresa.Text = fornecedor.nm_empresa;
            txtNome.Text = fornecedor.nm_fornecedor;
            txtTelefone.Text = fornecedor.ds_telefone;
            txtCNPJ.Text = fornecedor.ds_cnpj;

            //*Endereço*
            txtCEP.Text = fornecedor.ds_cep;
            txtCidade.Text = fornecedor.ds_cidade;
            txtComplemento.Text = fornecedor.ds_complemento;
            txtEndereco.Text = fornecedor.ds_endereco;
            txtUF.Text = fornecedor.ds_UF;
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
        Model.tb_fornecedor modelo = new Model.tb_fornecedor();
        Business.FornecedorBusiness business = new Business.FornecedorBusiness();
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);

                business.RemoverForncedor(id);

                MessageBox.Show("Deletado com sucesso");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            business.Listar(id);


            //*Informações básicas*

            txtCelular.Text = modelo.ds_celular;
            txtEmpresa.Text = modelo.nm_empresa;
            txtNome.Text = modelo.nm_fornecedor;
            txtTelefone.Text = modelo.ds_telefone;

            //*Endereço*

            txtCEP.Text = modelo.ds_cep;
            txtCidade.Text = modelo.ds_cidade;
            txtComplemento.Text = modelo.ds_complemento;
            txtEndereco.Text = modelo.ds_endereco;
            txtUF.Text = modelo.ds_UF;
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
