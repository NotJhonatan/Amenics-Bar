using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FolhaDePagamentoDatabase
    {
        Model.ecostorEntities db = new Model.ecostorEntities();
        public void inserirFolha(Model.tb_folhapagamento modelo)
        {
            db.tb_folhapagamento.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_folhapagamento> ConsultarFolha(int id)
        {
            List<tb_folhapagamento> lista = db.tb_folhapagamento.Where(x => x.id_funcionario == id).ToList();

            return lista;
        }
        public void AlterarFolha(tb_folhapagamento modelo)
        {
            tb_folhapagamento alterar = db.tb_folhapagamento.FirstOrDefault(x => x.id_funcionario == x.id_funcionario);

            alterar.vl_fgts = modelo.vl_fgts;
            alterar.vl_gratificacoes = modelo.vl_gratificacoes;
            alterar.vl_inss = modelo.vl_inss;
            alterar.vl_ir = modelo.vl_ir;
            alterar.vl_liquido = modelo.vl_liquido;
            alterar.vl_planoOdonto = modelo.vl_planoOdonto;
            alterar.vl_planoSaude = modelo.vl_planoSaude;
            alterar.vl_plr = modelo.vl_plr;
            alterar.vl_salarioFamilia = modelo.vl_salarioFamilia;
            alterar.vl_valeAlimentacao = modelo.vl_valeAlimentacao;
            alterar.vl_valeRefeicao = modelo.vl_valeRefeicao;
            alterar.vl_valeTransporte = modelo.vl_valeTransporte;
            alterar.dt_pagamento = modelo.dt_pagamento;
            alterar.id_funcionario = modelo.id_funcionario;

            db.SaveChanges();
        }

        public void RemoverFolha(int id)
        {
            tb_folhapagamento deletar = db.tb_folhapagamento.FirstOrDefault(x => x.id_funcionario == id);
            db.tb_folhapagamento.Remove(deletar);

            db.SaveChanges();
        }
    }
}
