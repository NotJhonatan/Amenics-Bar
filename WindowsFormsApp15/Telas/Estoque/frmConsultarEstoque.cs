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

namespace WindowsFormsApp15.Telas.Estoque
{
    public partial class frmConsultarEstoque : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmConsultarEstoque()
        {
            InitializeComponent();
        }

        private void dtpData_onValueChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            DateTime data = dtpData.Value.Date;
            
           List<tb_estoque> listar = business.ConsultarEstoqueData(data);

            dgvConsultarEstoque.DataSource = listar;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            string produto = txtProduto.Text;

            List<tb_estoque> listar = business.ConsultarEstoqueProduto(produto);

            dgvConsultarEstoque.DataSource = listar;
        }
        private void rdnSim_CheckedChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            bool vendido = rdnSim.Checked;

            List<tb_estoque> listar = business.ConsultarEstoqueVendidoSim(vendido);

            dgvConsultarEstoque.DataSource = listar;
        }

        private void rdnNao_CheckedChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            bool vendido = rdnSim.Checked;

            List<tb_estoque> listar = business.ConsultarEstoqueVendidoNao(vendido);

            dgvConsultarEstoque.DataSource = listar;
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
