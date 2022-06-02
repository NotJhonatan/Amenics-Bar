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

namespace WindowsFormsApp15.Telas.Folha_de_Pagamento
{
    public partial class frmDeletarFolha : Form
    {
        public frmDeletarFolha()
        {
            InitializeComponent();

            this.CarregarFuncionario();
        }

        public void CarregarTela(tb_folhapagamento model)
        {
            cboFuncionario.Text = model.tb_funcionario.nm_funcionario;
            cboMes.Text = model.dt_pagamento.Month.ToString();

            nudAli.Value = model.vl_valeAlimentacao;
            nudDentario.Value = model.vl_planoOdonto;
            nudDescontos.Value = model.vl_liquido;
            nudFamilia.Value = model.vl_salarioFamilia;
            nudFGTS.Value = model.vl_fgts;
            nudGratificacoes.Value = model.vl_gratificacoes;
            nudINSS.Value = model.vl_inss;
            nudIR.Value = model.vl_ir;
            nudPlanosaude.Value = model.vl_planoSaude;
            nudPLR.Value = model.vl_plr;
            nudRef.Value = model.vl_valeRefeicao;
            nudTransporte.Value = model.vl_valeTransporte;
        }

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboFuncionario.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboFuncionario.DataSource = lista;
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_funcionario comboFuncionario = cboFuncionario.SelectedItem as tb_funcionario;
                                                  
                int mes = Convert.ToInt32(cboMes.Text);

                Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();
                Business.ControleDePontoBusiness controleBusiness = new Business.ControleDePontoBusiness();

                List<tb_controledeponto> ponto = controleBusiness.ListarPorFuncionario(comboFuncionario.id_funcionario, mes);
                tb_funcionario funcionario = funcionarioBusiness.Listar(comboFuncionario.id_funcionario);

                Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                Image imagem = imageConverter.byteArrayToImage(funcionario.img_foto);

                imgFoto.Image = imagem;

                int entradaAlmoco = ponto.Sum(x => x.dt_saidaAlmoco.Value.Hour);
                int voltaAlmoco = ponto.Sum(x => x.dt_voltaAlmoco.Value.Hour);

                int totalAlmoco = voltaAlmoco - entradaAlmoco;

                int chegada = ponto.Sum(x => x.dt_chegada.Value.Hour);
                int saida = ponto.Sum(x => x.dt_saida.Value.Hour);

                int expediente = (saida - chegada) - totalAlmoco;

                nudDescontos.Value = expediente * funcionario.vl_salarioPorHora;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gerar Folha de Pagamento");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
