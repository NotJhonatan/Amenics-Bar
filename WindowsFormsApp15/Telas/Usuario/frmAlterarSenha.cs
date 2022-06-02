using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas.Usuario_
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_usuario model = new Model.tb_usuario();

                string senha = txtSenha.Text;
                string confirmar = txtConfirmar.Text;

                model.id_usuario = Autenticacao.Usuario.UsuarioLogado.IDUsuario;
                model.ds_senha = txtSenha.Text;

                Business.UsuarioBusiness business = new Business.UsuarioBusiness();

                business.alterarSenha(model, confirmar);

                MessageBox.Show("Alterado com sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
