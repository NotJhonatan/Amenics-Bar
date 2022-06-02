using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class ProdutoDatabase
    {
        Model.ecostorEntities db = new ecostorEntities();

        public void CadastrarProduto(tb_produto produto)
        {
            db.tb_produto.Add(produto);
            db.SaveChanges();

        }
        public List<tb_produto> ConsultarProdutoNome(string Produtonome)
        {
            List<tb_produto> lista = db.tb_produto.Where(x=> x.nm_produto.Contains(Produtonome)).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoCategoria(string categoria)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.ds_categoria.Contains(categoria)).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoFornecedor(string idFornecedor)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.tb_fornecedor.nm_fornecedor.Contains(idFornecedor)).ToList();

            return lista;
        }

        public List<tb_produto> ConsultarTodosProdutos()
        {
            List<tb_produto> lista = db.tb_produto.ToList();

            return lista;
        }

        public List<tb_produto> ConsultarProdutoID(int id)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_produto == id).ToList();

            return lista;
        }

        public tb_produto Listar(int id)
        {
            tb_produto modelo = db.tb_produto.FirstOrDefault(x => x.id_produto == id);

            return modelo;
        }

        public void AlterarProduto(tb_produto modelo)
        {
            tb_produto alterar = db.tb_produto.FirstOrDefault(x => x.id_produto == modelo.id_produto);

            alterar.nm_produto = modelo.nm_produto;
            alterar.vl_valor = modelo.vl_valor;
            alterar.ds_categoria = modelo.ds_categoria;
            alterar.id_fornecedor = modelo.id_fornecedor;
            alterar.img_produto = modelo.img_produto;
            
            db.SaveChanges();
          
        }
        public void RemoverProduto(int id)
        {
           tb_produto deletar = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            db.tb_produto.Remove(deletar);

            db.SaveChanges();

        }





    }
}
