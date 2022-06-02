using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class FolhaDePagamentoBusiness
    {
        Database.FolhaDePagamentoDatabase db = new Database.FolhaDePagamentoDatabase();
        tb_folhapagamento model = new tb_folhapagamento();

        public void InserirFolha(tb_folhapagamento modelo)
        {
            if(modelo.dt_pagamento == null)
            {
                throw new ArgumentException("Data de pagamento inválida");
            }
            if(modelo.id_funcionario == 0)
            {
                throw new ArgumentException("id do funcionario inválido");
            }
                                
            db.inserirFolha(modelo);
        }

        public List<tb_folhapagamento> ConsultarFolha(int id)
        {
            List<tb_folhapagamento> lista = db.ConsultarFolha(id);

            return lista;
        }

        public void AlterarFolha(tb_folhapagamento modelo)
        {
            db.AlterarFolha(modelo);
        }

        public void RemoverFolha(int id)
        {
            db.RemoverFolha(id);
        }
    }
}
