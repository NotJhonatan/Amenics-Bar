using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class EstoqueDatabase
    {
        Model.ecostorEntities db = new ecostorEntities();

        public void CadastrarEstoque(tb_estoque modelo)
        {
            db.tb_estoque.Add(modelo);

            db.SaveChanges();
        }
        public List<tb_estoque> ConsultarEstoque()
        {
            List<tb_estoque> lista = db.tb_estoque.ToList();

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueId(int id)
        {
            List<tb_estoque> lista = db.tb_estoque.Where(x => x.id_produto == id).ToList();

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueProduto(string produto)
        {
            List<tb_estoque> lista = db.tb_estoque.Where(x => x.tb_produto.nm_produto.Contains(produto)).ToList();

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueVendidoSim(bool vendido)
        {
            List<tb_estoque> lista = db.tb_estoque.Where(x => x.bt_vendido == true).ToList();

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueVendidoNao(bool vendido)
        {
            List<tb_estoque> lista = db.tb_estoque.Where(x => x.bt_vendido == false).ToList();

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueData(DateTime data)
        {
            List<tb_estoque> lista = db.tb_estoque.Where(x => x.dt_entrada == data).ToList();

            return lista;
        }

        public tb_estoque Listar(int id)
        {
            tb_estoque modelo = db.tb_estoque.FirstOrDefault(x => x.id_estoque == id);

            return modelo;
        }

        public tb_estoque ListarAlterarNaoVendidos(int id)
        {
            tb_estoque modelo = db.tb_estoque.FirstOrDefault(x => x.id_produto == id && x.bt_vendido == false);

            if(modelo == null)
            {
                return modelo;
            }
            else
            {
                modelo.bt_vendido = true;
                db.SaveChanges();

                return modelo;
            }

        }

        public void AlterarEstoque(tb_estoque modelo)
        {
            tb_estoque alterar = db.tb_estoque.FirstOrDefault(x => x.id_estoque == x.id_estoque);

            alterar.bt_vendido = modelo.bt_vendido;
            alterar.dt_entrada = modelo.dt_entrada;
            alterar.id_produto = modelo.id_produto;

            db.SaveChanges();
        }
        public void RemoverEstoque(int id)
        {
            tb_estoque deletar = db.tb_estoque.FirstOrDefault(x => x.id_estoque == id);

            db.tb_estoque.Remove(deletar);
            db.SaveChanges();
        }

        public void AlterarEstoqueNaoVendido(int id)
        {
            tb_estoque alterar = db.tb_estoque.FirstOrDefault(x => x.id_estoque == id);

            alterar.bt_vendido = false;

            db.SaveChanges();
        }

    }
}
