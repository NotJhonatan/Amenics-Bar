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

namespace WindowsFormsApp15.Telas
{
    public partial class nudSaude : Form
    {
        public nudSaude()
        {
            InitializeComponent();

            this.CarregarFuncionario();
        }

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboID.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboID.DataSource = lista;
        }

        private void Calculo()
        {
            Business.FolhaDePagamentoBusiness business = new Business.FolhaDePagamentoBusiness();
            tb_folhapagamento model = new tb_folhapagamento();

            int id = Convert.ToInt32(cboID.Text);

            decimal gratificaçoes = nudGratificacoes.Value;
            decimal Plr = nudPLR.Value;
            decimal INSS = nudINSS.Value;
            decimal FGTS = nudFGTS.Value;
            decimal planosaude = nudPlanosaude.Value;
            decimal salariofami = nudFamilia.Value;
            decimal VA = nudAli.Value;
            decimal VR = nudRef.Value;
            decimal VT = nudTransporte.Value;
            decimal planodent = nudDentario.Value;
            decimal bruto = nudDescontos.Value;
            decimal IR = nudIR.Value;

            lblLiquido.Text = (bruto + gratificaçoes - Plr - INSS - FGTS - planosaude - salariofami - IR - VA - VR - VT - planodent).ToString();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_funcionario comboFuncionario = cboID.SelectedItem as tb_funcionario;

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

        private void nudGratificacoes_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();
        }

        private void nudPLR_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudINSS_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudFGTS_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudPlanosaude_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudFamilia_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudAli_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudRef_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudTransporte_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudDentario_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void nudDescontos_ValueChanged(object sender, EventArgs e)
        {
            this.Calculo();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Model.tb_folhapagamento model = new Model.tb_folhapagamento();
            Business.FolhaDePagamentoBusiness business = new Business.FolhaDePagamentoBusiness();

            tb_funcionario comboFuncionario = cboID.SelectedItem as tb_funcionario;

            model.dt_pagamento = dtpPagamento.Value.Date;
            model.id_funcionario = comboFuncionario.id_funcionario;
            model.vl_fgts = nudFGTS.Value;
            model.vl_gratificacoes = nudGratificacoes.Value;
            model.vl_inss = nudINSS.Value;
            model.vl_ir = nudIR.Value;
            model.vl_planoOdonto = nudDentario.Value;
            model.vl_planoSaude = nudPlanosaude.Value;
            model.vl_plr = nudPLR.Value;
            model.vl_salarioFamilia = nudFamilia.Value;
            model.vl_valeAlimentacao = nudAli.Value;
            model.vl_valeRefeicao = nudRef.Value;
            model.vl_valeTransporte = nudTransporte.Value;
            model.vl_liquido = Convert.ToDecimal(lblLiquido.Text);

            business.InserirFolha(model);

            MessageBox.Show("Folha cadastrada com sucesso");
        }
    }
}
