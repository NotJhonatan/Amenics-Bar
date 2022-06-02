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
    public partial class frmConsultarFuncionario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }


        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        Model.tb_funcionario modelo = new Model.tb_funcionario();
       
        private void txtNome_TextChanged(object sender, EventArgs e)
      {
            string nome = txtNome.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioNome(nome);

            dgvConsultarFuncionario.AutoGenerateColumns = false;
            dgvConsultarFuncionario.DataSource = lista;
        }
        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            string rg = txtRg.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioRg(rg);

            dgvConsultarFuncionario.AutoGenerateColumns = false;
            dgvConsultarFuncionario.DataSource = lista;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioCpf(cpf);

            dgvConsultarFuncionario.AutoGenerateColumns = false;
            dgvConsultarFuncionario.DataSource = lista;
        }

        private void cboCargo_TextChanged(object sender, EventArgs e)
        {
            string cargo = txtCargo.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioCargo(cargo);

            dgvConsultarFuncionario.AutoGenerateColumns = false;
            dgvConsultarFuncionario.DataSource = lista;
        }

        private void dtpContrat_onValueChanged(object sender, EventArgs e)
        {
            DateTime contrat = dtpContrat.Value.Date;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioContratacao(contrat.Date);

            dgvConsultarFuncionario.AutoGenerateColumns = false;
            dgvConsultarFuncionario.DataSource = lista;
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

        private void dgvConsultarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    tb_funcionario funcionario = dgvConsultarFuncionario.CurrentRow.DataBoundItem as tb_funcionario;

                    Telas.frmAlterarFuncionario alterar = new Telas.frmAlterarFuncionario();
                    alterar.CarregarTela(funcionario);

                    alterar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (e.ColumnIndex == 1)
            {
                try
                {
                    tb_funcionario funcionario = dgvConsultarFuncionario.CurrentRow.DataBoundItem as tb_funcionario;

                    Telas.frmDeletarFuncionario deletar = new Telas.frmDeletarFuncionario();
                    deletar.CarregarTela(funcionario);
                    deletar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvConsultarFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_funcionario funcionario = dgvConsultarFuncionario.CurrentRow.DataBoundItem as tb_funcionario;

                Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                Image imagem = imageConverter.byteArrayToImage(funcionario.img_foto);

                picFoto.Image = imagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
