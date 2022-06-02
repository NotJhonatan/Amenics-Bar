using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Recuperação_de_Senha
{
    public partial class ConfirmarEmail : Form
    {
        public ConfirmarEmail()
        {
            InitializeComponent();
        }

        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        Business.RecuperacaoBusiness recBusiness = new Business.RecuperacaoBusiness();
        Business.UsuarioBusiness usuarioBusiness = new Business.UsuarioBusiness();

        Model.tb_recuperacao model = new Model.tb_recuperacao();
        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.GmailSender gmail = new Utils.GmailSender();

                string email = txtEmail.Text;

                bool conf = business.ConfirmarEmail(email);

                tb_funcionario funcionario = business.ModeloEmail(email);

                Model.tb_usuario modeloUsuario = usuarioBusiness.UsuarioPorFuncionario(funcionario.id_funcionario);

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

                if (conf == true)
                {
                    Random rdn = new Random();
                    string codigo = rdn.Next(100000, 999999).ToString();

                    model.ds_codigo = codigo;
                    model.dt_data = DateTime.Now;
                    model.id_usuario = Autenticacao.Usuario.UsuarioLogado.IDUsuario;
                    model.bt_usado = false;


                    recBusiness.Inserir(model);
                    gmail.Enviar(email, codigo);


                    label1.Visible = false;
                    txtEmail.Visible = false;
                    btnConfirmar.Visible = false;

                    label2.Visible = true;
                    txtCodigo.Visible = true;
                    btnCodigo.Visible = true;
                }
                else
                {
                    lblErro.Text = "Email Invalido";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;

                bool resultado = recBusiness.Consultar(codigo);

                if (resultado == true)
                {
                    recBusiness.AlterarUsado(model);

                    Telas.Usuario_.frmAlterarSenha tela = new Telas.Usuario_.frmAlterarSenha();
                    tela.Show();

                    this.Close();
                }
                else
                {
                    lblErro.Text = "Código Incorreto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void EnviarWhatsapp(string telPara, string Mensagem)
        {
            telPara = telPara.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            TwilioClient.Init("AC70b9b67a32b116779d34b9097e5cd9d1", "3c9bb04fa8e721cb0788430da93c5d85");
            var message = MessageResource.Create(
             new PhoneNumber("whatsapp:" + telPara),
            from: new PhoneNumber("whatsapp:+14155238886"),
            body: Mensagem
        );
        }
    }
}
