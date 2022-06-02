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

namespace WindowsFormsApp15.Telas.Usuario
{
    public partial class frmAlterarUsuario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmAlterarUsuario()
        {
            InitializeComponent();

            this.CarregarFuncionario();
        }

        public void CarregarTela(tb_usuario model)
        {
            txtID.Text = model.id_usuario.ToString();
            txtUsuario.Text = model.nm_usuario;
            cboFuncionario.Text = model.tb_funcionario.nm_funcionario;
            cboNivel.Text = model.nv_nivelAcesso;
        }

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboFuncionario.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboFuncionario.DataSource = lista;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            Business.UsuarioBusiness business = new Business.UsuarioBusiness();

            Model.tb_usuario model = new Model.tb_usuario();

            tb_funcionario comboFuncionario = cboFuncionario.SelectedItem as tb_funcionario;

            model.id_usuario = Convert.ToInt32(txtID.Text);
            model.nm_usuario = txtUsuario.Text;
            model.id_funcionario = comboFuncionario.id_funcionario;
            model.nv_nivelAcesso = cboNivel.Text;

            business.alterarusuario(model);

            MessageBox.Show("Alterado com sucesso");
        }
        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            Business.UsuarioBusiness business = new Business.UsuarioBusiness();

            tb_usuario usuario = business.ConsultarPorID(id);

            txtUsuario.Text = usuario.nm_usuario;
            cboFuncionario.Text = usuario.tb_funcionario.nm_funcionario;
            cboNivel.Text = usuario.nv_nivelAcesso;
        }
    }
}
