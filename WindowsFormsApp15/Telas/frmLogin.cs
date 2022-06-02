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

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.UsuarioBusiness usuarioBusiness = new Business.UsuarioBusiness();
                Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();

                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                Model.tb_usuario modeloUsuario = usuarioBusiness.ModeloUsuario(usuario, senha);

                bool login = usuarioBusiness.Usuario(usuario, senha);

                Model.tb_funcionario funcionario = funcionarioBusiness.Listar(modeloUsuario.id_funcionario);

                Autenticacao.Usuario.UsuarioLogado.ID = funcionario.id_funcionario;
                Autenticacao.Usuario.UsuarioLogado.IDUsuario = modeloUsuario.id_usuario;
                Autenticacao.Usuario.UsuarioLogado.Nome = funcionario.nm_funcionario;
                Autenticacao.Usuario.UsuarioLogado.RG = funcionario.ds_rg;
                Autenticacao.Usuario.UsuarioLogado.CPF = funcionario.ds_cpf;
                Autenticacao.Usuario.UsuarioLogado.Telefone = funcionario.ds_telefone;
                Autenticacao.Usuario.UsuarioLogado.Celular = funcionario.ds_celular;
                Autenticacao.Usuario.UsuarioLogado.Email = funcionario.ds_email;
                Autenticacao.Usuario.UsuarioLogado.Endereco = funcionario.ds_endereco;
                Autenticacao.Usuario.UsuarioLogado.cep = funcionario.ds_cep;
                Autenticacao.Usuario.UsuarioLogado.cidade = funcionario.ds_cidade;
                Autenticacao.Usuario.UsuarioLogado.UF = funcionario.ds_UF;
                Autenticacao.Usuario.UsuarioLogado.Complemento = funcionario.ds_complemento;
                Autenticacao.Usuario.UsuarioLogado.NumeroCasa = funcionario.ds_numeroCasa;
                Autenticacao.Usuario.UsuarioLogado.Cargo = funcionario.ds_cargo;
                Autenticacao.Usuario.UsuarioLogado.Salario = funcionario.vl_salarioPorHora;
                Autenticacao.Usuario.UsuarioLogado.DataContratacao = funcionario.dt_contratacao;
                Autenticacao.Usuario.UsuarioLogado.Foto = funcionario.img_foto;
                Autenticacao.Usuario.UsuarioLogado.NivelAcesso = modeloUsuario.nv_nivelAcesso;

                if (login == true)
                {
                    Telas.Menu tela = new Telas.Menu();
                    tela.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas");
                }
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

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Recuperação_de_Senha.ConfirmarEmail tela = new Recuperação_de_Senha.ConfirmarEmail();
            tela.Show();
        }
    }
}