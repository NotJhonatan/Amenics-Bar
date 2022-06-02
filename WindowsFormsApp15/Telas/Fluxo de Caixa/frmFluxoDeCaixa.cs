using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas.Fluxo_de_Caixa
{
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }

        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            Business.FluxoDeCaixaBusiness business = new Business.FluxoDeCaixaBusiness();

            List<vw_fluxocaixa> lista = business.FluxoDeCaixa();

            dgvFluxo.DataSource = lista;
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
