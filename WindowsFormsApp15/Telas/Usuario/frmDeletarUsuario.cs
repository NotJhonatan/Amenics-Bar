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
    public partial class frmDeletarUsuario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDeletarUsuario()
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

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarTela(tb_usuario model)
        {
            txtID.Text = model.id_usuario.ToString();
            txtUsuario.Text = model.nm_usuario;
            cboFuncionario.Text = model.tb_funcionario.nm_funcionario;
            cboNivel.Text = model.nv_nivelAcesso;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Business.UsuarioBusiness business = new Business.UsuarioBusiness();

            int id = Convert.ToInt32(txtID.Text);

            business.RemoverUsuario(id);

            MessageBox.Show("Deletado com sucesso");

            this.Close();
        }
    }
}
