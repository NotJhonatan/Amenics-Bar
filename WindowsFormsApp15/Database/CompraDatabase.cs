using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class CompraDatabase
    {
        Model.ecostorEntities db = new ecostorEntities();


        public void InserirCompra(tb_compra modelo)
        {
            db.tb_compra.Add(modelo);
            db.SaveChanges();
        }

        public void InserirCompraitem(tb_compra_item modelo)
        {
            db.tb_compra_item.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_compra> ConsultarCompra()
        {
            List<tb_compra> lista = db.tb_compra.ToList();

            return lista;
        }
        public List<tb_compra_item> ConsultarCompraItem(DateTime data)
        {
            List<tb_compra_item> lista = db.tb_compra_item.Where(x => x.tb_compra.dt_compra == data).ToList();

            return lista;
        }
        public tb_compra Listar(int id)
        {
            tb_compra modelo = db.tb_compra.FirstOrDefault(x => x.id_compra == id);

            return modelo;
        }

        public void AlterarCompra(tb_compra modelo)
        {
            tb_compra alterar = db.tb_compra.FirstOrDefault(x => x.id_compra == x.id_compra);

            modelo.dt_compra = alterar.dt_compra;
            modelo.vl_valorTotal = alterar.vl_valorTotal;


            db.SaveChanges();
        }
        public void RemoverCompra(int id)
        {
            tb_compra deletar = db.tb_compra.FirstOrDefault(x => x.id_compra == id);
            db.tb_compra.Remove(deletar);
            db.SaveChanges();
        }
    }
}
