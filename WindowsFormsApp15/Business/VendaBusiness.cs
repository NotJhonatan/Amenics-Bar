using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class VendaBusiness
    {
        Database.VendaDatabase db = new Database.VendaDatabase();

        public void InserirVenda(tb_venda modelo)
        {
            if(modelo.id_usuario == 0)
            {
                throw new ArgumentException("Usuario Invalido");
            }
            if (modelo.vl_valorTotal == 0)
            {
                throw new ArgumentException("Total inválido");
            }
            if (modelo.dt_saida == null)
            {
                throw new ArgumentException("Data de saida inválida");
            }

            db.InserirVenda(modelo);
        }
        public void InserirVendaItem(tb_venda_item modelo)
        {
            if(modelo.id_estoque == 0)
            {
                throw new ArgumentException("Id estoque inválido");
            }
          
            db.InserirVendaitem(modelo);
        }

        public List<tb_venda> ConsultarVenda(DateTime venda)
        {
            List<tb_venda> lista = db.ConsultarVenda(venda);

            return lista;
        }

        public List<tb_venda_item> ConsultarVendaItem(DateTime venda)
        {
            List<tb_venda_item> lista = db.ConsultarVendaItem(venda);

            return lista;
        }
        public tb_venda Listar(int id)
        {
            tb_venda modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarVenda(tb_venda modelo)
        {
            if (modelo.id_usuario == 0)
            {
                throw new ArgumentException("Usuario Invalido");
            }
            if (modelo.vl_valorTotal == 0)
            {
                throw new ArgumentException("Total inválido");
            }
            if (modelo.dt_saida == null)
            {
                throw new ArgumentException("Data de saida inválida");
            }

            db.AlterarVenda(modelo);
        }
        public void RemoverVenda(int id)
        {
            db.RemoverVenda(id);
        }
    }
}
