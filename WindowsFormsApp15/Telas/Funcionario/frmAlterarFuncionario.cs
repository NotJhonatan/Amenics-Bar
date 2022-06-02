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
    public partial class frmAlterarFuncionario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmAlterarFuncionario()
        {
            InitializeComponent();
        }

        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_funcionario model = new Model.tb_funcionario();

                int id = Convert.ToInt32(txtId.Text);

                model = business.Listar(id);

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
            catch (Exception ex)
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

        private void btnCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model.tb_funcionario model = new Model.tb_funcionario();

                tb_funcionario func = business.Listar(Convert.ToInt32(txtId.Text));

                //*Informações Pessoais*

                model.id_funcionario = Convert.ToInt32(txtId.Text);
                model.nm_funcionario = txtNome.Text;
                model.dt_nascimento = dtpNascimento.Value;
                model.ds_rg = txtRg.Text;
                model.ds_email = txtEmail.Text;
                model.dt_contratacao = dtpContrat.Value;
                model.ds_genero = cboGen.Text;
                model.ds_cargo = txtCargo.Text;
                model.ds_celular = txtCelular.Text;
                model.ds_telefone = txtTelefone.Text;
                model.vl_salarioPorHora = nudSalario.Value;
                model.ds_cpf = txtCpf.Text;

                //*Endereço*

                model.ds_endereco = txtEndereço.Text;
                model.ds_cep = txtCep.Text;
                model.ds_cidade = txtCidade.Text;
                model.ds_UF = txtUF.Text;
                model.ds_complemento = txtComplemento.Text;
                model.ds_numeroCasa = txtNumRes.Text;


                byte[] imagem_byte = null;

                if(txtImagem.Text == string.Empty)
                {
                    model.img_foto = func.img_foto;
                }
                else
                {
                    FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fstream);

                    imagem_byte = br.ReadBytes((int)fstream.Length);

                    model.img_foto = imagem_byte;
                }

                business.AlterarFuncionario(model);

                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|JPEG Files(*.jfif)|*.jfif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                picFoto.ImageLocation = foto;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            picFoto.Image = WindowsFormsApp15.Properties.Resources.collaborator_male;
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
