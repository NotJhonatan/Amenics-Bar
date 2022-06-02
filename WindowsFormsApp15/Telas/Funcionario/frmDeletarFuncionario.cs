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
    public partial class frmDeletarFuncionario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmDeletarFuncionario()
        {
            InitializeComponent();
        }

        Model.tb_funcionario model = new Model.tb_funcionario();
        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

        public void CarregarTela(tb_funcionario model)
        {
            //*Informações Pessoais*

            txtId.Text = model.id_funcionario.ToString();
            txtNome.Text = model.nm_funcionario;
            dtpNascimento.Value = model.dt_nascimento;
            txtRg.Text = model.ds_rg;
            txtEmail.Text = model.ds_email;
            dtpContrat.Value = model.dt_contratacao;
            cboGen.Text = model.ds_genero;
            txtCargo.Text = model.ds_cargo;
            txtCelular.Text = model.ds_celular;
            txtTelefone.Text = model.ds_telefone;
            nudSalario.Value = model.vl_salarioPorHora;
            txtCpf.Text = model.ds_cpf;
            cboGen.Text = model.ds_genero;

            //*Endereço*

            txtEndereço.Text = model.ds_endereco;
            txtCep.Text = model.ds_cep;
            txtCidade.Text = model.ds_cidade;
            txtUF.Text = model.ds_UF;
            txtComplemento.Text = model.ds_complemento;
            txtNumRes.Text = model.ds_numeroCasa;

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(model.img_foto);

            picFoto.Image = imagem;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                              
                business.RemoverFuncionario(id);

                MessageBox.Show("Deletado com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                business.RemoverFuncionario(id);

                MessageBox.Show("Funcionario removido com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
           
    
}
