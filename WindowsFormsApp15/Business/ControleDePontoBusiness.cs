using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class ControleDePontoBusiness
    {

      Database.ControledePontoDatabase db = new Database.ControledePontoDatabase();
      tb_controledeponto model = new tb_controledeponto();

      public void CadastrarPonto(tb_controledeponto modelo)
       {        
            if(modelo.id_funcionario == 0)
            {
                throw new ArgumentException("Id do funcionário inválido");
            }

            db.CadastrarPonto(modelo);

        }
        public List<tb_controledeponto> ConsultarPonto()
        {
            List<tb_controledeponto> lista = db.ConsultarPonto();

            return lista;
        }
        public Model.tb_controledeponto Listar(int id)
        {
            Model.tb_controledeponto modelo = db.Listar(id);

            return modelo;
        }

        public List<tb_controledeponto> ListarPorFuncionario(int id, int mes)
        {
            List<tb_controledeponto> modelo = db.ListarPorFuncionario(id, mes);

            return modelo;
        }

        public void AlterarPonto(tb_controledeponto modelo)
        {
            if (modelo.id_funcionario == 0)
            {
                throw new ArgumentException("id do funcionário inválido");
            }

            db.AlterarPonto(modelo);

        }
        public void RemoverPonto(int id)
        {
            if (model.id_funcionario == 0)
            {
                throw new ArgumentException("id do funcionário inválido");
            }

            db.RemoverPonto(id);


        }
    }
}
