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
    public partial class frmCadastrarUsuario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmCadastrarUsuario()
        {
            InitializeComponent();

            this.CarregarFuncionario();
        }

        Model.tb_usuario model = new Model.tb_usuario();
        Business.UsuarioBusiness business = new Business.UsuarioBusiness();

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboFuncionario.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboFuncionario.DataSource = lista;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_funcionario comboFuncionario = cboFuncionario.SelectedItem as tb_funcionario;

                model.id_funcionario = comboFuncionario.id_funcionario;
                model.nm_usuario = txtUsuario.Text;
                model.ds_senha = txtSenha.Text;
                string confirmar = txtConfirmar.Text;
                model.nv_nivelAcesso = cboNivel.Text;

                business.inserirUsuario(model, confirmar);

                MessageBox.Show("Cadastrado com Sucesso");
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
