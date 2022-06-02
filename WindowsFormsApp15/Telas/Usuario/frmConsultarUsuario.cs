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
    public partial class frmConsultarUsuario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Database.UsuarioDatabase database = new Database.UsuarioDatabase();

            string nome = txtUsuario.Text;

            List<Model.tb_usuario> lista = database.ListaDeUsuariosNome(nome);

            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.DataSource = lista;
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

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            Database.UsuarioDatabase database = new Database.UsuarioDatabase();

            string funcionario = txtFuncionario.Text;

            List<Model.tb_usuario> lista = database.ListaDeUsuariosFuncionario(funcionario);

            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.DataSource = lista;
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                tb_usuario usuario = dgvUsuario.CurrentRow.DataBoundItem as tb_usuario;

                frmAlterarUsuario tela = new Usuario.frmAlterarUsuario();
                tela.CarregarTela(usuario);

                tela.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                tb_usuario usuario = dgvUsuario.CurrentRow.DataBoundItem as tb_usuario;

                frmDeletarUsuario tela = new Usuario.frmDeletarUsuario();
                tela.CarregarTela(usuario);

                tela.ShowDialog();
            }

        }
    }
}
